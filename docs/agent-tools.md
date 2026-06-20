# Agent Tools — in-process MCP inspector

`Declarative.Avalonia.AgentTools` lets an AI agent that is writing UI with
`Avalonia.Markup.Declarative` *see what it built*. In a debug build it runs an in-process
**MCP (Model Context Protocol) server** on loopback and exposes the live app to the agent:
screenshots of a window or a single control, a text visual tree annotated with bounds and names,
the list of active components, and recent build/binding errors.

The agent runs its own loop — change code → (hot reload) → screenshot / read the tree / read errors →
adjust — without a human relaying what the UI looks like.

## Why it is two packages

The MCP/web stack lives in a **separate** package on purpose:

- **`Avalonia.Markup.Declarative`** (core) gets only a thin, **dependency-free** diagnostics surface
  (namespace `Avalonia.Markup.Declarative.Diagnostics`): visual-tree dump, `RenderTargetBitmap`
  capture, the error ring buffer, the binding-error log sink, and name resolution. It relies solely
  on Avalonia, which the library already references. This surface is reusable by tests and any future
  headless harness.
- **`Declarative.Avalonia.AgentTools`** adds the MCP transport, tool registration, the
  `UseAgentInspector()` entry point, and the dependency on the MCP SDK.

NuGet dependencies are **not** conditional on build configuration: even under `#if DEBUG`, a package
dependency leaks to every consumer in Release, drags in the MCP/web stack, breaks trimming/AOT, and
looks bad to a security review. So the web stack must never live in core. AgentTools is an explicit,
dev-only opt-in. **Please don't "optimize" this boundary away by merging it back into core.**

## Enable it (debug only)

Reference the package and call `UseAgentInspector()` on your `AppBuilder`, wrapped in `#if DEBUG`:

```csharp
using Declarative.Avalonia.AgentTools; // under #if DEBUG

var appBuilder = AppBuilder.Configure<App>()
    .UsePlatformDetect()
    .AfterSetup(/* themes, dev tools, ... */)
#if DEBUG
    .UseAgentInspector() // loopback MCP server, default 127.0.0.1:5599
#endif
    .SetupWithLifetime(lifetime);
```

In the monorepo, the `AvaloniaMarkupSample` project references AgentTools only in the `Debug`
configuration, so a Release build never sees it:

```xml
<ItemGroup Condition="'$(Configuration)' == 'Debug'">
  <ProjectReference Include="..\..\Declarative.Avalonia.AgentTools\Declarative.Avalonia.AgentTools.csproj" />
</ItemGroup>
```

Options:

| Option | Default | Meaning |
| --- | --- | --- |
| `Port` | `5599` | Loopback TCP port for the MCP endpoint. |
| `EnableInteraction` | `false` | Registers the tier-2 `invoke` tool (remote control). |

```csharp
.UseAgentInspector(o =>
{
    o.Port = 5599;
    o.EnableInteraction = false; // keep off unless you really need it
})
```

On startup the server prints its URL to the debug console.

## Connect your agent

The server speaks streamable **HTTP** on loopback. Point your agent's MCP client at it. Example
`.mcp.json`:

```json
{
  "mcpServers": {
    "avalonia-agent-inspector": {
      "type": "http",
      "url": "http://127.0.0.1:5599"
    }
  }
}
```

Run the app under `dotnet watch` so the agent's code edits hot-reload into the live process it is
inspecting.

## Tools

