using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Automation.Peers;
using Avalonia.Automation.Provider;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;

using ModelContextProtocol.Server;

namespace Declarative.Avalonia.AgentTools.Tools;

/// <summary>
/// Tier-2 remote-control MCP tools. This type is registered only when
/// <see cref="AgentInspectorOptions.EnableInteraction"/> is set, because it can change app state.
/// </summary>
/// <remarks>
/// Interaction is dispatched through Avalonia's UI Automation peers (the same accessibility layer a
/// screen reader drives), which is the most general way to act on any control in a <em>live</em> app:
/// it is platform-agnostic and works regardless of which control type is targeted. Headless input
/// simulation (<c>Avalonia.Headless</c>) is deliberately not used — it requires the headless platform
/// and cannot drive a real desktop window. Each automation action has a typed-property fallback for
/// controls whose peer does not implement the matching pattern.
/// </remarks>
[McpServerToolType]
public sealed class InteractionTools
{
    private InteractionTools() { }

    [McpServerTool(Name = "invoke", Destructive = true), Description(
        "EXPERIMENTAL remote control: performs a user action on a control, dispatched via UI Automation. " +
        "Target by Name or by visible label (automation name). Actions: " +
        "'invoke' (press a Button/MenuItem/Hyperlink), " +
        "'select' (choose a TabItem/ListBoxItem/RadioButton — e.g. switch tabs), " +
        "'toggle' (CheckBox/ToggleButton), " +
        "'set' (set value: TextBox text, or a Slider/NumericUpDown number — pass it in 'value'), " +
        "'expand'/'collapse' (TreeViewItem/Expander/ComboBox), " +
        "'focus', 'scroll' (bring into view), 'context_menu' (open the context menu), " +
        "'key' (press a key/gesture from 'value', e.g. 'Enter' or 'Ctrl+S'; targets the named control or the focused element), " +
        "'type' (raw text input from 'value' into the named control or the focused element). " +
        "Disabled unless EnableInteraction was set when starting the inspector.")]
    public static Task<string> Invoke(
        [Description("Name or visible label (automation name) of the target control. Optional for 'key'/'type' (defaults to the focused element).")]
        string? name,
        [Description("Action: invoke | select | toggle | set | expand | collapse | focus | scroll | context_menu | key | type.")]
        string action,
        [Description("Value used by 'set' (text/number), 'key' (gesture) and 'type' (text).")]
        string? value = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            switch (action?.Trim().ToLowerInvariant())
            {
                case "key":
                    return PressKey(name, value);
                case "type":
                    return TypeText(name, value);
            }

            if (string.IsNullOrWhiteSpace(name))
                return "A control name is required for this action.";

            var control = AgentToolContext.FindControl(name);
            if (control is null)
                return $"No control named (or labeled) '{name}' was found. Use get_visual_tree to discover names.";

            var typeName = control.GetType().Name;

            switch (action?.Trim().ToLowerInvariant())
            {
                case "invoke":
                    if (ResolveProvider<IInvokeProvider>(control) is { } invoke)
                    {
                        invoke.Invoke();
                        return $"Invoked '{name}'.";
                    }

                    if (control is Button)
                    {
                        control.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        return $"Clicked '{name}'.";
                    }

                    return $"Control '{name}' ({typeName}) does not support 'invoke'.";

                case "select":
                    if (ResolveProvider<ISelectionItemProvider>(control) is { } selectionItem)
                    {
                        selectionItem.Select();
                        return $"Selected '{name}'.";
                    }

                    if (control is TabItem tabItem)
                    {
                        tabItem.IsSelected = true;
                        return $"Selected '{name}'.";
                    }

                    return $"Control '{name}' ({typeName}) does not support 'select'.";

                case "toggle":
                    if (ResolveProvider<IToggleProvider>(control) is { } toggleProvider)
                    {
                        toggleProvider.Toggle();
                        return $"Toggled '{name}'.";
                    }

                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = !(toggleButton.IsChecked ?? false);
                        return $"Toggled '{name}' to {toggleButton.IsChecked}.";
                    }

                    return $"Control '{name}' ({typeName}) does not support 'toggle'.";

                case "set":
                    return SetValue(control, name, value);

                case "expand":
                    if (ResolveProvider<IExpandCollapseProvider>(control) is { } expand)
                    {
                        expand.Expand();
                        return $"Expanded '{name}'.";
                    }

                    if (SetExpanded(control, true))
                        return $"Expanded '{name}'.";

                    return $"Control '{name}' ({typeName}) does not support 'expand'.";

                case "collapse":
                    if (ResolveProvider<IExpandCollapseProvider>(control) is { } collapse)
                    {
                        collapse.Collapse();
                        return $"Collapsed '{name}'.";
                    }

                    if (SetExpanded(control, false))
                        return $"Collapsed '{name}'.";

                    return $"Control '{name}' ({typeName}) does not support 'collapse'.";

                case "focus":
                    return control.Focus() ? $"Focused '{name}'." : $"Could not focus '{name}'.";

                case "scroll":
                    if (TryCreatePeer(control) is not { } scrollPeer)
                        return $"Could not bring '{name}' into view: no automation peer is available (the control may not be realized yet).";
                    scrollPeer.BringIntoView();
                    return $"Brought '{name}' into view.";

                case "context_menu":
                    if (TryCreatePeer(control) is not { } menuPeer)
                        return $"Could not open the context menu for '{name}': no automation peer is available (the control may not be realized yet).";
                    menuPeer.ShowContextMenu();
                    return $"Opened context menu for '{name}'.";

                default:
                    return $"Unknown action '{action}'. " +
                           "Use invoke | select | toggle | set | expand | collapse | focus | scroll | context_menu | key | type.";
            }
        });

    /// <summary>
    /// Returns the requested automation provider from <paramref name="control"/>'s peer, or from the
    /// nearest visual ancestor whose peer exposes it. This mirrors how a real click/keypress resolves
    /// to the handling control: addressing by visible label often lands on an inner element (e.g. the
    /// <c>TextBlock</c> inside a <c>TreeViewItem</c> or <c>Button</c>), and the actionable element is an
    /// ancestor.
    /// </summary>
    private static T? ResolveProvider<T>(Control control) where T : class
    {
        Visual? current = control;
        while (current is Control owner)
        {
            // A peer can throw for controls that aren't fully realized; treat that the same as
            // "no provider here" and keep walking up to the actionable ancestor.
            if (TryCreatePeer(owner)?.GetProvider<T>() is { } provider)
                return provider;

            current = owner.GetVisualParent();
        }

        return null;
    }

    /// <summary>
    /// Creates the automation peer for <paramref name="control"/>, returning null instead of throwing
    /// for controls that aren't fully realized (mirrors <c>ControlLocator.FindByAutomationName</c>).
    /// </summary>
    private static AutomationPeer? TryCreatePeer(Control control)
    {
        try
        {
            return ControlAutomationPeer.CreatePeerForElement(control);
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// Fallback for expand/collapse when no <see cref="IExpandCollapseProvider"/> is exposed (Avalonia's
    /// <c>TreeViewItem</c> has no such peer): walks up to the nearest expandable control and sets its
    /// <c>IsExpanded</c>. Returns false if no expandable ancestor was found.
    /// </summary>
    private static bool SetExpanded(Control control, bool expanded)
    {
        Visual? current = control;
        while (current is Control owner)
        {
            switch (owner)
            {
                case TreeViewItem treeViewItem:
                    treeViewItem.IsExpanded = expanded;
                    return true;
                case Expander expander:
                    expander.IsExpanded = expanded;
                    return true;
            }

            current = owner.GetVisualParent();
        }

        return false;
    }

    private static string SetValue(Control control, string name, string? value)
    {
        // Text first: a TextBox-style control exposes IValueProvider.
        if (ResolveProvider<IValueProvider>(control) is { IsReadOnly: false } valueProvider)
        {
            valueProvider.SetValue(value ?? string.Empty);
            return $"Set '{name}' value to '{value}'.";
        }

        // Numeric controls (Slider, NumericUpDown, ScrollBar) expose IRangeValueProvider.
        if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var number) &&
            ResolveProvider<IRangeValueProvider>(control) is { IsReadOnly: false } rangeProvider)
        {
            rangeProvider.SetValue(number);
            return $"Set '{name}' value to {number}.";
        }

        // Fallbacks for controls whose peer does not implement a value pattern.
        switch (control)
        {
            case TextBox textBox:
                textBox.Text = value ?? string.Empty;
                return $"Set '{name}'.Text to '{value}'.";

            case ToggleButton toggle when bool.TryParse(value, out var isChecked):
                toggle.IsChecked = isChecked;
                return $"Set '{name}'.IsChecked to {isChecked}.";

            default:
                return $"'set' is not supported for control '{name}' ({control.GetType().Name}).";
        }
    }

    private static string PressKey(string? name, string? gesture)
    {
        if (string.IsNullOrWhiteSpace(gesture))
            return "A key or gesture (e.g. 'Enter', 'Ctrl+S') is required in 'value' for the 'key' action.";

        KeyGesture parsed;
        try
        {
            parsed = KeyGesture.Parse(gesture);
        }
        catch (Exception)
        {
            return $"'{gesture}' is not a valid key gesture. Examples: 'Enter', 'Escape', 'Down', 'Ctrl+S'.";
        }

        if (!TryResolveInputTarget(name, out var target, out var error))
            return error;

        try
        {
            target.RaiseEvent(new KeyEventArgs
            {
                RoutedEvent = InputElement.KeyDownEvent,
                Key = parsed.Key,
                KeyModifiers = parsed.KeyModifiers,
                Source = target,
            });
            target.RaiseEvent(new KeyEventArgs
            {
                RoutedEvent = InputElement.KeyUpEvent,
                Key = parsed.Key,
                KeyModifiers = parsed.KeyModifiers,
                Source = target,
            });
        }
        catch (Exception ex)
        {
            return $"Could not press '{gesture}'{TargetSuffix(name)}: {ex.Message}";
        }

        return $"Pressed '{gesture}'{TargetSuffix(name)}.";
    }

    private static string TypeText(string? name, string? text)
    {
        if (string.IsNullOrEmpty(text))
            return "Text is required in 'value' for the 'type' action.";

        if (!TryResolveInputTarget(name, out var target, out var error))
            return error;

        // A TextBox is the common case; insert at the caret directly — reliable across platforms and
        // independent of synthetic-input plumbing.
        if (target is TextBox textBox)
        {
            var current = textBox.Text ?? string.Empty;
            var caret = Math.Clamp(textBox.CaretIndex, 0, current.Length);
            textBox.Text = current.Insert(caret, text);
            textBox.CaretIndex = caret + text.Length;
            return $"Typed '{text}'{TargetSuffix(name)}.";
        }

        // Otherwise raise a routed text-input event for controls that handle it themselves.
        try
        {
            target.RaiseEvent(new TextInputEventArgs
            {
                RoutedEvent = InputElement.TextInputEvent,
                Text = text,
                Source = target,
            });
        }
        catch (Exception ex)
        {
            return $"Could not type{TargetSuffix(name)}: {ex.Message}";
        }

        return $"Typed '{text}'{TargetSuffix(name)}.";
    }

    private static bool TryResolveInputTarget(string? name, out Interactive target, out string error)
    {
        target = null!;
        error = string.Empty;

        if (!string.IsNullOrWhiteSpace(name))
        {
            if (AgentToolContext.FindControl(name) is { } control)
            {
                target = control;
                return true;
            }

            error = $"No control named (or labeled) '{name}' was found.";
            return false;
        }

        if (AgentToolContext.GetFocusedElement() is Interactive focused)
        {
            target = focused;
            return true;
        }

        error = "No control name was given and nothing currently has focus.";
        return false;
    }

    private static string TargetSuffix(string? name) =>
        string.IsNullOrWhiteSpace(name) ? " on the focused element" : $" on '{name}'";
}
