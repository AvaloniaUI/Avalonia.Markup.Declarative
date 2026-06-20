using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Media.Imaging;

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
        ArgumentNullException.ThrowIfNull(control);
        EnsureLaidOut(control);

        if (mode == ScreenshotMode.InContext && TopLevel.GetTopLevel(control) is { } top)
            return CaptureControlInContext(control, top);

        return RenderToPng(control, control.Bounds.Size);
    }

    /// <summary>
    /// Captures an entire top-level (window) as PNG bytes.
    /// </summary>
    public static byte[] CaptureTopLevelPng(TopLevel top)
    {
        ArgumentNullException.ThrowIfNull(top);
        return RenderToPng(top, ResolveTopLevelSize(top));
    }

    private static byte[] CaptureControlInContext(Control control, TopLevel top)
    {
        var topSize = ResolveTopLevelSize(top);
        using var full = new RenderTargetBitmap(ToPixelSize(topSize), StandardDpi);
        full.Render(top);

        var origin = control.TranslatePoint(new Point(0, 0), top) ?? new Point(0, 0);
        var size = control.Bounds.Size;
        if (size.Width <= 0 || size.Height <= 0)
            throw new InvalidOperationException(
                $"Control '{DescribeControl(control)}' has a zero size and cannot be captured.");

        using var cropped = new RenderTargetBitmap(ToPixelSize(size), StandardDpi);
        using (var ctx = cropped.CreateDrawingContext())
        {
            ctx.DrawImage(
                full,
                new Rect(origin.X, origin.Y, size.Width, size.Height),
                new Rect(0, 0, size.Width, size.Height));
        }

        return Encode(cropped);
    }

    private static byte[] RenderToPng(Visual visual, Size size)
    {
        if (size.Width <= 0 || size.Height <= 0)
            throw new InvalidOperationException(
                $"Visual '{visual.GetType().Name}' has a zero size and cannot be captured. " +
                "It may be collapsed, not yet laid out, or off-screen.");

        using var rtb = new RenderTargetBitmap(ToPixelSize(size), StandardDpi);
        rtb.Render(visual);
        return Encode(rtb);
    }

    private static byte[] Encode(RenderTargetBitmap bitmap)
    {
        using var stream = new MemoryStream();
        bitmap.Save(stream);
        return stream.ToArray();
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
