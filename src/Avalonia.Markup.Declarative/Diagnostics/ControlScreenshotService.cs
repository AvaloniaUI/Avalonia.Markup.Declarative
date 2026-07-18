using System;
using System.IO;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// How a control screenshot should be produced.
/// </summary>
public enum ScreenshotMode
{
    /// <summary>Render just the control's own subtree.</summary>
    Isolated,

    /// <summary>Render the whole window, then crop to the control's bounds (shows real context).</summary>
    InContext
}

/// <summary>
/// A captured image in both encoded (PNG) and raw (BGRA8888) form. The raw pixels enable pixel
/// comparison without re-decoding.
/// </summary>
/// <param name="Png">PNG-encoded bytes.</param>
/// <param name="Bgra">Raw BGRA8888 pixels, row-major, stride = <c>Size.Width * 4</c>.</param>
/// <param name="Size">Pixel dimensions.</param>
public readonly record struct CapturedImage(byte[] Png, byte[] Bgra, PixelSize Size);

/// <summary>
/// Captures PNG screenshots of controls and top-levels via <see cref="RenderTargetBitmap"/>.
/// </summary>
/// <remarks>
/// <para>
/// Rendering re-draws the visual, so it works even for a minimized or occluded window. All methods
/// must run on the UI thread; the caller is responsible for marshaling.
/// </para>
/// <para>
/// A rendering backend must be present in the running app (it is, in a real desktop app; headless
/// tests need <c>Avalonia.Headless.Skia</c>).
/// </para>
/// </remarks>
public static class ControlScreenshotService
{
    private static readonly Vector StandardDpi = new(96, 96);

    /// <summary>
    /// Captures a control as PNG bytes.
    /// </summary>
    public static byte[] CaptureControlPng(Control control, ScreenshotMode mode = ScreenshotMode.Isolated)
    {
        using var bitmap = RenderControl(control, mode);
        return Encode(bitmap);
    }

    /// <summary>
    /// Captures an entire top-level (window) as PNG bytes.
    /// </summary>
    public static byte[] CaptureTopLevelPng(TopLevel top)
    {
        ArgumentNullException.ThrowIfNull(top);
        using var bitmap = RenderToBitmap(top, ResolveTopLevelSize(top));
        return Encode(bitmap);
    }

    /// <summary>
    /// Captures a control as PNG plus raw pixels (for comparison).
    /// </summary>
    public static CapturedImage CaptureControl(Control control, ScreenshotMode mode = ScreenshotMode.Isolated)
    {
        using var bitmap = RenderControl(control, mode);
        return Capture(bitmap);
    }

    /// <summary>
    /// Captures a top-level as PNG plus raw pixels (for comparison).
    /// </summary>
    public static CapturedImage CaptureTopLevel(TopLevel top)
    {
        ArgumentNullException.ThrowIfNull(top);
        using var bitmap = RenderToBitmap(top, ResolveTopLevelSize(top));
        return Capture(bitmap);
    }

    /// <summary>
    /// Like <see cref="CaptureTopLevel"/>, but first drains queued layout/binding work and, if the
    /// captured frame is degenerate (a single flat color — the classic "captured before the layout
    /// settled" empty/dark frame), forces a layout pass and retries once. Prevents an empty screenshot
    /// right after opening a popup or switching state (P6).
    /// </summary>
    public static CapturedImage CaptureTopLevelStable(TopLevel top)
    {
        ArgumentNullException.ThrowIfNull(top);
        return CaptureStable(top, () => CaptureTopLevel(top));
    }

    /// <summary>
    /// Like <see cref="CaptureControl"/>, but drains queued work and retries once on a degenerate frame
    /// (P6).
    /// </summary>
    public static CapturedImage CaptureControlStable(Control control, ScreenshotMode mode = ScreenshotMode.Isolated)
    {
        ArgumentNullException.ThrowIfNull(control);
        return CaptureStable(control, () => CaptureControl(control, mode));
    }

    private static CapturedImage CaptureStable(Control target, Func<CapturedImage> capture)
    {
        // Settle first: flush layout/binding/render jobs so we don't snapshot a half-arranged frame.
        Dispatcher.UIThread.RunJobs();
        var image = capture();

        if (!IsDegenerate(image.Bgra))
            return image;

        // A flat frame usually means layout hadn't run yet. Force one more measure/arrange + flush and
        // re-capture once; if it is still flat it is genuinely a solid-colored control and we keep it.
        target.InvalidateMeasure();
        target.InvalidateArrange();
        Dispatcher.UIThread.RunJobs();
        return capture();
    }

