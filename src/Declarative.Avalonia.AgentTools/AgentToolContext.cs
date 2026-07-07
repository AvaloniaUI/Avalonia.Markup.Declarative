using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Markup.Declarative.Diagnostics;
using Avalonia.Threading;

namespace Declarative.Avalonia.AgentTools;

/// <summary>
/// Shared state and helpers for the MCP tools: the active options, resolving top-levels/controls in
/// the running app, and marshaling work onto the Avalonia UI thread.
/// </summary>
internal static class AgentToolContext
{
    /// <summary>The options the inspector was started with.</summary>
    public static AgentInspectorOptions Options { get; set; } = new();

    /// <summary>
    /// Runs <paramref name="func"/> on the UI thread and returns its result.
    /// </summary>
    /// <remarks>
    /// MCP tool handlers run on a server (thread-pool) thread, while visual-tree traversal and
    /// <c>RenderTargetBitmap</c> must run on the UI thread. If the developer is paused on a
    /// breakpoint the UI thread is not pumping, so the call blocks until execution resumes — expected
    /// for an autonomous agent loop.
    /// </remarks>
    public static async Task<T> RunOnUiThreadAsync<T>(Func<T> func)
    {
        if (Dispatcher.UIThread.CheckAccess())
            return func();

        return await Dispatcher.UIThread.InvokeAsync(func);
    }

    /// <summary>
    /// Returns the active top-levels (desktop windows, or the single-view top-level).
    /// </summary>
    public static IReadOnlyList<TopLevel> GetTopLevels()
    {
        switch (Application.Current?.ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                return desktop.Windows.Cast<TopLevel>().ToArray();

            case ISingleViewApplicationLifetime { MainView: { } mainView } when TopLevel.GetTopLevel(mainView) is { } top:
                return new[] { top };

            default:
                return Array.Empty<TopLevel>();
        }
    }

    /// <summary>
    /// Returns the primary top-level: the desktop main window when available, otherwise the first one.
    /// </summary>
    public static TopLevel? GetPrimaryTopLevel()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime { MainWindow: { } main })
            return main;

        return GetTopLevels().FirstOrDefault();
    }

    /// <summary>
    /// Finds a top-level by an optional identifier (window title or 0-based index). Falls back to the
    /// primary top-level when <paramref name="windowId"/> is null/empty.
    /// </summary>
    public static TopLevel? ResolveTopLevel(string? windowId)
    {
        var topLevels = GetTopLevels();
        if (string.IsNullOrWhiteSpace(windowId))
            return GetPrimaryTopLevel();

        if (int.TryParse(windowId, out var index) && index >= 0 && index < topLevels.Count)
            return topLevels[index];

        return topLevels.FirstOrDefault(t => t is Window w && string.Equals(w.Title, windowId, StringComparison.OrdinalIgnoreCase))
               ?? GetPrimaryTopLevel();
    }

    /// <summary>
    /// The roots that always exist in the normal tree: active top-levels and tracked component roots.
    /// </summary>
    private static List<Visual> GetBaseRoots()
    {
        var roots = new List<Visual>();
        roots.AddRange(GetTopLevels());
        foreach (var component in ComponentRegistry.GetActiveViews())
            roots.Add(component.RootControl);
        return roots;
    }

    /// <summary>
    /// Returns open popups (dropdowns, flyouts, menus) discoverable from the base roots.
    /// </summary>
    public static IReadOnlyList<PopupInfo> GetOpenPopups() =>
        PopupLocator.GetOpenPopups(GetBaseRoots());

    /// <summary>
    /// All roots that should be searched for controls: the base roots plus the content of open popups
    /// (whose content lives outside the window tree). This is what makes controls inside a live
    /// dropdown/menu addressable.
    /// </summary>
    private static List<Visual> GetSearchRoots()
    {
        var roots = GetBaseRoots();
        foreach (var popup in GetOpenPopups())
            roots.Add(popup.ContentRoot);
        return roots;
    }

    /// <summary>
    /// Finds a control across every active top-level, tracked component root and open popup, first by
    /// its <c>Name</c> and then, as a fallback, by its UI Automation name (visible label, e.g. a tab
    /// header). The name pass is tried everywhere before the automation pass so an explicit
    /// <c>Name</c> always wins over a coincidental label match.
    /// </summary>
    public static Control? FindControl(string name)
    {
        if (string.IsNullOrEmpty(name))
            return null;

        var roots = GetSearchRoots();

        foreach (var root in roots)
            if (ControlLocator.FindByName(root, name) is { } found)
                return found;

        foreach (var root in roots)
            if (ControlLocator.FindByAutomationName(root, name) is { } found)
                return found;

        return null;
    }

    /// <summary>
    /// Resolves a selector to one or more controls. A selector is matched, in order, as: a control
    /// <c>Name</c> or UI Automation name (via <see cref="FindControl"/>, returning a single control),
    /// or — failing that — a type name (returning every control of that type across the app).
    /// </summary>
    public static IReadOnlyList<Control> FindControls(string selector)
    {
        if (string.IsNullOrWhiteSpace(selector))
            return Array.Empty<Control>();

        if (FindControl(selector) is { } single)
            return new[] { single };

        var results = new List<Control>();
        var seen = new HashSet<Control>();

        foreach (var root in GetSearchRoots())
            AddMatches(ControlLocator.FindAllByType(root, selector), results, seen);

        return results;
    }

    private static void AddMatches(IReadOnlyList<Control> found, List<Control> results, HashSet<Control> seen)
    {
        foreach (var control in found)
            if (seen.Add(control))
                results.Add(control);
    }

    /// <summary>
    /// Finds every control whose visible text contains <paramref name="text"/>, across all active
    /// top-levels and tracked components.
    /// </summary>
    public static IReadOnlyList<Control> FindByText(string text)
    {
        var results = new List<Control>();
        var seen = new HashSet<Control>();

        foreach (var root in GetSearchRoots())
            AddMatches(ControlLocator.FindAllByText(root, text), results, seen);

        return results;
    }

    /// <summary>
    /// Returns the element that currently has keyboard focus in the primary top-level, if any.
    /// </summary>
    public static IInputElement? GetFocusedElement() =>
        GetPrimaryTopLevel()?.FocusManager?.GetFocusedElement();
}
