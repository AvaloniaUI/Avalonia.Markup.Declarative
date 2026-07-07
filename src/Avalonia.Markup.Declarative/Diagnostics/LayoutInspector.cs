using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Produces a detailed, agent-readable layout report for a single control: its own bounds, its
/// position relative to the window, the size it asked for versus the size it got, alignment, margin,
/// padding, visibility, and the chain of ancestors that arranged it.
/// </summary>
/// <remarks>
/// Where <see cref="VisualTreeInspector"/> gives a compact overview of a whole subtree, this focuses
/// on one control and answers "why did this element end up here / this size / off-screen". Must be
/// called on the UI thread; the caller is responsible for marshaling.
/// </remarks>
public static class LayoutInspector
{
    /// <summary>
    /// Describes the layout of <paramref name="control"/> as a multi-line text block.
    /// </summary>
    public static string DescribeLayout(Control control)
    {
        ArgumentNullException.ThrowIfNull(control);

        var builder = new StringBuilder();

        builder.Append(control.GetType().Name);
        if (control.Name is { Length: > 0 } name)
            builder.Append(" #").Append(name);
        builder.Append('\n');

        var bounds = control.Bounds;
        AppendField(builder, "Bounds", $"{FormatRect(bounds)}  (relative to parent)");

        var top = TopLevel.GetTopLevel(control);
        if (top is not null && !ReferenceEquals(top, control) &&
            control.TranslatePoint(new Point(0, 0), top) is { } origin)
        {
            AppendField(builder, "Window-rel",
                $"{FormatRect(new Rect(origin, bounds.Size))}  (relative to {DescribeTopLevel(top)})");
        }

        AppendField(builder, "DesiredSize", FormatSize(control.DesiredSize));
        AppendField(builder, "Requested",
            $"Width={FormatLength(control.Width)} Height={FormatLength(control.Height)}" +
            $"  Min=({FormatLength(control.MinWidth)},{FormatLength(control.MinHeight)})" +
            $" Max=({FormatLength(control.MaxWidth)},{FormatLength(control.MaxHeight)})");
        AppendField(builder, "Alignment",
            $"Horizontal={control.HorizontalAlignment} Vertical={control.VerticalAlignment}");
        if (control is ContentControl content)
            AppendField(builder, "ContentAlign",
                $"Horizontal={content.HorizontalContentAlignment} Vertical={content.VerticalContentAlignment}");
        AppendField(builder, "Margin", FormatThickness(control.Margin));
        if (TryGetPadding(control, out var padding))
            AppendField(builder, "Padding", FormatThickness(padding));

        AppendField(builder, "Visibility",
            $"IsVisible={control.IsVisible} IsEffectivelyVisible={control.IsEffectivelyVisible}" +
            $" IsEnabled={control.IsEnabled} Opacity={FormatNumber(control.Opacity)} ZIndex={control.ZIndex}");

        if (control.RenderTransform is { } renderTransform)
            AppendField(builder, "RenderTransform", renderTransform.GetType().Name);

        var flags = DescribeFlags(control, top);
        if (flags.Length > 0)
            AppendField(builder, "Flags", flags);

        AppendAncestors(builder, control);

        return builder.ToString();
    }

    private static void AppendAncestors(StringBuilder builder, Control control)
    {
        // GetVisualAncestors yields the immediate parent first up to the root; reverse it so the chain
        // reads top-down (root → control), which mirrors how the visual tree is laid out.
        var chain = control.GetVisualAncestors().Reverse().ToList();
        if (chain.Count == 0)
            return;

        builder.Append("Ancestors (root → control):\n");
        var depth = 1;
        foreach (var ancestor in chain)
        {
            AppendNodeLine(builder, ancestor, depth);
            depth++;
        }

        AppendNodeLine(builder, control, depth);
    }

    private static void AppendNodeLine(StringBuilder builder, Visual visual, int depth)
    {
        for (var i = 0; i < depth; i++)
            builder.Append("  ");

        builder.Append(visual.GetType().Name);
        if (visual is StyledElement { Name: { Length: > 0 } name })
            builder.Append(" #").Append(name);

        builder.Append(' ').Append(FormatRect(visual.Bounds));

        switch (visual)
        {
            case StackPanel stackPanel:
                builder.Append(" Orientation=").Append(stackPanel.Orientation);
                break;
            case Grid:
                builder.Append(" [Grid]");
                break;
        }

        if (!visual.IsVisible)
            builder.Append(" [hidden]");

        builder.Append('\n');
    }

    private static string DescribeFlags(Control control, TopLevel? top)
    {
        var flags = new StringBuilder();

        void Add(string flag)
        {
            if (flags.Length > 0)
                flags.Append(", ");
            flags.Append(flag);
        }

        var bounds = control.Bounds;
        if (bounds.Width <= 0 || bounds.Height <= 0)
            Add("zero-size");

        if (!control.IsVisible)
            Add("hidden");
        else if (!control.IsEffectivelyVisible)
            Add("hidden-by-ancestor");

        if (top is not null && !ReferenceEquals(top, control) &&
            control.TranslatePoint(new Point(0, 0), top) is { } origin &&
            bounds is { Width: > 0, Height: > 0 })
        {
            var onScreen = new Rect(top.ClientSize);
            var placed = new Rect(origin, bounds.Size);
            if (!onScreen.Intersects(placed))
                Add("off-screen");
            else if (!onScreen.Contains(placed))
                Add("partially-clipped");
        }

        return flags.ToString();
    }

    private static bool TryGetPadding(Control control, out Thickness padding)
    {
        switch (control)
        {
            case Decorator decorator:
                padding = decorator.Padding;
                return true;
            case TemplatedControl templated:
                padding = templated.Padding;
                return true;
            case TextBlock textBlock:
                padding = textBlock.Padding;
                return true;
            default:
                padding = default;
                return false;
        }
    }

    private static string DescribeTopLevel(TopLevel top) =>
        top is Window { Title: { Length: > 0 } title } ? $"Window '{title}'" : top.GetType().Name;

    private static void AppendField(StringBuilder builder, string label, string value) =>
        builder.Append("  ").Append(label).Append(':').Append(' ', Math.Max(1, 14 - label.Length)).Append(value).Append('\n');

    private static string FormatRect(Rect r) =>
        string.Format(CultureInfo.InvariantCulture, "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]", r.X, r.Y, r.Width, r.Height);

    private static string FormatSize(Size s) =>
        string.Format(CultureInfo.InvariantCulture, "{0:0.#} x {1:0.#}", s.Width, s.Height);

    private static string FormatThickness(Thickness t) =>
        string.Format(CultureInfo.InvariantCulture, "{0:0.#},{1:0.#},{2:0.#},{3:0.#}", t.Left, t.Top, t.Right, t.Bottom);

    private static string FormatNumber(double value) =>
        value.ToString("0.##", CultureInfo.InvariantCulture);

    private static string FormatLength(double value)
    {
        if (double.IsNaN(value))
            return "Auto";
        if (double.IsPositiveInfinity(value))
            return "∞"; // ∞
        return value.ToString("0.#", CultureInfo.InvariantCulture);
    }
}
