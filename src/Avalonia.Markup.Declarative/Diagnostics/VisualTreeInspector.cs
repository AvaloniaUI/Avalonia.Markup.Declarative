using System;
using System.Globalization;
using System.Text;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Options controlling <see cref="VisualTreeInspector.DumpVisualTree(Visual, VisualTreeDumpOptions?)"/>.
/// </summary>
public sealed class VisualTreeDumpOptions
{
    /// <summary>Maximum depth to traverse. Negative means unlimited.</summary>
    public int MaxDepth { get; set; } = -1;

    /// <summary>Whether to include a few key per-node properties (text, orientation, background, ...).</summary>
    public bool IncludeProperties { get; set; } = true;

    /// <summary>Indentation string used per depth level.</summary>
    public string Indent { get; set; } = "  ";

    internal static readonly VisualTreeDumpOptions Default = new();
}

/// <summary>
/// Produces a compact, agent-readable text rendering of an Avalonia visual tree, including each
/// node's type, <c>Name</c> and layout <c>Bounds</c>. Bounds are the key signal: they let an agent
/// diagnose layout issues (zero size, off-screen, overlap) without pixels.
/// </summary>
public static class VisualTreeInspector
{
    /// <summary>
    /// Dumps the visual tree rooted at <paramref name="root"/>.
    /// </summary>
    /// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
    public static string DumpVisualTree(Visual root, VisualTreeDumpOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(root);
        options ??= VisualTreeDumpOptions.Default;

        var builder = new StringBuilder();
        AppendNode(builder, root, 0, options);
        return builder.ToString();
    }

    private static void AppendNode(StringBuilder builder, Visual visual, int depth, VisualTreeDumpOptions options)
    {
        for (var i = 0; i < depth; i++)
            builder.Append(options.Indent);

        builder.Append(visual.GetType().Name);

        if (visual is StyledElement { Name: { Length: > 0 } name })
            builder.Append(" #").Append(name);

        var bounds = visual.Bounds;
        builder.Append(' ').Append(FormatBounds(bounds));

        if (!visual.IsVisible)
            builder.Append(" [hidden]");
        else if (bounds.Width <= 0 || bounds.Height <= 0)
            builder.Append(" [zero-size]");

        if (options.IncludeProperties)
        {
            var props = DescribeProperties(visual);
            if (props.Length > 0)
                builder.Append("  ").Append(props);
        }

        builder.Append('\n');

        if (options.MaxDepth >= 0 && depth >= options.MaxDepth)
            return;

        foreach (var child in visual.GetVisualChildren())
            AppendNode(builder, child, depth + 1, options);
    }

    private static string FormatBounds(Rect b) =>
        string.Format(
            CultureInfo.InvariantCulture,
            "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]",
            b.X, b.Y, b.Width, b.Height);

    private static string DescribeProperties(Visual visual)
    {
        var parts = new StringBuilder();

        void Add(string key, object? value)
        {
            if (value is null)
                return;
            var text = value.ToString();
            if (string.IsNullOrEmpty(text))
                return;
            if (parts.Length > 0)
                parts.Append(' ');
            parts.Append(key).Append('=').Append(Quote(text!));
        }

        switch (visual)
        {
            case TextBlock tb:
                Add("Text", Shorten(tb.Text));
                break;
            case TextBox tx:
                Add("Text", Shorten(tx.Text));
                break;
            case ContentControl cc when cc.Content is string s:
                Add("Content", Shorten(s));
                break;
            case ContentControl cc:
                Add("Content", cc.Content?.GetType().Name);
                break;
            case StackPanel sp:
                Add("Orientation", sp.Orientation);
                Add("Background", DescribeBrush(sp.Background));
                break;
            case Panel panel:
                Add("Background", DescribeBrush(panel.Background));
                break;
            case Border border:
                Add("Background", DescribeBrush(border.Background));
                break;
            case Image img:
                Add("Source", img.Source?.GetType().Name);
                break;
        }

        if (visual is Layoutable { Opacity: < 1 } layoutable)
            Add("Opacity", layoutable.Opacity.ToString("0.##", CultureInfo.InvariantCulture));

        return parts.ToString();
    }

    private static string? DescribeBrush(IBrush? brush) =>
        brush switch
        {
            null => null,
            ISolidColorBrush solid => solid.Color.ToString(),
            _ => brush.GetType().Name
        };

    private static string? Shorten(string? value, int max = 40)
    {
        if (string.IsNullOrEmpty(value))
            return value;
        return value.Length <= max ? value : value.Substring(0, max) + "…";
    }

    private static string Quote(string value) =>
        value.IndexOf(' ') >= 0 ? "'" + value + "'" : value;
}