    /// <summary>
    /// Returns true when the pixel buffer is (near-)uniform — a single flat color — which for a UI
    /// capture almost always means an unrendered / not-yet-laid-out frame rather than real content.
    /// </summary>
    public static bool IsDegenerate(byte[] bgra)
    {
        if (bgra is null || bgra.Length < 8)
            return true;

        var pixelCount = bgra.Length / 4;
        if (pixelCount == 0)
            return true;

        byte b0 = bgra[0], g0 = bgra[1], r0 = bgra[2], a0 = bgra[3];
        var identical = 0L;
        for (var i = 0; i < bgra.Length; i += 4)
        {
            if (bgra[i] == b0 && bgra[i + 1] == g0 && bgra[i + 2] == r0 && bgra[i + 3] == a0)
                identical++;
        }

        // >= 99.9% of pixels are the exact same color ⇒ treat as degenerate.
        return identical >= pixelCount * 0.999;
    }

    /// <summary>
    /// Encodes a raw BGRA8888 buffer as PNG (used to render diff/overlay images).
    /// </summary>
    public static byte[] EncodePng(byte[] bgra, PixelSize size)
    {
        ArgumentNullException.ThrowIfNull(bgra);
        using var writeable = new WriteableBitmap(size, StandardDpi, PixelFormat.Bgra8888, AlphaFormat.Premul);
        using (var frameBuffer = writeable.Lock())
        {
            var stride = size.Width * 4;
            for (var y = 0; y < size.Height; y++)
                Marshal.Copy(bgra, y * stride, IntPtr.Add(frameBuffer.Address, y * frameBuffer.RowBytes), stride);
        }

        using var stream = new MemoryStream();
        writeable.Save(stream);
        return stream.ToArray();
    }

    private static RenderTargetBitmap RenderControl(Control control, ScreenshotMode mode)
    {
        ArgumentNullException.ThrowIfNull(control);
        EnsureLaidOut(control);

        if (mode == ScreenshotMode.InContext && TopLevel.GetTopLevel(control) is { } top)
            return RenderControlInContext(control, top);

        return RenderToBitmap(control, control.Bounds.Size);
    }

    private static RenderTargetBitmap RenderControlInContext(Control control, TopLevel top)
    {
        var topSize = ResolveTopLevelSize(top);
        using var full = new RenderTargetBitmap(ToPixelSize(topSize), StandardDpi);
        full.Render(top);

        var origin = control.TranslatePoint(new Point(0, 0), top) ?? new Point(0, 0);
        var size = control.Bounds.Size;
        if (size.Width <= 0 || size.Height <= 0)
            throw new InvalidOperationException(
                $"Control '{DescribeControl(control)}' has a zero size and cannot be captured.");

        var cropped = new RenderTargetBitmap(ToPixelSize(size), StandardDpi);
        using (var ctx = cropped.CreateDrawingContext())
        {
            ctx.DrawImage(
                full,
                new Rect(origin.X, origin.Y, size.Width, size.Height),
                new Rect(0, 0, size.Width, size.Height));
        }

        return cropped;
    }

    private static RenderTargetBitmap RenderToBitmap(Visual visual, Size size)
    {
        if (size.Width <= 0 || size.Height <= 0)
            throw new InvalidOperationException(
                $"Visual '{visual.GetType().Name}' has a zero size and cannot be captured. " +
                "It may be collapsed, not yet laid out, or off-screen.");

        var rtb = new RenderTargetBitmap(ToPixelSize(size), StandardDpi);
        rtb.Render(visual);
        return rtb;
    }

    private static byte[] Encode(RenderTargetBitmap bitmap)
    {
        using var stream = new MemoryStream();
        bitmap.Save(stream);
        return stream.ToArray();
    }

    private static CapturedImage Capture(RenderTargetBitmap bitmap)
    {
        var png = Encode(bitmap);
        var size = bitmap.PixelSize;
        var stride = size.Width * 4;
        var bgra = new byte[stride * size.Height];

        var handle = GCHandle.Alloc(bgra, GCHandleType.Pinned);
        try
        {
            bitmap.CopyPixels(new PixelRect(0, 0, size.Width, size.Height), handle.AddrOfPinnedObject(), bgra.Length, stride);
        }
        finally
        {
            handle.Free();
        }

        return new CapturedImage(png, bgra, size);
    }

    private static void EnsureLaidOut(Control control)
    {
        // A control already in the visual tree has valid bounds; only force layout for a detached or
        // never-measured control, so we never disturb a live layout.
        if (control.Bounds.Width > 0 && control.Bounds.Height > 0)
            return;

        if (TopLevel.GetTopLevel(control) is not null)
            return;

        control.Measure(Size.Infinity);
        control.Arrange(new Rect(control.DesiredSize));
    }

    private static Size ResolveTopLevelSize(TopLevel top)
    {
        var bounds = top.Bounds.Size;
        if (bounds.Width > 0 && bounds.Height > 0)
            return bounds;

        return top.ClientSize;
    }

    private static PixelSize ToPixelSize(Size size) =>
        new(
            Math.Max(1, (int)Math.Ceiling(size.Width)),
            Math.Max(1, (int)Math.Ceiling(size.Height)));

    private static string DescribeControl(Control control) =>
        string.IsNullOrEmpty(control.Name) ? control.GetType().Name : $"{control.GetType().Name} ('{control.Name}')";
}
