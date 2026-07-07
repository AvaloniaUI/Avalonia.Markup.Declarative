using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Avalonia.Controls;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Answers "what control is at this pixel?" — the reverse of a screenshot. An agent that sees an
/// artifact at (x, y) in a capture can ask what actually sits there and get the topmost-to-root chain.
/// </summary>
/// <remarks>
/// Screenshots are rendered at 96 DPI, so <b>image pixel coordinates equal window-client DIP
/// coordinates</b> — a point read off a screenshot can be passed straight in. Must be called on the UI
/// thread; the caller is responsible for marshaling.
/// </remarks>
public static class HitTester
{
    /// <summary>
    /// Describes the visual stack at <paramref name="point"/> (in <paramref name="top"/>'s client
    /// coordinates), from the topmost hit visual up to the root.
    /// </summary>
    /// <remarks>
    /// Uses a geometric hit test (point-in-bounds over the visual tree) rather than the renderer's
    /// compositor hit test, so it is deterministic and works without a running render loop. It does not
    /// account for arbitrary render transforms or clipping, which is fine for locating a control.
    /// </remarks>
    public static string Describe(TopLevel top, Point point)
    {
        ArgumentNullException.ThrowIfNull(top);

        var leaf = HitTest(top, point);
        if (leaf is null)
            return $"Nothing was hit at ({Format(point.X)}, {Format(point.Y)}) in {DescribeTop(top)}.";

        var builder = new StringBuilder();
        builder.Append($"Hit at ({Format(point.X)}, {Format(point.Y)}) in {DescribeTop(top)} (topmost → root):\n");

        var chain = new List<Visual> { leaf };
        chain.AddRange(leaf.GetVisualAncestors());

        var indent = 0;
        foreach (var visual in chain)
        {
            for (var i = 0; i < indent; i++)
                builder.Append("  ");

            builder.Append(visual.GetType().Name);
            if (visual is StyledElement { Name: { Length: > 0 } name })
                builder.Append(" #").Append(name);

            builder.Append(' ').Append(FormatRect(visual.Bounds)).Append('\n');
            indent++;
        }

        return builder.ToString();
    }

    /// <summary>
    /// Returns the topmost visual at <paramref name="point"/> (the deepest one containing it, ties
    /// resolved to the later-painted sibling), or null when only the top-level itself is there.
    /// </summary>
    public static Visual? HitTest(TopLevel top, Point point)
    {
        ArgumentNullException.ThrowIfNull(top);

        var hits = new List<Visual>();
        Collect(top, top, point, hits);

        Visual? leaf = null;
        var bestDepth = -1;
        foreach (var visual in hits)
        {
            var depth = visual.GetVisualAncestors().Count();
            if (depth >= bestDepth)
            {
                bestDepth = depth;
                leaf = visual;
            }
        }

        return ReferenceEquals(leaf, top) ? null : leaf;
    }

    private static void Collect(Visual visual, TopLevel top, Point point, List<Visual> hits)
    {
        // Don't descend into hidden subtrees — they aren't visible to a user click either.
        if (!visual.IsVisible)
            return;

        if (ReferenceEquals(visual, top))
        {
            hits.Add(visual);
        }
        else if (visual.TranslatePoint(new Point(0, 0), top) is { } origin &&
                 new Rect(origin, visual.Bounds.Size).Contains(point))
        {
            hits.Add(visual);
        }

        foreach (var child in visual.GetVisualChildren())
            Collect(child, top, point, hits);
    }

    private static string DescribeTop(TopLevel top) =>
        top is Window { Title: { Length: > 0 } title } ? $"Window '{title}'" : top.GetType().Name;

    private static string Format(double value) => value.ToString("0.#", CultureInfo.InvariantCulture);

    private static string FormatRect(Rect r) =>
        string.Format(CultureInfo.InvariantCulture, "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]", r.X, r.Y, r.Width, r.Height);
}
