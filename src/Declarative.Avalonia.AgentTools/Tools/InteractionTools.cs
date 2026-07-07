using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Automation.Peers;
using Avalonia.Automation.Provider;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Declarative.Diagnostics;
using Avalonia.Styling;
using Avalonia.Threading;
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
        "'select_item' (choose an item in a ComboBox/ListBox/TabControl by its text — pass it in 'value'), " +
        "'toggle' (CheckBox/ToggleButton), " +
        "'set' (set value: TextBox text, or a Slider/NumericUpDown number — pass it in 'value'), " +
        "'expand'/'collapse' (TreeViewItem/Expander/ComboBox), " +
        "'focus', 'scroll' (bring into view), 'scroll_by' (scroll the nearest ScrollViewer by 'dx,dy' in 'value'), " +
        "'context_menu' (open the context menu), " +
        "'key' (press a key/gesture from 'value', e.g. 'Enter' or 'Ctrl+S'; targets the named control or the focused element), " +
        "'type' (raw text input from 'value' into the named control or the focused element). " +
        "Disabled unless EnableInteraction was set when starting the inspector.")]
    public static Task<string> Invoke(
        [Description("Name or visible label (automation name) of the target control. Optional for 'key'/'type' (defaults to the focused element).")]
        string? name,
        [Description("Action: invoke | select | select_item | toggle | set | expand | collapse | focus | scroll | scroll_by | context_menu | key | type.")]
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

                case "select_item":
                    return SelectItem(control, name, value);

                case "scroll_by":
                    return ScrollBy(control, name, value);

                default:
                    return $"Unknown action '{action}'. " +
                           "Use invoke | select | select_item | toggle | set | expand | collapse | focus | scroll | scroll_by | context_menu | key | type.";
            }
        });

    [McpServerTool(Name = "set_window_size", Destructive = true), Description(
        "Resizes a desktop window so you can verify responsive layout at a breakpoint (e.g. 400/800/1200 " +
        "wide). Returns the resulting client size (which may be clamped by Min/Max) and the previous size " +
        "so you can restore it. Disabled unless EnableInteraction was set.")]
    public static Task<string> SetWindowSize(
        [Description("New width in DIPs.")] double width,
        [Description("New height in DIPs.")] double height,
        [Description("Optional window title or 0-based index. Omit for the main window.")]
        string? windowId = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            if (AgentToolContext.ResolveTopLevel(windowId) is not Window window)
                return "set_window_size requires a desktop Window (the app has none, or this is a single-view top-level).";

            var previous = window.ClientSize;
            window.Width = width;
            window.Height = height;
            Dispatcher.UIThread.RunJobs();

            return string.Format(CultureInfo.InvariantCulture,
                "Resized '{0}' from client {1:0.#}x{2:0.#} to {3:0.#}x{4:0.#} (requested {5:0.#}x{6:0.#}).",
                window.Title, previous.Width, previous.Height, window.ClientSize.Width, window.ClientSize.Height, width, height);
        });

    [McpServerTool(Name = "set_theme", Destructive = true), Description(
        "Switches the application theme variant so you can verify both light and dark. Pass 'Light', " +
        "'Dark' or 'Default'. Returns the previous and resulting variant. Disabled unless EnableInteraction was set.")]
    public static Task<string> SetTheme(
        [Description("Theme variant: Light | Dark | Default.")]
        string variant) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            if (Application.Current is not { } app)
                return "No Application is running.";

            ThemeVariant? target = variant?.Trim().ToLowerInvariant() switch
            {
                "light" => ThemeVariant.Light,
                "dark" => ThemeVariant.Dark,
                "default" => ThemeVariant.Default,
                _ => null
            };

            if (target is null)
                return $"Unknown theme variant '{variant}'. Use Light | Dark | Default.";

            var previous = app.RequestedThemeVariant;
            app.RequestedThemeVariant = target;
            Dispatcher.UIThread.RunJobs();

            return $"Theme requested={target}, actual now={app.ActualThemeVariant} (was requested={previous?.ToString() ?? "Default"}).";
        });

    [McpServerTool(Name = "click_at", Destructive = true), Description(
        "Acts on whatever control is at a pixel coordinate — useful for custom-drawn controls with no " +
        "Name or automation label. Screenshot pixels equal these window-client coordinates. It resolves " +
        "the control at the point and invokes/selects it (falling back to focus); it does NOT synthesize a " +
        "raw OS click, so it has no hover/drag. Pass x/y and an optional windowId. Disabled unless EnableInteraction was set.")]
    public static Task<string> ClickAt(
        [Description("X coordinate in window-client pixels/DIPs.")] double x,
        [Description("Y coordinate in window-client pixels/DIPs.")] double y,
        [Description("Optional window title or 0-based index. Omit for the main window.")]
        string? windowId = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            var top = AgentToolContext.ResolveTopLevel(windowId);
            if (top is null)
                return "No active window/top-level was found.";

            var point = new Point(x, y);
            if (HitTester.HitTest(top, point) is not { } hit)
                return $"Nothing is at ({x}, {y}).";

            var target = hit as Control ?? hit.FindAncestorOfType<Control>();
            if (target is null)
                return $"A non-control visual is at ({x}, {y}).";

            var identity = DescribeTarget(target);

            if (ResolveProvider<IInvokeProvider>(target) is { } invoke)
            {
                invoke.Invoke();
                return $"Invoked {identity} at ({x}, {y}).";
            }

            if (target is Button button)
            {
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                return $"Clicked {identity} at ({x}, {y}).";
            }

            if (ResolveProvider<ISelectionItemProvider>(target) is { } selection)
            {
                selection.Select();
                return $"Selected {identity} at ({x}, {y}).";
            }

            return target.Focus()
                ? $"No invokable control at ({x}, {y}); focused {identity} instead."
                : $"{identity} at ({x}, {y}) is neither invokable nor focusable.";
        });

    private static string DescribeTarget(Control control) =>
        control.Name is { Length: > 0 } name ? $"{control.GetType().Name} #{name}" : control.GetType().Name;

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

    /// <summary>
    /// Selects an item in the nearest <see cref="SelectingItemsControl"/> (self or ancestor) by its
    /// display text — covers ComboBox/ListBox/TabControl without opening the popup and hunting for the
    /// item container.
    /// </summary>
    private static string SelectItem(Control control, string name, string? value)
    {
        if (string.IsNullOrEmpty(value))
            return "Provide the item text in 'value' for 'select_item'.";

        var itemsControl = control as SelectingItemsControl
                           ?? control.GetVisualAncestors().OfType<SelectingItemsControl>().FirstOrDefault();
        if (itemsControl is null)
            return $"Control '{name}' ({control.GetType().Name}) is not (and is not inside) a selectable items control.";

        var index = 0;
        foreach (var item in itemsControl.Items)
        {
            if (ItemText(item) is { } text && text.Contains(value, StringComparison.OrdinalIgnoreCase))
            {
                itemsControl.SelectedIndex = index;
                return $"Selected item '{text}' (index {index}) in {itemsControl.GetType().Name}.";
            }

            index++;
        }

        return $"No item whose text contains '{value}' was found in {itemsControl.GetType().Name}.";
    }

    private static string? ItemText(object? item) =>
        item switch
        {
            null => null,
            string s => s,
            ContentControl { Content: string content } => content,
            HeaderedItemsControl { Header: string header } => header,
            _ => item.ToString()
        };

    /// <summary>
    /// Scrolls the nearest <see cref="ScrollViewer"/> (self, ancestor, or descendant) by a delta given
    /// as "dx,dy".
    /// </summary>
    private static string ScrollBy(Control control, string name, string? value)
    {
        var parts = (value ?? string.Empty).Split(',', StringSplitOptions.TrimEntries);
        if (parts.Length != 2 ||
            !double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var dx) ||
            !double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var dy))
        {
            return "Provide the scroll delta as 'dx,dy' in 'value' (e.g. '0,120').";
        }

        var scroll = FindScrollViewer(control);
        if (scroll is null)
            return $"No ScrollViewer found at or around '{name}' ({control.GetType().Name}).";

        scroll.Offset = new Vector(scroll.Offset.X + dx, scroll.Offset.Y + dy);
        return $"Scrolled by ({dx},{dy}); offset is now ({scroll.Offset.X:0.#},{scroll.Offset.Y:0.#}) " +
               $"of extent {scroll.Extent.Width:0.#}x{scroll.Extent.Height:0.#}.";
    }

    private static ScrollViewer? FindScrollViewer(Control control) =>
        control as ScrollViewer
        ?? control.GetVisualAncestors().OfType<ScrollViewer>().FirstOrDefault()
        ?? control.GetVisualDescendants().OfType<ScrollViewer>().FirstOrDefault();

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
