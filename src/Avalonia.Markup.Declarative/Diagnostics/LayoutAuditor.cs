using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Avalonia.Controls;
using Avalonia.LogicalTree;
using Avalonia.Media;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// A single layout anomaly found by <see cref="LayoutAuditor"/>.
/// </summary>
/// <param name="Severity">How likely this is a real problem.</param>
/// <param name="Kind">A short machine-readable kind (e.g. <c>zero-size</c>, <c>off-screen</c>).</param>
/// <param name="Control">The offending control.</param>
/// <param name="Detail">Human-readable specifics (measured vs arranged size, overflow, ...).</param>
public sealed record LayoutFinding(DiagnosticSeverity Severity, string Kind, Control Control, string Detail)
{
    /// <summary>Renders the finding as a single agent-friendly line.</summary>
    public string Format()
    {
        var identity = Control.Name is { Length: > 0 } name
            ? $"{Control.GetType().Name} #{name}"
            : Control.GetType().Name;

        var line = $"{Severity} {Kind} {identity} {FormatRect(Control.Bounds)}";
        return Detail.Length > 0 ? $"{line}  {Detail}" : line;
    }

    private static string FormatRect(Rect r) =>
        string.Format(CultureInfo.InvariantCulture, "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]", r.X, r.Y, r.Width, r.Height);
}

/// <summary>
/// Sweeps a subtree of authored controls and reports common layout problems — the automated "layout
/// lint" that turns screenshot-staring into a structured checklist. It walks the <em>logical</em> tree
/// so it audits the controls you actually wrote, not templated internals.
/// </summary>
/// <remarks>
/// Must be called on the UI thread; the caller is responsible for marshaling. Geometric checks
/// (off-screen / clipped / overflow / overlap) use window-relative rectangles, so they are independent
/// of each control's local coordinate space. Checks are deliberately conservative to keep false
/// positives low; per-control detail is included so the agent can triage.
/// </remarks>
public static class LayoutAuditor
{
    private const double Epsilon = 0.5;
    private const int MaxFindings = 200;
    private const int MaxSiblingsForOverlap = 60;

    /// <summary>
    /// Audits the subtree rooted at <paramref name="root"/>. Returns findings ordered by severity
    /// (errors first), then by document order.
    /// </summary>
    public static IReadOnlyList<LayoutFinding> Audit(Visual root, TopLevel? top = null)
    {
        ArgumentNullException.ThrowIfNull(root);
        top ??= TopLevel.GetTopLevel(root);

        var findings = new List<LayoutFinding>();
        Visit(root, layoutParent: null, top, insideScroll: false, findings);

        return findings
            .Take(MaxFindings)
            .OrderByDescending(f => f.Severity)
            .ToArray();
    }

    private static void Visit(ILogical node, Control? layoutParent, TopLevel? top, bool insideScroll, List<LayoutFinding> findings)
    {
        if (findings.Count >= MaxFindings)
            return;

        if (node is Control control)
        {
            // Skip subtrees the author explicitly hid — their contents are not "on screen" bugs.
            if (!control.IsVisible)
                return;

            InspectControl(control, layoutParent, top, insideScroll, findings);

            if (control is Panel panel)
                CheckOverlap(panel, top, findings);

            var childScroll = insideScroll || control is ScrollViewer;
            foreach (var child in control.GetLogicalChildren())
                Visit(child, control, top, childScroll, findings);
        }
        else
        {
            // A non-control logical node (rare): pass through without changing the layout parent.
            foreach (var child in node.GetLogicalChildren())
                Visit(child, layoutParent, top, insideScroll, findings);
        }
    }

    private static void InspectControl(Control control, Control? layoutParent, TopLevel? top, bool insideScroll, List<LayoutFinding> findings)
    {
        var bounds = control.Bounds;
        var desired = control.DesiredSize;

        // zero-size: the control asked for space (non-zero DesiredSize) but got a zero dimension.
        if ((bounds.Width <= Epsilon || bounds.Height <= Epsilon) &&
            desired.Width > Epsilon && desired.Height > Epsilon)
        {
            findings.Add(new LayoutFinding(DiagnosticSeverity.Error, "zero-size", control,
                $"DesiredSize={FormatSize(desired)} but arranged to zero — squeezed out by its container."));
        }

        // text-clipped: a text control whose desired size exceeds the space it got.
        AddTextClipping(control, findings);

        // Geometric checks need a window frame of reference and a real size.
        if (top is null || ReferenceEquals(control, top) || bounds.Width <= Epsilon || bounds.Height <= Epsilon)
            return;

        var windowRect = WindowRect(control, top);
        if (windowRect is not { } wr)
            return;

        if (!insideScroll)
        {
            var client = new Rect(top.ClientSize);
            if (!client.Intersects(wr))
            {
                findings.Add(new LayoutFinding(DiagnosticSeverity.Error, "off-screen", control,
                    $"window-rel {FormatRect(wr)} is outside the {FormatSize(top.ClientSize)} client area."));
            }
            else if (!ContainsWithin(client, wr))
            {
                findings.Add(new LayoutFinding(DiagnosticSeverity.Warning, "partially-clipped", control,
                    $"window-rel {FormatRect(wr)} extends past the {FormatSize(top.ClientSize)} client area."));
            }

            // out-of-parent: overflows a non-scrolling, non-canvas layout container.
            if (layoutParent is StackPanel or DockPanel or Grid or WrapPanel &&
                WindowRect(layoutParent, top) is { } pr && !ContainsWithin(pr, wr))
            {
                findings.Add(new LayoutFinding(DiagnosticSeverity.Warning, "out-of-parent", control,
                    $"extends beyond its {layoutParent.GetType().Name} parent {FormatRect(pr)}."));
            }
        }
    }

