# Declarative.Avalonia.AgentTools

In-process **MCP (Model Context Protocol) inspector** for AI agents that build UI with
[`Avalonia.Markup.Declarative`](https://www.nuget.org/packages/Avalonia.Markup.Declarative).

In a **debug** build it exposes the running app to an agent over **loopback** so the agent can close
the feedback loop while iterating on a view:

- `get_app_info` — windows, focus, popups, theme, versions, hot-reload/interaction state (call first)
- `get_visual_tree` — text visual tree with names/bounds; `maxDepth`/`filter` to trim; open popups included
- `get_layout` — detailed layout for one control: bounds, window-relative position, requested vs actual
  size, alignment, margin/padding, visibility, off-screen/clipped flags, and the ancestor chain
- `get_properties` — effective state + every locally-set styled property
- `get_property_sources` — where each value came from (local / style / template / animation / inherited)
- `get_data_context` — the control's view-model rendered as text (debug bindings)
- `get_source` — the `ViewBase` component that built a control (which class to edit); optional `file:line`
- `find_text` / `hit_test` — locate controls by visible text or by pixel coordinate
- `layout_audit` — automated layout lint (zero-size, off-screen, overlap, out-of-parent, text-clipped)
- `list_components` — active declarative views
- `screenshot_window` (with `annotate`) / `screenshot_control` — PNG screenshots (image content blocks)
- `compare_screenshots` / `list_screenshots` — before/after pixel diff (red diff image + % changed)
- `highlight` — draw a frame around a control (or all of a type) and screenshot it; `action='clear'` clears
- `wait_for` / `wait_idle` — sync after an interaction or hot reload
- `get_errors` — recent build / binding / converter / runtime errors (incl. exceptions in handlers)
- `invoke`, `set_window_size`, `set_theme`, `click_at`, `set_view_model`, `invoke_command` —
  *(optional, off by default)* remote control: invoke / select / select_item / toggle / set / expand /
  collapse / focus / scroll / scroll_by / context_menu / key / type, plus resize, theme switch,
  click-by-coordinate, and an escape hatch to set a view-model property or run an `ICommand`/method
  directly (reach awkward states without restarting)

## Usage

```csharp
var appBuilder = AppBuilder.Configure<App>()
    .UsePlatformDetect()
#if DEBUG
    .UseAgentInspector() // loopback MCP server on 127.0.0.1:5599
#endif
    .SetupWithLifetime(lifetime);
```

Point your agent's MCP client at the streamable-HTTP endpoint `http://127.0.0.1:5599`.

Show a live "agent connected" status in your UI (like Chrome DevTools) by subscribing to
`AgentConnectionMonitor` — events are raised on the UI thread:

```csharp
#if DEBUG
AgentConnectionMonitor.StatusChanged += (_, e) =>
    window.Title = e.IsConnected ? "🟢 Agent connected — My App" : "My App";
#endif
```

> **Dev only.** Keep the call under `#if DEBUG`. This package pulls in the ASP.NET Core web stack and
> a remote-control surface; it must not ship in Release. The server binds to loopback only, and
> the tier-2 tools (`invoke`, `set_window_size`, `set_theme`, `click_at`, `set_view_model`,
> `invoke_command`) stay disabled unless you set `EnableInteraction = true`.

See the repository's `docs/agent-tools.md` for the full guide.