| Tool | Args | Returns |
| --- | --- | --- |
| `get_visual_tree` | `rootName?` | Text tree: type, `#Name`, bounds, key props. Omit `rootName` for the active window. |
| `list_components` | — | Active declarative views: type, name, attachment, bounds. |
| `screenshot_window` | `windowId?` | PNG of a window (title or 0-based index; omit for main). |
| `screenshot_control` | `name`, `mode?` | PNG of one control. `mode` = `isolated` (default) or `in_context`. |
| `get_errors` | `sinceTimestamp?` | Recent build + binding + converter errors. |
| `invoke` ⚠️ | `name?`, `action`, `value?` | Tier-2 remote control via UI Automation — see [The `invoke` actions](#the-invoke-actions). Off unless `EnableInteraction`. |

The tools compose: `get_visual_tree` surfaces names → the agent picks one → `screenshot_control(name)`.
Identification is by `Name` (the existing `.Name(...)` extension) and, as a fallback, by a control's
**UI Automation name** — its visible label, e.g. a `TabItem`'s header or a `Button`'s text. So you can
act on controls you never named (`invoke "Exception sample" select`), though **naming the controls you
iterate on** stays the most reliable way to address them.

Images come back as image content blocks (base64 PNG) plus a short text block with metadata (control
name, type, bounds), so a multimodal agent sees the pixels.

## The `invoke` actions

`invoke(name?, action, value?)` is the single tier-2 remote-control tool. It is **off by default** and
only registered when `EnableInteraction = true`. Rather than hard-coding control types, it dispatches
through Avalonia's **UI Automation peers** — the same accessibility layer a screen reader drives — so
one tool drives any control. This works in a live desktop app and is platform-agnostic;
`Avalonia.Headless` input simulation is deliberately *not* used (it needs the headless platform and
cannot drive a real window).

| `action` | Automation pattern | Typical controls |
| --- | --- | --- |
| `invoke` | `IInvokeProvider.Invoke()` | Button, MenuItem, HyperlinkButton |
| `select` | `ISelectionItemProvider.Select()` | **TabItem**, ListBoxItem, RadioButton |
| `toggle` | `IToggleProvider.Toggle()` | CheckBox, ToggleButton |
| `set` | `IValueProvider`/`IRangeValueProvider.SetValue(value)` | TextBox (text), Slider/NumericUpDown (number) |
| `expand` / `collapse` | `IExpandCollapseProvider` | TreeViewItem, Expander, ComboBox |
| `focus` | `Control.Focus()` | any |
| `scroll` | `AutomationPeer.BringIntoView()` | any |
| `context_menu` | `AutomationPeer.ShowContextMenu()` | any (opens the context menu) |
| `key` | synthetic `KeyDown`/`KeyUp` (`value` is a gesture, e.g. `Enter`, `Ctrl+S`) | named control, or the focused element if `name` is omitted |
| `type` | synthetic `TextInput` (`value` is the text) | named control, or the focused element if `name` is omitted |

Two robustness rules make addressing forgiving:

- **Ancestor resolution.** Addressing by visible label often lands on an inner element (the `TextBlock`
  inside a `TreeViewItem`, or the text inside a `Button`). If the matched control does not expose the
  requested pattern, `invoke` walks up to the nearest visual ancestor that does — so `expand "Animals"`
  expands the tree node even though the label matched its inner `TextBlock`.
- **Typed fallbacks.** Where a peer does not implement a pattern, `invoke` falls back to the obvious
  property (`Button.Click`, `TabItem.IsSelected`, `ToggleButton.IsChecked`, `TextBox.Text`,
  `TreeViewItem`/`Expander.IsExpanded` — Avalonia's `TreeViewItem` has no expand/collapse peer).

> **Addressing text inputs.** A `Button`/`TabItem`/`ToggleButton` exposes its caption as its automation
> name, so it is addressable by its visible text. A `TextBox` does **not** — its automation name is
> empty — so `set`/`type`/`key` against a specific text box need it to carry a `Name`. Name the inputs
> you drive, or use `key`/`type` with `name` omitted to target whatever currently has focus.

Examples:

```
invoke "Exception sample" select          # switch to the tab labeled "Exception sample"
invoke "Save" invoke                      # click the Save button
invoke "Remember me" toggle               # flip a checkbox
invoke "userName" set "alice"             # set a TextBox value
invoke "Animals" expand                   # expand a TreeViewItem by its header
invoke "userName" key "Enter"             # press Enter on a control (submit a form)
invoke null type "hello"                  # type into whatever has focus
```

## Limitations & safety

- **Breakpoints freeze captures.** Tree traversal and `RenderTargetBitmap` run on the UI thread; each
  tool marshals work there with `Dispatcher.UIThread.InvokeAsync`. If you are paused on a breakpoint
  the UI thread is not pumping, so a capture blocks until you resume. For an autonomous agent loop
  that is expected behaviour.
- **Loopback only.** The server binds strictly to `127.0.0.1`. Screenshots can contain sensitive data
  — another reason it is loopback + debug-only.
- **`invoke` is off by default.** It is a remote-control surface — it can click, select, toggle, set
  values, expand/collapse, send keystrokes, and open context menus, i.e. change app state. It is
  registered only when you opt in with `EnableInteraction = true`, and like the rest of the inspector
  it is loopback + debug-only.
- **Component listing needs hot-reload tracking**, which is enabled by default. If you call
  `UseHotReload(false)`, `list_components` returns empty (tree/screenshot tools still work via the
  active windows).

## How errors are captured

- **Build errors** (`ViewBuildingException`, including the rich control/file/line message produced by
  the `_set`/binding setters) are recorded into a thread-safe ring buffer at their creation sites in
  core.
- **Binding & converter errors** are captured by a thin `ILogSink` decorator installed over Avalonia's
  `Logger.Sink`, filtered to `LogArea.Binding`/`LogArea.Property`. (Avalonia 11.1+ shipped a public
  `BindingDiagnostics`, but it is not part of the public surface in the targeted Avalonia version, so
  the documented log-sink fallback is used.) Automatic conversion failures from the declarative
  binding converter surface through the same pipeline.
