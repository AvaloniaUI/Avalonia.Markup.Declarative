using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Describes an open popup (a dropdown, flyout, context menu, tooltip, ...) so tooling can see content
/// that lives outside the normal window tree.
/// </summary>
/// <param name="Popup">The <see cref="Popup"/> control that owns the content.</param>
/// <param name="ContentRoot">
/// The realized popup content subtree. This is the root to dump / search / screenshot, whether the
/// popup is hosted in a separate window (desktop) or an overlay layer (single-view).
/// </param>
/// <param name="SeparateTopLevel">
/// The popup's own <see cref="TopLevel"/> when it is hosted in a separate window (a <c>PopupRoot</c>);
/// <see langword="null"/> when it is an overlay inside the main window.
/// </param>
/// <param name="Owner">A short description of the control the popup belongs to (e.g. <c>ComboBox</c>).</param>
public sealed record PopupInfo(Popup Popup, Control ContentRoot, TopLevel? SeparateTopLevel, string Owner);

/// <summary>
/// Finds open popups. A popup's content is not part of the window's own visual tree — it is realized in
/// a separate <c>PopupRoot</c> (desktop) or an overlay layer (single-view). Without this, an agent that
/// opens a <c>ComboBox</c>/menu/flyout cannot see the content it just revealed.
/// </summary>
/// <remarks>Must be called on the UI thread; the caller is responsible for marshaling.</remarks>
public static class PopupLocator
{
    /// <summary>
    /// Returns every open popup discoverable from <paramref name="searchRoots"/> (the placeholder
    /// <see cref="Popup"/> nodes live in the normal tree even though their content does not).
    /// </summary>
    public static IReadOnlyList<PopupInfo> GetOpenPopups(IEnumerable<Visual> searchRoots)
    {
        ArgumentNullException.ThrowIfNull(searchRoots);

        var result = new List<PopupInfo>();
        var seen = new HashSet<Popup>();

        foreach (var root in searchRoots)
        {
            foreach (var descendant in root.GetSelfAndVisualDescendants())
            {
                if (descendant is not Popup { IsOpen: true } popup || !seen.Add(popup))
                    continue;

                if (popup.Child is not { } child)
                    continue;

                var popupTop = TopLevel.GetTopLevel(child);
                var ownerTop = TopLevel.GetTopLevel(popup);
                var separate = popupTop is not null && !ReferenceEquals(popupTop, ownerTop) ? popupTop : null;

                result.Add(new PopupInfo(popup, child, separate, DescribeOwner(popup)));
            }
        }

        return result;
    }

    private static string DescribeOwner(Popup popup)
    {
        var owner = popup.TemplatedParent ?? popup.Parent;
        return owner?.GetType().Name ?? "Popup";
    }

    /// <summary>
    /// If <paramref name="control"/> is (or wraps) a <b>closed</b> popup/flyout — which is why it has a
    /// zero size and cannot be screenshotted or acted on — returns a hint explaining that and how to
    /// open it; otherwise <see langword="null"/>. This turns a dead-end ("has a zero size") into a
    /// guided next step (P5).
    /// </summary>
    public static string? DescribeIfClosedPopup(Control control)
    {
        ArgumentNullException.ThrowIfNull(control);

        // Precise: only when the named target IS a closed Popup. A container that merely *contains* a
        // closed popup must not be mistaken for one, so we don't scan descendants — and a closed popup's
        // content isn't realized in the tree, so it isn't reachable by name in the first place.
        var popup = control as Popup;

        if (popup is { IsOpen: false })
        {
            var named = popup.Name is { Length: > 0 } n ? n : control.Name;
            var target = string.IsNullOrEmpty(named) ? "the popup" : $"'{named}'";
            return $"{target} is a CLOSED popup ({DescribeOwner(popup)}), so it has no size to capture. " +
                   $"Open it first: open_popup{{name:\"{named ?? control.Name}\"}} toggles its bound IsOpen; " +
                   "or drive whatever shows it (invoke_command on the toggling command, or click_at/tap the trigger).";
        }

        // A control that owns a not-yet-shown flyout (Button.Flyout / attached flyout).
        if (GetAttachedFlyout(control) is not null)
        {
            var named = control.Name is { Length: > 0 } n ? n : control.GetType().Name;
            return $"'{named}' has a flyout that is not shown, so its content is not realized. " +
                   $"Open it first: open_popup{{name:\"{named}\"}} shows the attached flyout.";
        }

        return null;
    }

    /// <summary>
    /// Opens the popup/flyout identified by <paramref name="name"/> across <paramref name="searchRoots"/>:
    /// a <see cref="Popup"/> whose <c>Name</c> matches (or one owned by / nested in the named control) has
    /// its <c>IsOpen</c> set true; a control with an attached flyout has it shown. Returns a human-readable
    /// result. Backs the <c>open_popup</c> tool (P5).
    /// </summary>
    public static string Open(IEnumerable<Visual> searchRoots, string name)
    {
        ArgumentNullException.ThrowIfNull(searchRoots);
        if (string.IsNullOrWhiteSpace(name))
            return "Provide the Name of the popup/flyout (or the control that owns it) to open.";

        var roots = searchRoots.ToList();

        // 1) A Popup directly named `name`.
        if (FindByName<Popup>(roots, name) is { } namedPopup)
            return SetOpen(namedPopup, name);

        // 2) A control named `name`: it may be a Popup, own an attached flyout, or contain a Popup.
        var owner = roots.SelectMany(r => r.GetSelfAndVisualDescendants())
            .OfType<Control>()
            .FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.Ordinal));

        if (owner is Popup ownerPopup)
            return SetOpen(ownerPopup, name);

        if (owner is not null)
        {
            if (GetAttachedFlyout(owner) is { } flyout)
            {
                flyout.ShowAt(owner);
                return $"Showed the flyout attached to '{name}'.";
            }

            if (owner.GetVisualDescendants().OfType<Popup>().FirstOrDefault() is { } childPopup)
                return SetOpen(childPopup, childPopup.Name is { Length: > 0 } n ? n : name);
        }

        return $"No popup or flyout named '{name}' was found. Name the Popup (or its owning control), or " +
               "use get_visual_tree to find the Popup node, then pass its Name.";
    }

    private static string SetOpen(Popup popup, string name)
    {
        if (popup.IsOpen)
            return $"'{name}' popup was already open.";
        popup.IsOpen = true;
        return $"Opened popup '{name}' (set IsOpen=true).";
    }

    private static T? FindByName<T>(IEnumerable<Visual> roots, string name) where T : Visual
    {
        foreach (var root in roots)
            foreach (var descendant in root.GetSelfAndVisualDescendants())
                if (descendant is T match && descendant is StyledElement { Name: { } n } && string.Equals(n, name, StringComparison.Ordinal))
                    return match;
        return null;
    }

    private static FlyoutBase? GetAttachedFlyout(Control control) =>
        (control as Button)?.Flyout
        ?? (control as SplitButton)?.Flyout
        ?? FlyoutBase.GetAttachedFlyout(control);
}