    private static void AddTextClipping(Control control, List<LayoutFinding> findings)
    {
        var bounds = control.Bounds;
        var desired = control.DesiredSize;
        if (bounds.Width <= Epsilon || bounds.Height <= Epsilon)
            return;

        switch (control)
        {
            case TextBlock tb:
            {
                var horizontal = tb.TextWrapping == TextWrapping.NoWrap && desired.Width > bounds.Width + Epsilon;
                var vertical = desired.Height > bounds.Height + Epsilon;
                if (horizontal || vertical)
                {
                    findings.Add(new LayoutFinding(DiagnosticSeverity.Warning, "text-clipped", control,
                        $"DesiredSize={FormatSize(desired)} > arranged {FormatSize(bounds.Size)} " +
                        $"(wrapping={tb.TextWrapping}, trimming={tb.TextTrimming})."));
                }

                break;
            }

            case TextBox tx when desired.Width > bounds.Width + Epsilon || desired.Height > bounds.Height + Epsilon:
                findings.Add(new LayoutFinding(DiagnosticSeverity.Warning, "text-clipped", control,
                    $"DesiredSize={FormatSize(desired)} > arranged {FormatSize(bounds.Size)}."));
                break;
        }
    }

    private static void CheckOverlap(Panel panel, TopLevel? top, List<LayoutFinding> findings)
    {
        // Overlap is a bug in sequential panels; in Grid/Canvas it is usually intentional layering.
        if (panel is not (StackPanel or DockPanel or WrapPanel) || top is null)
            return;

        var children = panel.Children
            .Where(c => c.IsVisible && c.Bounds is { Width: > Epsilon, Height: > Epsilon })
            .Take(MaxSiblingsForOverlap)
            .Select(c => (Control: c, Rect: WindowRect(c, top)))
            .Where(x => x.Rect is not null)
            .ToArray();

        for (var i = 0; i < children.Length; i++)
        for (var j = i + 1; j < children.Length; j++)
        {
            if (findings.Count >= MaxFindings)
                return;

            if (IntersectionArea(children[i].Rect!.Value, children[j].Rect!.Value) > 1)
            {
                findings.Add(new LayoutFinding(DiagnosticSeverity.Warning, "overlap", children[i].Control,
                    $"overlaps sibling {Describe(children[j].Control)} inside {panel.GetType().Name}."));
            }
        }
    }

    private static Rect? WindowRect(Control control, TopLevel? top)
    {
        if (top is null || ReferenceEquals(control, top))
            return null;

        return control.TranslatePoint(new Point(0, 0), top) is { } origin
            ? new Rect(origin, control.Bounds.Size)
            : null;
    }

    private static bool ContainsWithin(Rect outer, Rect inner) =>
        inner.X >= outer.X - Epsilon &&
        inner.Y >= outer.Y - Epsilon &&
        inner.Right <= outer.Right + Epsilon &&
        inner.Bottom <= outer.Bottom + Epsilon;

    private static double IntersectionArea(Rect a, Rect b)
    {
        var x = Math.Max(a.X, b.X);
        var y = Math.Max(a.Y, b.Y);
        var right = Math.Min(a.Right, b.Right);
        var bottom = Math.Min(a.Bottom, b.Bottom);
        return right <= x || bottom <= y ? 0 : (right - x) * (bottom - y);
    }

    private static string Describe(Control control) =>
        control.Name is { Length: > 0 } name ? $"{control.GetType().Name} #{name}" : control.GetType().Name;

    private static string FormatRect(Rect r) =>
        string.Format(CultureInfo.InvariantCulture, "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]", r.X, r.Y, r.Width, r.Height);

    private static string FormatSize(Size s) =>
        string.Format(CultureInfo.InvariantCulture, "{0:0.#}x{1:0.#}", s.Width, s.Height);
}
