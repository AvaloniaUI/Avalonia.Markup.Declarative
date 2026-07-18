# Declarative.Avalonia.AgentTools

In-process **MCP (Model Context Protocol) inspector** for AI agents that build UI with
[`Avalonia.Markup.Declarative`](https://www.nuget.org/packages/Avalonia.Markup.Declarative).

In a **debug** build it exposes the running app to an agent over **loopback** so the agent can close
the feedback loop while iterating on a view:

- `get_app_info` — windows, focus, popups, theme, versions, hot-reload/interaction state (call first)
- `get_visual_tree` — text visual tree with names, local bounds **and absolute `abs=`/`center=` client-DIP
  coords** (the frame `click_at`/`tap`/`drag`/`hit_test` share); `maxDepth`/`filter` to trim; open popups included
- `get_layout` — detailed layout for one control: bounds, window-relative position, requested vs actual
  size, alignment, margin/padding, visibility, off-screen/clipped flags, and the ancestor chain
- `get_properties` — effective state + every locally-set styled property
- `get_property_sources` — where each value came from (local / style / template / animation / inherited)
- `get_data_context` — the control's view-model rendered as text (debug bindings)
- `get_source` — the `ViewBase` component that built a control (which class to edit); optional `file:line`
- `find_text` / `hit_test` — locate controls by visible text or by pixel coordinate (`hit_test` also
  reports how the control can be driven: automation-invokable / focusable / raw-pointer-only)
- `layout_audit` — automated layout lint (zero-size, off-screen, overlap, out-of-parent, text-clipped)
- `list_components` — active declarative views
- `screenshot_window` (with `annotate`) / `screenshot_control` — PNG screenshots (image content blocks)
- `compare_screenshots` / `list_screenshots` — before/after pixel diff (red diff image + % changed)
- `highlight` — draw a frame around a control (or all of a type) and screenshot it; `action='clear'` clears
- `wait_for` / `wait_idle` — sync after an interaction or hot reload
- `get_errors` — recent build / binding / converter / runtime errors (incl. exceptions in handlers)
- `tap`, `drag`, `pointer_press`/`pointer_move`/`pointer_release` — *(optional, off by default)*
  **real** synthesized pointer input through Avalonia's input pipeline: works on custom controls with
  hand-written pointer handlers and **no automation peer** (scrub a Border slider, move a thumb, draw)
- `invoke`, `set_window_size`, `set_theme`, `click_at`, `open_popup`, `list_bindable`, `set_view_model`,
  `invoke_command` — *(optional, off by default)* remote control: invoke / select / select_item / toggle /
  set / expand / collapse / focus / scroll / scroll_by / context_menu / key / type (`key`/`type` send
  **real** input), plus resize, theme switch, pointer-first click-by-coordinate, open a closed popup, list
  a DataContext's bindable surface, and an escape hatch to set a view-model property or run an
  `ICommand`/method directly (structured, actionable errors; reach awkward states without restarting)

## Usage

```csharp
var appBuilder = AppBuilder.Configure<App>()
    .UsePlatformDetect()
#if DEBUG
    .UseAgentInspector() // loopback MCP server on 127.0.0.1:5599
#endif
    .SetupWithLifetime(lifetime);
```

## Enable the MCP in your agent

The server speaks streamable **HTTP** on loopback, so any MCP client points at the same endpoint —
`http://127.0.0.1:5599`. Run the app under `dotnet watch` so the agent's edits hot-reload into the
live process it is inspecting.

**Claude Code** — one command (or a project-scoped `.mcp.json`):

```bash
claude mcp add --transport http avalonia-agent-inspector http://127.0.0.1:5599
```

```json
// .mcp.json  (project root)
{
  "mcpServers": {
    "avalonia-agent-inspector": {
      "type": "http",
      "url": "http://127.0.0.1:5599"
    }
  }
}
```

**opencode** — add it under `mcp` in `opencode.json` with `type: "remote"`:

```json
// opencode.json
{
  "$schema": "https://opencode.ai/config.json",
  "mcp": {
    "avalonia-agent-inspector": {
      "type": "remote",
      "url": "http://127.0.0.1:5599",
      "enabled": true
    }
  }
}
```

**Codex** — add an `[mcp_servers.*]` table to `~/.codex/config.toml` (or the project's `.codex/config.toml`):

```toml
# ~/.codex/config.toml
[mcp_servers.avalonia-agent-inspector]
url = "http://127.0.0.1:5599"

# First time you use a streamable-HTTP MCP with Codex, enable the RMCP client once:
[features]
experimental_use_rmcp_client = true
```

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
