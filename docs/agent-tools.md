# Agent Tools — in-process MCP inspector

`Declarative.Avalonia.AgentTools` lets an AI agent that is writing UI with
`Avalonia.Markup.Declarative` *see what it built*. In a debug build it runs an in-process
**MCP (Model Context Protocol) server** on loopback and exposes the live app to the agent:
screenshots of a window or a single control (with before/after pixel-diffing), a text visual tree
annotated with bounds and names, a detailed per-control layout report, an automated layout audit,
property / property-source / view-model inspection, pixel↔control hit-testing, a highlight overlay that
frames where a control actually landed, the list of active components, and recent build/binding/runtime
errors — plus an opt-in tier for driving the app (clicking, typing, resizing, theming, and setting
view-model state directly). The app can also show a live "agent connected" status.

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
| `EnableInteraction` | `false` | Registers the tier-2 tools (`tap`, `drag`, `pointer_press`/`pointer_move`/`pointer_release`, `invoke`, `set_window_size`, `set_theme`, `click_at`, `open_popup`, `list_bindable`, `set_view_model`, `invoke_command`). |
| `EnableSourceTagging` | `false` | Stamps each `.Name(...)`ed control with its `file:line` so `get_source` can point at the exact line. |

```csharp
.UseAgentInspector(o =>
{
    o.Port = 5599;
    o.EnableInteraction = false; // keep off unless you really need it
})
```

On startup the server prints its URL to the debug console.

## Connect your agent

The server speaks streamable **HTTP** on loopback, so every MCP client points at the same endpoint —
`http://127.0.0.1:5599`. Below are the three most common coding agents; any other MCP client takes the
same URL. Run the app under `dotnet watch` so the agent's code edits hot-reload into the live process it
is inspecting.

### Claude Code

Register it with one command, or commit a project-scoped `.mcp.json` so everyone on the repo gets it:

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

### opencode

Add it under the `mcp` key of `opencode.json` (global at `~/.config/opencode/opencode.json`, or
per-project). Remote (HTTP/SSE) servers use `type: "remote"`:

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

### Codex

Add an `[mcp_servers.*]` table to `~/.codex/config.toml` (or a project-local `.codex/config.toml`). A
`url` (instead of a `command`) makes it a streamable-HTTP server:

```toml
# ~/.codex/config.toml
[mcp_servers.avalonia-agent-inspector]
url = "http://127.0.0.1:5599"

# The first time you wire up a streamable-HTTP MCP, Codex needs its RMCP client enabled once:
[features]
experimental_use_rmcp_client = true
```

> The endpoint is loopback + debug-only, so no auth token is needed — leave the `headers` /
> `bearer_token_env_var` fields off.

## Show the connection status in your app

Like Chrome's "DevTools is connected" indicator, your app can surface when an agent is driving it —
handy so you (or a screenshot) can tell live activity from a static UI. Subscribe to
`AgentConnectionMonitor` and update any UI you like (the sample puts it in the window title):

```csharp
#if DEBUG
AgentConnectionMonitor.StatusChanged += (_, e) =>
    window.Title = e.IsConnected ? "🟢 Agent connected — My App" : "My App";
#endif
```

Events (`Connected`, `Disconnected`, `StatusChanged`) are raised on the **UI thread**, so handlers may
touch the UI directly. Because the MCP endpoint is stateless HTTP, "connected" is **activity-based**: the
monitor flips to connected on the first request and back to disconnected after `IdleTimeout` (default
10 s, settable) with no further requests — i.e. it tracks "an agent is actively using the tools", which
is the useful signal for an indicator. `RequestCount` and `LastActivity` are also exposed.

## Tools

**Orient & inspect** (read-only):

