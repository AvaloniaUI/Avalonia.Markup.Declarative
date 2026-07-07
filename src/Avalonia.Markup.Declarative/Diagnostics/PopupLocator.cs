using System;
using System.Collections.Generic;
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
}
