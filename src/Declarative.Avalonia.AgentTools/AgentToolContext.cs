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
    /// Finds a control across every active top-level and tracked component root, first by its
    /// <c>Name</c> and then, as a fallback, by its UI Automation name (visible label, e.g. a tab
    /// header). The name pass is tried everywhere before the automation pass so an explicit
    /// <c>Name</c> always wins over a coincidental label match.
    /// </summary>
    public static Control? FindControl(string name)
    {
        if (string.IsNullOrEmpty(name))
            return null;

        foreach (var top in GetTopLevels())
        {
            if (ControlLocator.FindByName(top, name) is { } found)
                return found;
        }

        foreach (var component in ComponentRegistry.GetActiveViews())
        {
            if (ControlLocator.FindByName(component.RootControl, name) is { } found)
                return found;
        }

        foreach (var top in GetTopLevels())
        {
            if (ControlLocator.FindByAutomationName(top, name) is { } found)
                return found;
        }

        foreach (var component in ComponentRegistry.GetActiveViews())
        {
            if (ControlLocator.FindByAutomationName(component.RootControl, name) is { } found)
                return found;
        }

        return null;
    }

    /// <summary>
    /// Returns the element that currently has keyboard focus in the primary top-level, if any.
    /// </summary>
    public static IInputElement? GetFocusedElement() =>
        GetPrimaryTopLevel()?.FocusManager?.GetFocusedElement();
}
