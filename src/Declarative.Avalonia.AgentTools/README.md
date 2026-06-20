# Declarative.Avalonia.AgentTools

In-process **MCP (Model Context Protocol) inspector** for AI agents that build UI with
[`Avalonia.Markup.Declarative`](https://www.nuget.org/packages/Avalonia.Markup.Declarative).

In a **debug** build it exposes the running app to an agent over **loopback** so the agent can close
the feedback loop while iterating on a view:

- `get_visual_tree` — text visual tree with names and layout bounds
- `list_components` — active declarative views
- `screenshot_window` / `screenshot_control` — PNG screenshots (image content blocks)
- `get_errors` — recent build / binding / converter errors
- `invoke` — *(optional, off by default)* remote control via UI Automation:
  invoke / select / toggle / set / expand / collapse / focus / scroll / context_menu / key / type

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

> **Dev only.** Keep the call under `#if DEBUG`. This package pulls in the ASP.NET Core web stack and
> a remote-control surface; it must not ship in Release. The server binds to loopback only, and
> `invoke` stays disabled unless you set `EnableInteraction = true`.

See the repository's `docs/agent-tools.md` for the full guide.
