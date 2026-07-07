using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Reports the property values of a live control — the "what is this actually set to" companion to the
/// visual tree and layout report. Useful for debugging appearance/state (brushes, fonts, flags) and
/// bindings (which properties the author actually set).
/// </summary>
/// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
public static class PropertyInspector
{
    /// <summary>
    /// Describes <paramref name="control"/>'s properties. When <paramref name="names"/> is null/empty,
    /// returns a curated view: effective state, DataContext, style classes, and <em>every locally-set
    /// styled property</em> (i.e. the values the author assigned). When names are given, returns just
    /// those (matched against styled properties first, then CLR properties).
    /// </summary>
    public static string DescribeProperties(Control control, string[]? names = null)
    {
        ArgumentNullException.ThrowIfNull(control);

        var builder = new StringBuilder();
        builder.Append(Identity(control)).Append('\n');

        if (names is { Length: > 0 })
        {
            foreach (var name in names)
                builder.Append("  ").Append(name).Append(" = ").Append(ResolveNamed(control, name)).Append('\n');

            return builder.ToString();
        }

        AppendField(builder, "State",
            $"IsEnabled={control.IsEnabled} IsVisible={control.IsVisible} " +
            $"IsEffectivelyVisible={control.IsEffectivelyVisible} IsFocused={control.IsFocused} " +
            $"IsPointerOver={control.IsPointerOver} Opacity={FormatNumber(control.Opacity)} ZIndex={control.ZIndex}");

        AppendField(builder, "DataContext", control.DataContext is { } dc ? dc.GetType().Name : "null");

        var classes = string.Join(" ", control.Classes);
        if (classes.Length > 0)
            AppendField(builder, "Classes", classes);

        AppendLocalProperties(builder, control);

        return builder.ToString();
    }

    private static void AppendLocalProperties(StringBuilder builder, Control control)
    {
        var registered = AvaloniaPropertyRegistry.Instance.GetRegistered(control);
        var locals = registered
            .Where(p => !p.IsReadOnly && control.IsSet(p))
            .OrderBy(p => p.Name, StringComparer.Ordinal)
            .ToArray();

        if (locals.Length == 0)
        {
            AppendField(builder, "Set (local)", "(none)");
            return;
        }

        builder.Append("  Set (local):\n");
        foreach (var property in locals)
        {
            object? value;
            try
            {
                value = control.GetValue(property);
            }
            catch (Exception ex)
            {
                value = $"<threw: {ex.GetType().Name}>";
            }

            builder.Append("    ").Append(property.Name).Append(" = ").Append(FormatValue(value)).Append('\n');
        }
    }

    private static string ResolveNamed(Control control, string name)
    {
        var property = AvaloniaPropertyRegistry.Instance.GetRegistered(control)
            .FirstOrDefault(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

        if (property is not null)
        {
            try
            {
                return FormatValue(control.GetValue(property));
            }
            catch (Exception ex)
            {
                return $"<threw: {ex.GetType().Name}>";
            }
        }

        var clr = control.GetType().GetProperty(
            name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
        if (clr is not null && clr.CanRead)
        {
            try
            {
                return FormatValue(clr.GetValue(control));
            }
            catch (Exception ex)
            {
                return $"<threw: {ex.GetType().Name}>";
            }
        }

        return "<not found>";
    }

    private static string FormatValue(object? value) =>
        value switch
        {
            null => "null",
            string s => Quote(Shorten(s)),
            ISolidColorBrush brush => brush.Color.ToString(),
            IBrush otherBrush => otherBrush.GetType().Name,
            IEnumerable enumerable and not string => DescribeEnumerable(enumerable),
            IFormattable formattable => formattable.ToString(null, CultureInfo.InvariantCulture),
            _ => Quote(Shorten(value.ToString()))
        };

    private static string DescribeEnumerable(IEnumerable enumerable)
    {
        var count = 0;
        foreach (var _ in enumerable)
            count++;
        return $"{enumerable.GetType().Name}(Count={count})";
    }

    private static string Identity(Control control) =>
        control.Name is { Length: > 0 } name
            ? $"{control.GetType().Name} #{name}"
            : control.GetType().Name;

    private static void AppendField(StringBuilder builder, string label, string value) =>
        builder.Append("  ").Append(label).Append(": ").Append(value).Append('\n');

    private static string FormatNumber(double value) => value.ToString("0.##", CultureInfo.InvariantCulture);

    private static string? Shorten(string? value, int max = 80) =>
        string.IsNullOrEmpty(value) || value.Length <= max ? value : value.Substring(0, max) + "…";

    private static string Quote(string? value) =>
        value is null ? "null" : value.IndexOf(' ') >= 0 ? $"'{value}'" : value;
}
