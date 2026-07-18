using System;
using Avalonia.Automation.Peers;
using Avalonia.Automation.Provider;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Classifies how a control can be driven by an agent, so the agent can choose the right tool up
/// front: UI-Automation invoke (<c>click_at method:"automation"</c> / <c>invoke</c>) versus synthetic
/// real pointer/keyboard input (<c>tap</c>/<c>drag</c>/<c>pointer_*</c>).
/// </summary>
/// <remarks>
/// Custom controls built from <c>Border</c>/<c>Panel</c> with hand-written
/// <c>PointerPressed</c>/<c>Moved</c>/<c>Released</c> handlers expose no automation pattern and are not
/// focusable — they are <see cref="RawPointerOnly"/> and can only be driven by synthesizing real input.
/// </remarks>
public readonly record struct DrivabilityInfo(
    bool AutomationInvokable,
    bool Focusable,
    string? AutomationPattern)
{
    /// <summary>True when the control exposes no automation action pattern and is not focusable, so it
    /// can only be driven with synthetic pointer input (<c>tap</c>/<c>drag</c>/<c>pointer_*</c>).</summary>
    public bool RawPointerOnly => !AutomationInvokable && !Focusable;

    /// <summary>A short, agent-facing recommendation of which tool to reach for.</summary>
    public string Recommendation =>
        AutomationInvokable
            ? "automation-invokable (click_at or invoke works; click_at tries real pointer first)"
            : Focusable
                ? "focusable but not automation-invokable (tap/click to focus+press; pointer_* for drag)"
                : "raw-pointer-only (no automation peer/pattern) — use tap/click/drag/pointer_* (synthetic real input)";
}

/// <summary>
/// Inspects a control and the controls above it to determine how it can be driven.
/// </summary>
public static class ControlDrivability
{
    /// <summary>
    /// Classifies <paramref name="control"/> (walking to the nearest actionable ancestor, the way a
    /// real click resolves) into automation-invokable / focusable / raw-pointer-only.
    /// </summary>
    public static DrivabilityInfo Classify(Control control)
    {
        ArgumentNullException.ThrowIfNull(control);

        if (ResolvePattern(control) is { } pattern)
            return new DrivabilityInfo(AutomationInvokable: true, Focusable: IsFocusable(control), pattern);

        // Typed fallbacks mirror the interaction tools: a label/pixel can land on an inner glyph whose
        // actionable ancestor is a Button/ToggleButton/TabItem without an exposed peer pattern.
        if (FindSelfOrAncestor<Button>(control) is not null)
            return new DrivabilityInfo(true, IsFocusable(control), "Invoke (Button)");
        if (FindSelfOrAncestor<ToggleButton>(control) is not null)
            return new DrivabilityInfo(true, IsFocusable(control), "Toggle (ToggleButton)");
        if (FindSelfOrAncestor<TabItem>(control) is not null)
            return new DrivabilityInfo(true, IsFocusable(control), "SelectionItem (TabItem)");

        return new DrivabilityInfo(AutomationInvokable: false, Focusable: IsFocusable(control), AutomationPattern: null);
    }

    private static bool IsFocusable(Control control)
    {
        Visual? current = control;
        while (current is Control c)
        {
            if (c is { Focusable: true, IsEffectivelyVisible: true } && c.IsEnabled)
                return true;
            current = c.GetVisualParent();
        }

        return false;
    }

    private static string? ResolvePattern(Control control)
    {
        Visual? current = control;
        while (current is Control owner)
        {
            var peer = TryCreatePeer(owner);
            if (peer is not null)
            {
                if (peer.GetProvider<IInvokeProvider>() is not null)
                    return "Invoke";
                if (peer.GetProvider<IToggleProvider>() is not null)
                    return "Toggle";
                if (peer.GetProvider<ISelectionItemProvider>() is not null)
                    return "SelectionItem";
            }

            current = owner.GetVisualParent();
        }

        return null;
    }

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

    private static T? FindSelfOrAncestor<T>(Control control) where T : Control
    {
        Visual? current = control;
        while (current is not null)
        {
            if (current is T match)
                return match;
            current = current.GetVisualParent();
        }

        return null;
    }
}
