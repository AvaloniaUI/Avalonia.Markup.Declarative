using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Avalonia.Controls;
using Avalonia.Diagnostics;
using Avalonia.Media;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Reports <em>where</em> a property's value comes from — a local set, a style, a template, an
/// animation, or inheritance — using Avalonia's public property-diagnostic API. This is the tool for
/// "why is this the value?" when a style or template is overriding what you expected.
/// </summary>
/// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
public static class PropertySourceInspector
{
    /// <summary>
    /// Describes the source (priority) of one property (when <paramref name="propertyName"/> is given) or
    /// of every locally-set styled property (when it is null/empty).
    /// </summary>
    public static string Describe(Control control, string? propertyName = null)
    {
        ArgumentNullException.ThrowIfNull(control);

        var builder = new StringBuilder();
        builder.Append(Identity(control)).Append('\n');

        if (!string.IsNullOrWhiteSpace(propertyName))
        {
            var property = AvaloniaPropertyRegistry.Instance.GetRegistered(control)
                .FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase));

            if (property is null)
                return builder.Append("  ").Append(propertyName).Append(" is not a styled property of this control.").ToString();

            AppendOne(builder, control, property);
            return builder.ToString();
        }

        var set = AvaloniaPropertyRegistry.Instance.GetRegistered(control)
            .Where(control.IsSet)
            .OrderBy(p => p.Name, StringComparer.Ordinal)
            .ToArray();

        if (set.Length == 0)
            return builder.Append("  (no styled properties are set)").ToString();

        foreach (var property in set)
            AppendOne(builder, control, property);

        return builder.ToString();
    }

    private static void AppendOne(StringBuilder builder, Control control, AvaloniaProperty property)
    {
        builder.Append("  ").Append(property.Name).Append(" = ");
        try
        {
            var diagnostic = control.GetDiagnostic(property);
            builder.Append(FormatValue(diagnostic.Value))
                .Append("  [source=").Append(diagnostic.Priority).Append(']');
        }
        catch (Exception ex)
        {
            builder.Append("<threw: ").Append(ex.GetType().Name).Append('>');
        }

        builder.Append('\n');
    }

    private static string FormatValue(object? value) =>
        value switch
        {
            null => "null",
            string s => s.Length <= 60 ? s : s.Substring(0, 60) + "…",
            ISolidColorBrush brush => brush.Color.ToString(),
            IBrush otherBrush => otherBrush.GetType().Name,
            IFormattable formattable => formattable.ToString(null, CultureInfo.InvariantCulture),
            _ => value.ToString() ?? "null"
        };

    private static string Identity(Control control) =>
        control.Name is { Length: > 0 } name ? $"{control.GetType().Name} #{name}" : control.GetType().Name;
}
