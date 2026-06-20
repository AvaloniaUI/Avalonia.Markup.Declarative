using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Markup.Declarative.Diagnostics;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace Declarative.Avalonia.AgentTools.Tools;

/// <summary>
/// Read-only MCP tools that let an agent inspect the running Avalonia app. Tools compose: get a tree
/// with names, then screenshot a specific control by name.
/// </summary>
[McpServerToolType]
public sealed class InspectionTools
{
    private InspectionTools() { }

    [McpServerTool(Name = "get_visual_tree", ReadOnly = true), Description(
        "Returns a text rendering of the live visual tree (type, #Name, layout bounds, key properties). " +
        "Bounds reveal layout problems (zero-size, off-screen, overlap) without pixels. " +
        "Pass rootName to dump a named subtree; omit it to dump the active window.")]
    public static Task<string> GetVisualTree(
        [Description("Optional Name of a control to use as the root. Omit for the active window.")]
        string? rootName = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            global::Avalonia.Visual? root = string.IsNullOrWhiteSpace(rootName)
                ? AgentToolContext.GetPrimaryTopLevel()
                : AgentToolContext.FindControl(rootName);

            if (root is null)
                return string.IsNullOrWhiteSpace(rootName)
                    ? "No active window/top-level was found."
                    : $"No control named '{rootName}' was found.";

            return VisualTreeInspector.DumpVisualTree(root);
        });

    [McpServerTool(Name = "list_components", ReadOnly = true), Description(
        "Lists the active declarative views (components) currently tracked in the running app: type, " +
        "Name, attachment state and bounds. Use a returned Name as input to other tools.")]
    public static Task<string> ListComponents() =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            var views = ComponentRegistry.GetActiveViews();
            if (views.Count == 0)
                return "No active components are tracked. (Components are tracked while hot reload is enabled, which is the default.)";

            var builder = new StringBuilder();
            foreach (var view in views)
            {
                builder
                    .Append(view.TypeName)
                    .Append(view.Name is null ? string.Empty : $" #{view.Name}")
                    .Append(view.IsAttached ? " [attached]" : " [detached]")
                    .Append(' ')
                    .Append(FormatBounds(view.Bounds))
                    .Append('\n');
            }

            return builder.ToString();
        });

    [McpServerTool(Name = "screenshot_window", ReadOnly = true), Description(
        "Captures a PNG screenshot of a window/top-level. Rendering re-draws the visual, so it works " +
        "even for a minimized or occluded window. Pass windowId (window title or 0-based index); omit " +
        "for the main window.")]
    public static Task<CallToolResult> ScreenshotWindow(
        [Description("Optional window title or 0-based index. Omit for the main window.")]
        string? windowId = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            try
            {
                var top = AgentToolContext.ResolveTopLevel(windowId);
                if (top is null)
                    return Error("No active window/top-level was found.");

                var png = ControlScreenshotService.CaptureTopLevelPng(top);
                var title = (top as Window)?.Title ?? top.GetType().Name;
                return Image(png, $"Window '{title}' {FormatBounds(top.Bounds)}");
            }
            catch (Exception ex)
            {
                return Error($"Failed to capture window: {ex.Message}");
            }
        });

    [McpServerTool(Name = "screenshot_control", ReadOnly = true), Description(
        "Captures a PNG screenshot of a single control identified by its Name. mode='isolated' renders " +
        "just the control's subtree; mode='in_context' renders the window and crops to the control.")]
    public static Task<CallToolResult> ScreenshotControl(
        [Description("The Name of the control to capture.")]
        string name,
        [Description("Capture mode: 'isolated' (default) or 'in_context'.")]
        string? mode = null) =>
        AgentToolContext.RunOnUiThreadAsync(() =>
        {
            try
            {
                var control = AgentToolContext.FindControl(name);
                if (control is null)
                    return Error($"No control named '{name}' was found. Use get_visual_tree to discover names.");

                var screenshotMode = string.Equals(mode, "in_context", StringComparison.OrdinalIgnoreCase)
                    ? ScreenshotMode.InContext
                    : ScreenshotMode.Isolated;

                var png = ControlScreenshotService.CaptureControlPng(control, screenshotMode);
                return Image(png, $"Control '{name}' ({control.GetType().Name}) {FormatBounds(control.Bounds)} mode={screenshotMode}");
            }
            catch (Exception ex)
            {
                return Error($"Failed to capture control '{name}': {ex.Message}");
            }
        });

    [McpServerTool(Name = "get_errors", ReadOnly = true), Description(
        "Returns recent build, binding and converter errors from the diagnostics buffer. Pass an ISO-8601 " +
        "sinceTimestamp to only get newer entries.")]
    public static string GetErrors(
        [Description("Optional ISO-8601 timestamp; only entries at/after it are returned.")]
        string? sinceTimestamp = null)
    {
        DateTimeOffset? since = null;
        if (!string.IsNullOrWhiteSpace(sinceTimestamp) &&
            DateTimeOffset.TryParse(sinceTimestamp, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var parsed))
        {
            since = parsed;
        }

        var entries = DiagnosticsErrorLog.GetEntries(since);
        if (entries.Count == 0)
            return "No diagnostics recorded.";

        return string.Join("\n", entries.Select(e => e.ToString()));
    }

    private static string FormatBounds(global::Avalonia.Rect b) =>
        string.Format(CultureInfo.InvariantCulture, "[x={0:0.#} y={1:0.#} w={2:0.#} h={3:0.#}]", b.X, b.Y, b.Width, b.Height);

    private static CallToolResult Image(byte[] png, string meta)
    {
        var result = new CallToolResult();
        result.Content.Add(new TextContentBlock { Text = meta });
        result.Content.Add(ImageContentBlock.FromBytes(png, "image/png"));
        return result;
    }

    private static CallToolResult Error(string message)
    {
        var result = new CallToolResult { IsError = true };
        result.Content.Add(new TextContentBlock { Text = message });
        return result;
    }
}
