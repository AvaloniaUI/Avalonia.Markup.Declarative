using System;
using System.Collections.Generic;
using System.Threading;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>A stored screenshot, keyed by a short id.</summary>
/// <param name="Id">Short id, e.g. <c>s3</c>.</param>
/// <param name="Label">Human description (window/control it captured).</param>
/// <param name="Image">The captured pixels/PNG.</param>
/// <param name="TimestampUtc">When it was taken.</param>
public sealed record ScreenshotEntry(string Id, string Label, CapturedImage Image, DateTimeOffset TimestampUtc);

/// <summary>The result of comparing two screenshots.</summary>
public sealed record ScreenshotComparison(
    bool SizeMismatch,
    PixelSize SizeA,
    PixelSize SizeB,
    int ChangedPixels,
    int TotalPixels,
    double ChangedFraction,
    PixelRect? ChangedBounds,
    byte[]? DiffPng);

/// <summary>
/// An in-memory ring buffer of the most recent screenshots so an agent can diff before/after captures
/// without eyeballing them. Holds raw pixels, so comparison is exact and needs no image decoding.
/// </summary>
public static class ScreenshotStore
{
    private const int Capacity = 10;

    private static readonly object Gate = new();
    private static readonly LinkedList<ScreenshotEntry> Entries = new();
    private static long _counter;

    /// <summary>Stores a capture and returns its new id.</summary>
    public static string Add(string label, CapturedImage image)
    {
        var id = "s" + Interlocked.Increment(ref _counter).ToString(System.Globalization.CultureInfo.InvariantCulture);
        var entry = new ScreenshotEntry(id, label, image, DateTimeOffset.Now);

        lock (Gate)
        {
            Entries.AddLast(entry);
            while (Entries.Count > Capacity)
                Entries.RemoveFirst();
        }

        return id;
    }

    /// <summary>Returns the stored entries, newest last.</summary>
    public static IReadOnlyList<ScreenshotEntry> List()
    {
        lock (Gate)
            return new List<ScreenshotEntry>(Entries);
    }

    /// <summary>Returns the entry with <paramref name="id"/>, or null.</summary>
    public static ScreenshotEntry? Get(string id)
    {
        lock (Gate)
        {
            foreach (var entry in Entries)
                if (entry.Id == id)
                    return entry;
        }

        return null;
    }

    /// <summary>
    /// Compares two captures. Returns null if either id is unknown. A pixel counts as changed when any
    /// channel differs by more than <paramref name="tolerance"/> (0–255), which suppresses anti-aliasing
    /// noise. When <paramref name="includeDiff"/> is set and the sizes match, a diff PNG is produced
    /// (unchanged pixels dimmed, changed pixels red).
    /// </summary>
    public static ScreenshotComparison? Compare(string idA, string idB, int tolerance = 8, bool includeDiff = true)
    {
        var a = Get(idA);
        var b = Get(idB);
        if (a is null || b is null)
            return null;

        var sizeA = a.Image.Size;
        var sizeB = b.Image.Size;
        if (sizeA != sizeB)
            return new ScreenshotComparison(true, sizeA, sizeB, 0, 0, 1.0, null, null);

        var pixelsA = a.Image.Bgra;
        var pixelsB = b.Image.Bgra;
        var width = sizeA.Width;
        var height = sizeA.Height;
        var totalPixels = width * height;

        var changed = 0;
        int minX = width, minY = height, maxX = -1, maxY = -1;
        var diff = includeDiff ? new byte[pixelsB.Length] : null;

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var i = (y * width + x) * 4;
                var isChanged =
                    Math.Abs(pixelsA[i] - pixelsB[i]) > tolerance ||
                    Math.Abs(pixelsA[i + 1] - pixelsB[i + 1]) > tolerance ||
                    Math.Abs(pixelsA[i + 2] - pixelsB[i + 2]) > tolerance ||
                    Math.Abs(pixelsA[i + 3] - pixelsB[i + 3]) > tolerance;

                if (isChanged)
                {
                    changed++;
                    if (x < minX) minX = x;
                    if (y < minY) minY = y;
                    if (x > maxX) maxX = x;
                    if (y > maxY) maxY = y;

                    if (diff is not null)
                    {
                        diff[i] = 0;         // B
                        diff[i + 1] = 0;     // G
                        diff[i + 2] = 255;   // R
                        diff[i + 3] = 255;   // A
                    }
                }
                else if (diff is not null)
                {
                    // Dim the unchanged background so changes pop.
                    var gray = (byte)((pixelsB[i] + pixelsB[i + 1] + pixelsB[i + 2]) / 3 * 0.3);
                    diff[i] = gray;
                    diff[i + 1] = gray;
                    diff[i + 2] = gray;
                    diff[i + 3] = 255;
                }
            }
        }

        PixelRect? bounds = maxX >= 0 ? new PixelRect(minX, minY, maxX - minX + 1, maxY - minY + 1) : null;
        var fraction = totalPixels == 0 ? 0 : (double)changed / totalPixels;

        byte[]? diffPng = null;
        if (diff is not null && changed > 0)
            diffPng = ControlScreenshotService.EncodePng(diff, sizeA);

        return new ScreenshotComparison(false, sizeA, sizeB, changed, totalPixels, fraction, bounds, diffPng);
    }

    /// <summary>Removes all stored entries (mainly for tests).</summary>
    public static void Clear()
    {
        lock (Gate)
            Entries.Clear();
    }
}
