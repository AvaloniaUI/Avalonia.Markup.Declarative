using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Maps a live control back to the declarative component (a <see cref="ViewBase"/>) that built it — the
/// key hop for an agent that edits code, since it turns "this control on screen" into "the class to open".
/// </summary>
/// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
public static class ComponentSourceLocator
{
    /// <summary>
    /// Describes the <see cref="ViewBase"/> component that owns <paramref name="control"/>, plus any
    /// enclosing components (nested views), by full type name and assembly.
    /// </summary>
    public static string Describe(Control control)
    {
        ArgumentNullException.ThrowIfNull(control);

        var chain = new List<ViewBase>();
        Visual? current = control;
        while (current is not null)
        {
            if (current is ViewBase view)
                chain.Add(view);
            current = current.GetVisualParent();
        }

        var identity = control.Name is { Length: > 0 } name
            ? $"{control.GetType().Name} #{name}"
            : control.GetType().Name;

        // When source tagging is enabled, the exact declaration site beats the component-level guess.
        var taggedSource = AgentSourceTagging.GetSource(control);

        if (chain.Count == 0)
        {
            var standalone = $"{identity} is not inside a declarative ViewBase component (it may be a plain control or a template part).";
            return taggedSource is null ? standalone : $"{standalone}\nDeclared at: {taggedSource}";
        }

        var nearest = chain[0].GetType();
        var builder = new StringBuilder();
        builder.Append("Control: ").Append(identity).Append('\n');
        if (taggedSource is not null)
            builder.Append("Declared at: ").Append(taggedSource).Append('\n');
        builder.Append("Owning component: ").Append(nearest.FullName).Append('\n');
        builder.Append("Assembly: ").Append(nearest.Assembly.GetName().Name).Append('\n');

        if (chain.Count > 1)
        {
            builder.Append("Component nesting (innermost → outermost):\n");
            foreach (var view in chain)
                builder.Append("  ").Append(view.GetType().FullName).Append('\n');
        }

        builder.Append("Tip: search the codebase for 'class ").Append(nearest.Name).Append("'.");
        return builder.ToString();
    }
}