| Tool | Args | Returns |
| --- | --- | --- |
| `get_app_info` | — | Windows, focused element, open popups, theme, Avalonia version, hot-reload/interaction state. Call this first. |
| `get_visual_tree` | `rootName?`, `maxDepth?`, `filter?` | Text tree: type, `#Name`, local bounds **plus `abs=[…]`/`center=(x,y)` absolute client-DIP coords** (the frame `click_at`/`tap`/`drag`/`hit_test` share), key props (incl. non-default alignment/margin). `filter` prunes to matching subtrees; open popups are appended. |
| `get_layout` | `selector` | Detailed layout for one control — see [`get_layout`](#get_layout). |
| `get_properties` | `selector`, `properties?` | Effective state, DataContext type, classes, and every locally-set styled property. |
| `get_property_sources` | `selector`, `property?` | Where a property value comes from — local/style/template/animation/inherited — see [`get_property_sources`](#get_property_sources). |
| `get_data_context` | `selector`, `depth?` | The control's view-model rendered as text (property names + values) — see [`get_data_context`](#get_data_context). |
| `get_source` | `selector` | The `ViewBase` component (and nesting) that built the control — see [`get_source`](#get_source). |
| `find_text` | `text` | Controls whose visible text contains `text` (reverse of reading a label off a screenshot). |
| `hit_test` | `x`, `y`, `windowId?` | The control chain at a pixel **plus how the topmost control can be driven** (automation-invokable / focusable / raw-pointer-only) — see [`hit_test`](#hit_test). |
| `list_components` | — | Active declarative views: type, name, attachment, bounds. |
| `list_bindable` | `name?` | Settable properties, `ICommand`s + invokable methods, and nested sub-objects of a `DataContext` — discover the right path for `set_view_model`/`invoke_command` (P3). |

**Verify** (read-only):

| Tool | Args | Returns |
| --- | --- | --- |
| `layout_audit` | `rootName?` | Automated layout lint — see [`layout_audit`](#layout_audit). |
| `screenshot_window` | `windowId?`, `annotate?`, `filter?` | PNG of a window; `annotate=true` frames and labels every named control. |
| `screenshot_control` | `name`, `mode?` | PNG of one control. `mode` = `isolated` (default) or `in_context`. |
| `highlight` | `selector?`, `action?`, `color?` | Draws a frame around the match(es) and returns an in-context screenshot — see [`highlight`](#highlight). |
| `compare_screenshots` | `idA?`, `idB?` | Pixel-diffs two captures (red diff image + % changed + region) — see [`compare_screenshots`](#compare_screenshots). |
| `list_screenshots` | — | Lists recent screenshot ids/labels/sizes for `compare_screenshots`. |
| `wait_for` | `selector`, `condition`, `timeoutMs?` | Waits for a condition — see [`wait_for` and `wait_idle`](#wait_for-and-wait_idle). |
| `wait_idle` | — | Waits until the UI thread has drained (layout/binding/render). |
| `get_errors` | `sinceTimestamp?` | Recent build + binding + converter + **runtime** errors (incl. exceptions in event handlers). |

**Act** (tier-2, off unless `EnableInteraction`):

| Tool | Args | Returns |
| --- | --- | --- |
| `tap` ⚠️ | `x`, `y`, `button?`, `modifiers?`, `windowId?` | **Real** synthesized click (move→press→release) at an absolute client-DIP point — drives any control, peer or not — see [Real input synthesis](#real-input-synthesis-p1). |
| `drag` ⚠️ | `x1`, `y1`, `x2`, `y2`, `button?`, `steps?`, `holdMs?`, `modifiers?`, `windowId?` | **Real** press-drag-release (scrub a custom slider, move a thumb, draw). |
| `pointer_press` / `pointer_move` / `pointer_release` ⚠️ | `x`, `y`, `button?`/`modifiers?`, `windowId?` | **Real** low-level pointer steps; press begins a gesture whose capture is held across the calls. |
| `invoke` ⚠️ | `name?`, `action`, `value?` | Remote control via UI Automation (`key`/`type` now send **real** input) — see [The `invoke` actions](#the-invoke-actions). |
| `set_window_size` ⚠️ | `width`, `height`, `windowId?` | Resizes a window to test responsive layout; returns resulting + previous client size. |
| `set_theme` ⚠️ | `variant` | Switches theme (`Light`/`Dark`/`Default`) to verify both. |
| `click_at` ⚠️ | `x`, `y`, `windowId?`, `method?` | Clicks the control at a pixel; **real pointer first**, automation fallback — see [`click_at`](#click_at). |
| `open_popup` ⚠️ | `name` | Opens a closed Popup/Flyout (sets its bound `IsOpen`, or shows an attached flyout) — see [Popups](#closed-popups-open_popup-p5). |
| `set_view_model` ⚠️ | `name?`, `path`, `value?` | Sets a view-model property directly (escape hatch) — see [`set_view_model` and `invoke_command`](#set_view_model-and-invoke_command). |
| `invoke_command` ⚠️ | `name?`, `path`, `parameter?` | Executes an `ICommand`/method on the view-model directly — see [`set_view_model` and `invoke_command`](#set_view_model-and-invoke_command). |

The tools compose: `get_app_info` to orient → `get_visual_tree` surfaces names → the agent picks one →
`get_layout`/`get_properties`/`screenshot_control`/`highlight` → change code → `wait_idle` →
`layout_audit`/`get_errors` to verify.

Images come back as image content blocks (base64 PNG) plus a short text block with metadata (control
name, type, bounds), so a multimodal agent sees the pixels.

## Selectors

The inspection tools take a **selector**, resolved in this order:

1. a control **`Name`** (the `.Name(...)` extension),
2. its **UI Automation name** — the visible label (a `TabItem`'s header, a `Button`'s text),
3. a **type name** — `Button` (simple name) or a full name; this can match **several** controls.

Name/label always win over type, so `get_layout Button` reports the type match only when nothing is
named/labeled `Button`. When a selector matches many controls, `get_layout` reports the first and lists
the rest; `highlight` frames them all. Selectors reach into **open popups** too (dropdowns, menus,
flyouts), whose content lives outside the window tree.

## `get_layout`

`get_layout(selector)` returns a focused, text layout report for one control — the "why is it here / this
size / off-screen" companion to the visual tree. It reports:

- **Bounds** (relative to the parent) and **Window-rel** (relative to the top-level) — the latter is where
  it *actually* landed on screen;
- **DesiredSize** and **Requested** `Width`/`Height`/`Min`/`Max` (`Auto` = unset, `∞` = unbounded) — the
  size it asked for vs the size it got;
- **Alignment** (`Horizontal`/`Vertical`, plus content alignment for `ContentControl`s), **Margin** and
  **Padding**;
- **Visibility**: `IsVisible`, `IsEffectivelyVisible`, `IsEnabled`, `Opacity`, `ZIndex`;
- **Flags** that summarise trouble: `zero-size`, `off-screen`, `partially-clipped`, `hidden`,
  `hidden-by-ancestor`;
- the **ancestor chain** (root → control), each with its type, name, bounds and (for panels) orientation,
  so you can see which container arranged it.

```
get_layout Go
```
```
Button #Go
  Bounds:       [x=8 y=34 w=48 h=32]  (relative to parent)
  Window-rel:   [x=8 y=34 w=48 h=32]  (relative to Window 'Main')
  DesiredSize:  48 x 32
  Requested:    Width=Auto Height=Auto  Min=(0,0) Max=(∞,∞)
  Alignment:    Horizontal=Left Vertical=Center
  Margin:       0,0,0,0
  Visibility:   IsVisible=True IsEffectivelyVisible=True IsEnabled=True Opacity=1 ZIndex=0
  Ancestors (root → control):
    Window #Main [x=0 y=0 w=400 h=300]
      StackPanel [x=0 y=0 w=400 h=300] Orientation=Vertical
        Button #Go [x=8 y=34 w=48 h=32]
```

The compact `get_visual_tree` now also shows non-default `HAlign`/`VAlign`/`Margin` per node, so common
placement problems are visible in the overview before you drill in with `get_layout`.

## `layout_audit`

`layout_audit(rootName?)` sweeps the authored controls (it walks the *logical* tree, so no templated
internals) and reports common layout problems, ordered errors-first. It is the fast way to **verify a
layout change** without eyeballing a screenshot. Kinds:

- `zero-size` — a control that asked for space (non-zero `DesiredSize`) but was arranged to zero;
- `off-screen` / `partially-clipped` — outside / past the window's client area;
- `out-of-parent` — overflows a `StackPanel`/`DockPanel`/`Grid`/`WrapPanel` container;
- `overlap` — visible siblings colliding in a `StackPanel`/`DockPanel`/`WrapPanel` (Grid/Canvas layering
  is treated as intentional and skipped);
- `text-clipped` — a `TextBlock`/`TextBox` whose desired size exceeds the space it got.

Geometric checks skip content inside a `ScrollViewer` (legitimately scrolled out). An empty result reads
"No layout anomalies found."

## `get_data_context`

`get_data_context(selector, depth?)` renders a control's `DataContext` (view-model) as text — the
property names and current values a binding could target — so you can debug bindings without a debugger.
It is cycle-safe, summarizes collections (`Count` + a short preview), notes `INotifyPropertyChanged`, and
reports a throwing getter inline. `depth` (1–3, default 1) expands nested objects.

## `get_source`

`get_source(selector)` maps a live control back to the declarative **component** (`ViewBase` subclass)
that built it — by full type name and assembly — plus any enclosing components. Since you edit code, this
is the key hop: it ends with `search the codebase for 'class <Name>'`.

With **`EnableSourceTagging`** turned on (see options), `get_source` also reports `Declared at: file:line`
— the exact line where the control was named — so you can jump straight there. Tagging is off by default
because it stamps the caller's location onto every `.Name(...)`ed control at build time.

## `get_property_sources`

`get_property_sources(selector, property?)` reports the **binding priority** each value came from —
`LocalValue`, `Style`, `StyleTrigger`, `Template`, `Animation`, `Inherited` — using Avalonia's public
property-diagnostic API. Reach for it when a value isn't what you set and you suspect a style or template
is winning. Pass a single `property` (e.g. `Background`) or omit it to list every set property with its
source.

## Coordinate frame

There is **one** coordinate frame across every tool: **absolute client-DIP coordinates of the
top-level** — the client-area origin is `(0,0)` and, because screenshots render at **96 DPI**, one unit
equals one screenshot pixel. `get_visual_tree` reports each node's `abs=[x y w h]` and `center=(x,y)` in
this frame (the leading `[x y w h]` stays parent-relative, for layout debugging); `hit_test` reports it;
and `click_at`/`tap`/`drag`/`pointer_*` **consume** it. So the round-trip holds: take a node's
`center=(x,y)` from `get_visual_tree`, pass it to `click_at`/`tap`, and it lands on that node
(verifiable with `hit_test`).

The absolute bounds are computed with `Visual.TransformToVisual`, so they account for render transforms,
a `LayoutTransformControl`'s UI-scale, and scroll offsets. Popup content that lives in its own visual
root (a `PopupRoot`) is reported relative to **its own** top-level; target it with that window's
`windowId`.

## `hit_test`

`hit_test(x, y, windowId?)` is the reverse of a screenshot: it reports the control chain at a pixel
(topmost → root) in the [absolute client-DIP frame](#coordinate-frame), then a **`Drive:`** line saying
how the topmost control can be driven:

- **automation-invokable** — `click_at` or `invoke` works (a Button/menu/selectable/toggle);
- **focusable but not automation-invokable** — `tap`/`click` to focus+press, `pointer_*` to drag;
- **raw-pointer-only** — no automation peer/pattern (a custom `Border`/`Panel` with hand-written pointer
  handlers); use `tap`/`drag`/`pointer_*` (synthetic real input).

It is a geometric, transform-aware point-in-bounds test (no running compositor required), consistent with
the frame `get_visual_tree` reports.

## `wait_for` and `wait_idle`

`wait_for(selector, condition, timeoutMs?)` polls until a control reaches a condition, so you don't
busy-loop `get_visual_tree` after an `invoke` or hot reload. Conditions: `exists`, `gone`, `visible`,
`hidden`, `enabled`, `bounds-stable` (unchanged ~300 ms — good after animations). Default timeout 5000 ms
(max 30000). `wait_idle()` returns once the UI thread has drained its queued work (layout, binding,
render) — call it after a hot reload or an interaction before you screenshot or read the tree.

## `highlight`

`highlight(selector?, action?, color?)` draws a frame around the matched control(s) in the live app and
returns an **in-context screenshot** showing the frame, so you can see exactly where an element ended up
(and whether it overlaps or sits off-screen). The frame is an **overlay** rendered in the control's
adorner layer — it does not affect layout, input or app state.

- Frames **persist** until you clear them, so later `screenshot_*` calls also show them.
- Pass `action='clear'` to remove all frames.
- `color` is optional (e.g. `#00A0FF` or `Lime`); highlight different elements in different colors to
  compare them in one shot.

```
highlight Go                 # frame the Go button, return a screenshot showing it
highlight Button color Lime  # frame every Button in lime
highlight null clear         # remove all frames
```

`highlight` is always available (it is a diagnostic overlay, not remote control), but unlike the pure
read-only tools it does add a transient visual to the tree; `action='clear'` reverses it.

## `compare_screenshots`

Every `screenshot_window`/`screenshot_control` capture is kept (last 10, raw pixels) and reported with an
`id=sN`. `compare_screenshots(idA?, idB?)` pixel-diffs two of them and returns a **diff image** (changed
pixels in red on a dimmed background) plus stats: percent of pixels changed and the changed-region
bounding box. Omit both ids to compare the **two most recent** — the common before/after flow:

```
screenshot_window            # → id=s1  (before)
# … change code, hot reload, wait_idle …
screenshot_window            # → id=s2  (after)
compare_screenshots          # diff s1 → s2
```

A per-channel tolerance suppresses anti-aliasing noise. If the two captures differ in size (the layout
resized), it says so instead of a meaningless diff. Use `list_screenshots` to see stored ids.

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
| `select_item` | sets `SelectedIndex` by item text (`value`) | ComboBox, ListBox, TabControl (no need to open the popup) |
| `toggle` | `IToggleProvider.Toggle()` | CheckBox, ToggleButton |
| `set` | `IValueProvider`/`IRangeValueProvider.SetValue(value)` | TextBox (text), Slider/NumericUpDown (number) |
| `expand` / `collapse` | `IExpandCollapseProvider` | TreeViewItem, Expander, ComboBox |
| `focus` | `Control.Focus()` | any |
| `scroll` | `AutomationPeer.BringIntoView()` | any |
| `scroll_by` | nearest `ScrollViewer.Offset += dx,dy` (`value` = `"dx,dy"`) | any inside/around a ScrollViewer |
| `context_menu` | `AutomationPeer.ShowContextMenu()` | any (opens the context menu) |
| `key` | **real** `KeyDown`/`KeyUp` through the input pipeline (`value` is a gesture, e.g. `Enter`, `Ctrl+S`) | named control (focused first), or the focused element if `name` is omitted |
| `type` | **real** `TextInput` through the input pipeline (`value` is the text) | named control (focused first), or the focused element if `name` is omitted |

Three robustness rules make addressing forgiving:

- **Ancestor resolution.** Addressing by visible label often lands on an inner element (the `TextBlock`
  inside a `TreeViewItem`, or the text inside a `Button`). If the matched control does not expose the
  requested pattern, `invoke` walks up to the nearest visual ancestor that does — so `expand "Animals"`
  expands the tree node even though the label matched its inner `TextBlock`.
- **Typed fallbacks (that also climb).** Where a peer does not implement a pattern, `invoke` falls back to
  the obvious property on the nearest matching ancestor: `Button.Click`, `TabItem.IsSelected`,
  `ToggleButton.IsChecked`, `TextBox.Text`, `TreeViewItem`/`Expander.IsExpanded` (Avalonia's `TreeViewItem`
  has no expand/collapse peer). The climb matters — hitting a `Button` by its label lands on the inner
  `AccessText`, which is not itself a `Button`, so a leaf-only fallback would no-op.
- **Text fallback.** If neither a `Name` nor an automation name matches, `invoke` resolves the target the
  same way `find_text` does (visible `TextBlock`/`Content`/`Header` text) and then climbs to the actionable
  control — so a button whose caption `find_text` can see is invokable by that caption even when its
  automation name is not exposed.

When the control that actually received the action differs from what you addressed, the result says so
(`Clicked Button #Save (resolved from 'Save')`), so a "poked the label, nothing happened" no-op can't pass
as success. Any failure comes back as a plain message naming the action — an exception is never surfaced as
the MCP SDK's opaque `An error occurred invoking 'invoke'`. Omitting `name` for `key`/`type` with nothing
focused returns an explicit hint to pass `name` or focus a control first, rather than an error.

`key`/`type` now synthesize **real** keyboard/text input through Avalonia's input pipeline (see
[Real input synthesis](#real-input-synthesis-p1)) rather than raising a routed event on the target, so
`Escape`/`Enter` reach a focused `TextBox` and trigger its own key handling exactly as a physical key
would. The addressed control is focused first; if synthetic input is unavailable the tool falls back to
the previous routed-event behavior.

## Real input synthesis (P1)

`tap`, `drag`, `pointer_press`/`pointer_move`/`pointer_release` (and `click_at` by default) synthesize
**real** pointer input: they feed `RawPointerEventArgs` into the top-level's platform input sink
(`ITopLevelImpl.Input`), which hit-tests the point and dispatches through `InputManager`. Hit-testing,
**pointer capture**, and the routed `PointerPressed`/`PointerMoved`/`PointerReleased` events fire exactly
as they would from a mouse — so these drive controls that expose **no automation peer**: a custom
`Border`/`Panel` "slider" with hand-written pointer handlers, a drag thumb, a drawing canvas. This is the
universal complement to `invoke`/`click_at(automation)`, which only work where a control implements an
automation pattern.

- Coordinates are [absolute client-DIP](#coordinate-frame); take them from `get_visual_tree` `center=` or
  `hit_test`.
- `drag(x1,y1,x2,y2, button?, steps?, holdMs?, modifiers?)` presses at the start, moves in `steps`
  intermediate steps **with the button held** (so scrub/drag handlers see `IsLeftButtonPressed`), then
  releases — the way to move a slider value or a thumb.
- `pointer_press` begins a gesture and `pointer_move`/`pointer_release` continue it; the same synthetic
  pointer (and its capture) is reused across the calls, so a multi-step drag stays coherent.
- It is **not** `Avalonia.Headless` input simulation — `ITopLevelImpl.Input` is wired by every real
  windowing backend, so this drives a live desktop window too. (Internally the raw-event constructors are
  reached by reflection because they are hidden in the NuGet reference assembly though public at runtime.)

```
tap 128 96                       # real click at an absolute point
drag 40 300 210 300              # scrub a custom slider left→right
pointer_press 40 300 ; pointer_move 210 300 ; pointer_release 210 300
```

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
invoke "themeCombo" select_item "Dark"    # choose a ComboBox item by its text
invoke "log" scroll_by "0,300"            # scroll a ScrollViewer down by 300
```

## `set_window_size` and `set_theme`

These tier-2 tools drive whole-app verification loops:

- `set_window_size(width, height, windowId?)` resizes a desktop window so you can screenshot at
  breakpoints; it returns the resulting client size (which the window's Min/Max may clamp) and the
  previous size so you can restore it.
- `set_theme(variant)` sets `Application.RequestedThemeVariant` to `Light`/`Dark`/`Default` and returns
  the resulting `ActualThemeVariant`, so you can screenshot both themes.

## `click_at`

`click_at(x, y, windowId?, method?)` clicks whatever control sits at a pixel — useful for **custom-drawn
controls that carry no `Name` or automation label**. Coordinates are [absolute client-DIP](#coordinate-frame).

By default (`method='auto'`) it synthesizes a **real pointer click first** (see
[Real input synthesis](#real-input-synthesis-p1)), which works universally — including controls that only
handle raw `PointerPressed` with no automation pattern. Only when synthetic input is unavailable does it
fall back to the UI-Automation path, which **climbs to the nearest actionable control** (invoke → click a
`Button` → select an item/`TabItem` → toggle → focus) and reports what it resolved to
(`Clicked Button #Save (resolved from AccessText)`).

- `method='pointer'` forces the real-pointer path.
- `method='automation'` forces the peer path (the old behavior: no hover/drag, raw-pointer-only controls
  are only focused).

For hover or drag use `pointer_move` / `drag`. For controls you can name, `invoke` is still fine.

## `set_view_model` and `invoke_command`

Some states are expensive or awkward to reach by driving the UI — the recovery banner after an unclean
shutdown, an error flag, a "loading" spinner, a screen that only appears once a command has run. Killing
and restarting the process to reproduce them is slow and lossy. These two tier-2 tools are the **escape
hatch**: they reach past the view and act on the **view-model** directly.

- `set_view_model(name?, path, value?)` sets a property on a `DataContext` by a dotted `path`
  (`IsBusy`, `CurrentUser.Name`). `value` is text, converted to the property's type (bool/number/enum/
  string/`Guid`/`DateTime`/`TimeSpan`/`Uri`, or anything with a `TypeConverter`). It sets the **real CLR
  property**, so an `INotifyPropertyChanged` view-model raises its change notification and bindings update
  exactly as they would from user input.
- `invoke_command(name?, path, parameter?)` executes an `ICommand` at `path` (`SaveCommand`,
  `Editor.RefreshCommand`) — checking `CanExecute` first — or, if `path` names a public method instead, it
  invokes the method (0 or 1 argument). Use it to trigger the logic behind a button without finding and
  clicking that button, or to reach a command that has no button yet.

The view-model is resolved from `name` (a control `Name`/label — its `DataContext` is used) or, when
`name` is omitted, from the **main window's `DataContext`**. Both tools flush the dispatcher after acting,
so a follow-up `screenshot_window`/`get_visual_tree` sees the result.

**Failures are structured and actionable (P2/P3)** — never a bare `An error occurred`. When a dotted path
doesn't resolve, the message names the failing segment, the **runtime type** of the object it was looked
up on, and what is actually available there — the relevant `ICommand` properties (for `invoke_command`)
or settable properties (for `set_view_model`), the nested sub-objects you can drill into, and a
"did you mean" suggestion:

```
invoke_command null "ViewCommands.ToggleBrushSettingsCommand"
→ path 'ViewCommands.ToggleBrushSettingsCommand' failed: DataContext is MainViewModel, no member
  'ViewCommands'. Available ICommand properties: [SaveCommand, ToggleBrushSettingsCommand].
  Sub-objects to drill into (dotted path): [AppState]. Did you mean 'ToggleBrushSettingsCommand'?
  Tip: call list_bindable to enumerate everything the target exposes.
```

When the real state lives on nested app state (`AppState.UiState.ShowBrushSettings`) rather than the
window's `DataContext`, **`list_bindable(name?)`** enumerates the whole bindable surface — settable
properties, `ICommand`s, invokable methods, and sub-objects — so you can build the correct deep path, then
`set_view_model null AppState.UiState.ShowBrushSettings true`.

```
list_bindable                                # enumerate the main window VM's bindable surface
set_view_model null IsBusy true              # flip a flag on the main window's VM → spinner shows
set_view_model "editor" Document.IsDirty true
invoke_command null ShowRecoveryCommand      # drive the app into the recovery state without a restart
invoke_command "grid" RefreshCommand 25      # execute a command with a parameter
```

> These are a **reflection escape hatch**, not a substitute for real user input — they bypass the view
> entirely. Use them to *set up* a state to verify, then drive the actual control with `tap`/`drag`/
> `invoke`/`click_at` when it is the control's behavior you are testing.

## Closed popups (`open_popup`, P5)

A closed `Popup`/`Flyout` has zero size and no realized content, so `screenshot_control` on it is a dead
end. Instead of a bare "has a zero size and cannot be captured", the tools now **detect a closed popup**
and return a hint: that it is a closed popup and how to open it. `open_popup(name)` then opens it in one
call — it sets the bound `IsOpen` of a `Popup` named `name` (or one owned by / nested in the named
control), or shows an attached `Button.Flyout`/`FlyoutBase`. After it opens, the content is realized and
`screenshot_control`/`get_visual_tree` can see it.

```
screenshot_control BrushSettingsPopup
→ 'BrushSettingsPopup' is a CLOSED popup … Open it first: open_popup{name:"BrushSettingsPopup"} …
open_popup BrushSettingsPopup                # sets IsOpen=true
screenshot_control BrushSettings             # now captures the realized content
```

## Limitations & safety

- **Breakpoints freeze captures.** Tree traversal and `RenderTargetBitmap` run on the UI thread; each
  tool marshals work there with `Dispatcher.UIThread.InvokeAsync`. If you are paused on a breakpoint
  the UI thread is not pumping, so a capture blocks until you resume. For an autonomous agent loop
  that is expected behaviour.
- **Loopback only.** The server binds strictly to `127.0.0.1`. Screenshots can contain sensitive data
  — another reason it is loopback + debug-only.
- **The tier-2 tools are off by default.** `invoke`, `set_window_size`, `set_theme`, `click_at`,
  `set_view_model` and `invoke_command` are a remote-control surface — they change app state (click,
  select, toggle, set values, resize, switch theme, write view-model state, run commands). They are
  registered only when you opt in with `EnableInteraction = true`, and like the rest of the inspector they
  are loopback + debug-only.
- **`highlight` and annotated screenshots add a transient overlay.** They mutate the visual tree with a
  frame adorner (cleared afterwards / by `action='clear'`); they never change app logic or state.
- **`hit_test` uses a transform-aware geometric hit test** (point-in-transformed-bounds over the visual
  tree), consistent with the absolute frame `get_visual_tree` reports. Real input (`tap`/`drag`/
  `pointer_*`/`click_at`) instead routes through the compositor's own hit test, so it respects clip
  geometry and z-order exactly as a device would.
- **Screenshots wait for a rendered frame.** `screenshot_window`/`screenshot_control` drain queued
  layout/render work and, if the captured frame is degenerate (a single flat color — captured before the
  layout settled), force a layout pass and retry once, so a capture right after opening a popup or
  switching state isn't an empty/dark image.
- **`get_data_context`/`get_properties` read via reflection** and call property getters; a getter with
  side effects will run, and one that throws is reported inline rather than aborting.
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
- **Runtime errors** — unhandled exceptions on the UI dispatcher (e.g. thrown inside an event handler or
  command) and unobserved task exceptions — are captured by `RuntimeErrorSink`, which subscribes to
  `Dispatcher.UIThread.UnhandledException` and `TaskScheduler.UnobservedTaskException`. It is a pure
  observer: it records the exception (with the throw site when symbols are available) but never marks it
  handled or observed, so the app's own error behavior is unchanged.
