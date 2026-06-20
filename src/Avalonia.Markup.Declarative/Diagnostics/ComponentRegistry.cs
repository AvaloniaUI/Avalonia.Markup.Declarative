using System.Collections.Generic;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Describes a live declarative view discovered through the component registry.
/// </summary>
/// <param name="TypeName">The runtime type name of the view.</param>
/// <param name="Name">The view control's <c>Name</c>, if any.</param>
/// <param name="RootControl">The view's root control (a <see cref="ViewBase"/> is itself a control).</param>
/// <param name="Bounds">The view's current layout bounds.</param>
/// <param name="IsAttached">Whether the view is currently attached to a visual root.</param>
public sealed record ComponentInfo(
    string TypeName,
    string? Name,
    Control RootControl,
    Rect Bounds,
    bool IsAttached);

/// <summary>
/// A thin wrapper over the live attached-instance registry maintained by <see cref="HotReloadManager"/>,
/// exposing the set of active declarative views.
/// </summary>
/// <remarks>
/// Tracking relies on hot-reload registration, which is active by default. If hot reload is disabled
/// (<see cref="HotReloadManager.Deactivate"/>) no instances are tracked and this returns an empty set.
/// </remarks>
public static class ComponentRegistry
{
    /// <summary>
    /// Returns the currently tracked declarative views.
    /// </summary>
    /// <remarks>Reads layout bounds, so call on the UI thread; the caller is responsible for marshaling.</remarks>
    public static IReadOnlyList<ComponentInfo> GetActiveViews()
    {
        var result = new List<ComponentInfo>();

        foreach (var instance in HotReloadManager.GetLiveInstances())
        {
            if (instance is not Control control)
                continue;

            var type = control.GetType();
            result.Add(new ComponentInfo(
                type.FullName ?? type.Name,
                string.IsNullOrEmpty(control.Name) ? null : control.Name,
                control,
                control.Bounds,
                TopLevel.GetTopLevel(control) is not null));
        }

        return result;
    }
}
