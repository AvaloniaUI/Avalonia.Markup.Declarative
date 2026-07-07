using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Renders a control's <c>DataContext</c> (view-model) as readable text so an agent can debug bindings
/// without a debugger — it can see the property names and current values a binding could target.
/// </summary>
/// <remarks>
/// Reflection over public readable instance properties. Cycle-safe (by reference identity), collections
/// are summarized rather than expanded, and a getter that throws is reported inline instead of aborting.
/// Depth is bounded (1–3) to keep output small.
/// </remarks>
public static class DataContextInspector
{
    /// <summary>
    /// Describes <paramref name="dataContext"/> to a nesting depth of <paramref name="depth"/> (1–3).
    /// </summary>
    public static string Describe(object? dataContext, int depth = 1)
    {
        if (dataContext is null)
            return "DataContext is null.";

        var maxLevel = Math.Clamp(depth, 1, 3);

        var builder = new StringBuilder();
        builder.Append(dataContext.GetType().Name);
        if (dataContext is INotifyPropertyChanged)
            builder.Append(" (INotifyPropertyChanged)");
        builder.Append('\n');

        var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);
        AppendMembers(builder, dataContext, maxLevel, 1, visited);
        return builder.ToString();
    }

    private static void AppendMembers(StringBuilder builder, object obj, int maxLevel, int level, HashSet<object> visited)
    {
        if (!visited.Add(obj))
        {
            Indent(builder, level);
            builder.Append("(cycle)\n");
            return;
        }

        var properties = obj.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.CanRead && p.GetIndexParameters().Length == 0)
            .OrderBy(p => p.Name, StringComparer.Ordinal);

        foreach (var property in properties)
        {
            object? value;
            try
            {
                value = property.GetValue(obj);
            }
            catch (Exception ex)
            {
                Indent(builder, level);
                builder.Append(property.Name).Append(" = <threw: ").Append(ex.GetType().Name).Append(">\n");
                continue;
            }

            Indent(builder, level);
            builder.Append(property.Name).Append(" = ").Append(FormatValue(value)).Append('\n');

            if (value is not null && IsComplex(value) && level < maxLevel)
                AppendMembers(builder, value, maxLevel, level + 1, visited);
        }
    }

    private static string FormatValue(object? value)
    {
        switch (value)
        {
            case null:
                return "null";
            case string s:
                return Quote(Shorten(s));
        }

        if (IsScalar(value))
            return value is IFormattable f ? f.ToString(null, CultureInfo.InvariantCulture) : value.ToString() ?? "null";

        if (value is IEnumerable enumerable)
            return FormatEnumerable(enumerable);

        // Complex object: show its type; members follow on indented lines when depth allows.
        return value.GetType().Name;
    }

    private static string FormatEnumerable(IEnumerable enumerable)
    {
        var items = new List<string>();
        var count = 0;
        foreach (var item in enumerable)
        {
            if (count < 3)
                items.Add(item is null ? "null" : IsScalar(item) || item is string ? Shorten(item.ToString()) ?? "null" : item.GetType().Name);
            count++;
        }

        var preview = items.Count > 0 ? $": {string.Join(", ", items)}{(count > items.Count ? ", …" : string.Empty)}" : string.Empty;
        return $"{enumerable.GetType().Name} [Count={count}]{preview}";
    }

    private static bool IsComplex(object value) =>
        value is not string && !IsScalar(value) && value is not IEnumerable;

    private static bool IsScalar(object value)
    {
        var type = value.GetType();
        return type.IsPrimitive || type.IsEnum ||
               value is decimal or DateTime or DateTimeOffset or TimeSpan or Guid or Uri;
    }

    private static void Indent(StringBuilder builder, int level)
    {
        for (var i = 0; i < level; i++)
            builder.Append("  ");
    }

    private static string? Shorten(string? value, int max = 80) =>
        string.IsNullOrEmpty(value) || value.Length <= max ? value : value.Substring(0, max) + "…";

    private static string Quote(string? value) =>
        value is null ? "null" : value.IndexOf(' ') >= 0 ? $"'{value}'" : value;
}
