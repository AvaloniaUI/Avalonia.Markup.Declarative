using System;
using System.Collections.Generic;
using Avalonia.Automation.Peers;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Resolves a control by its <c>Name</c> within a view, first via the view's NameScope and then by
/// walking the visual tree (covering nested name scopes). Identification by <c>Name</c> relies on the
/// existing <c>.Name(...)</c> extension; agents should name the controls they iterate on.
/// </summary>
public static class ControlLocator
{
    /// <summary>
    /// Finds the first control at or below <paramref name="root"/> whose UI Automation name (its
    /// visible label, e.g. a <c>TabItem</c>'s header) equals <paramref name="automationName"/>.
    /// </summary>
    /// <remarks>
    /// This is a fallback for unnamed controls: many controls carry no <c>Name</c> but do expose a
    /// meaningful automation name. Must be called on the UI thread; the caller marshals.
    /// </remarks>
    public static Control? FindByAutomationName(Visual root, string automationName)
    {
        ArgumentNullException.ThrowIfNull(root);
        if (string.IsNullOrWhiteSpace(automationName))
            return null;

        foreach (var descendant in root.GetSelfAndVisualDescendants())
        {
            if (descendant is not Control control)
                continue;

            string? peerName;
            try
            {
                peerName = ControlAutomationPeer.CreatePeerForElement(control).GetName();
            }
            catch (Exception)
            {
                // A peer can throw for controls that are not fully realized; just skip them.
                continue;
            }

            if (string.Equals(peerName?.Trim(), automationName.Trim(), StringComparison.OrdinalIgnoreCase))
                return control;
        }

        return null;
    }

    /// <summary>
    /// Finds the first control named <paramref name="name"/> at or below <paramref name="root"/>.
    /// </summary>
    /// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
    public static Control? FindByName(Visual root, string name)
    {
        ArgumentNullException.ThrowIfNull(root);
        if (string.IsNullOrEmpty(name))
            return null;

        if (TryFromNameScope(root, name, out var fromScope))
            return fromScope;

        foreach (var descendant in root.GetSelfAndVisualDescendants())
        {
            if (descendant is Control control && control.Name == name)
                return control;

            if (TryFromNameScope(descendant, name, out var nested))
                return nested;
        }

        return null;
    }

    /// <summary>
    /// Finds every control at or below <paramref name="root"/> whose type name matches
    /// <paramref name="typeName"/> (its simple name, e.g. <c>Button</c>, or its full name), case-insensitive.
    /// </summary>
    /// <remarks>
    /// This is the "by type" arm of a selector: agents often want to inspect or highlight all controls
    /// of a kind ("all Buttons") without knowing their names. Must be called on the UI thread; the caller
    /// is responsible for marshaling.
    /// </remarks>
    public static IReadOnlyList<Control> FindAllByType(Visual root, string typeName)
    {
        ArgumentNullException.ThrowIfNull(root);
        var matches = new List<Control>();
        if (string.IsNullOrWhiteSpace(typeName))
            return matches;

        var wanted = typeName.Trim();
        foreach (var descendant in root.GetSelfAndVisualDescendants())
        {
            if (descendant is not Control control)
                continue;

            var type = control.GetType();
            if (string.Equals(type.Name, wanted, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(type.FullName, wanted, StringComparison.OrdinalIgnoreCase))
            {
                matches.Add(control);
            }
        }

        return matches;
    }

    /// <summary>
    /// Finds every control at or below <paramref name="root"/> whose visible text contains
    /// <paramref name="text"/> (case-insensitive). Checks <see cref="TextBlock"/>/<see cref="TextBox"/>
    /// text, string <see cref="ContentControl.Content"/> and string <see cref="HeaderedContentControl.Header"/>.
    /// </summary>
    /// <remarks>
    /// The reverse of a screenshot: an agent reads a label in the pixels and wants the control behind
    /// it. Must be called on the UI thread; the caller is responsible for marshaling.
    /// </remarks>
    public static IReadOnlyList<Control> FindAllByText(Visual root, string text)
    {
        ArgumentNullException.ThrowIfNull(root);
        var matches = new List<Control>();
        if (string.IsNullOrEmpty(text))
            return matches;

        foreach (var descendant in root.GetSelfAndVisualDescendants())
        {
            if (descendant is Control control &&
                GetVisibleText(control) is { } value &&
                value.Contains(text, StringComparison.OrdinalIgnoreCase))
            {
                matches.Add(control);
            }
        }

        return matches;
    }

    private static string? GetVisibleText(Control control) =>
        control switch
        {
            TextBlock tb => tb.Text,
            TextBox tx => tx.Text,
            HeaderedContentControl { Header: string header } => header,
            ContentControl { Content: string content } => content,
            _ => null
        };

    private static bool TryFromNameScope(Visual visual, string name, out Control? control)
    {
        control = null;
        if (visual is not StyledElement styled)
            return false;

        if (NameScope.GetNameScope(styled)?.Find(name) is Control found)
        {
            control = found;
            return true;
        }

        return false;
    }
}
