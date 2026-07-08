# Agent Tools v2 — roadmap for autonomous UI building & debugging

Plan for extending `Declarative.Avalonia.AgentTools` (in-process MCP inspector) so an agent can run
the full loop — edit code → hot reload → **see** → **understand** → **act** → **verify** — without a
human relaying what the UI looks like.

> **Status (implemented):** Phases 1–4 are done and covered by tests in
> `Avalonia.Markup.Declarative.Diagnostics.Tests`. New tools: `get_app_info`, `get_properties`,
> `get_property_sources`, `get_data_context`, `get_source`, `find_text`, `hit_test`, `layout_audit`,
> `wait_for`, `wait_idle`, annotated `screenshot_window`, `compare_screenshots`, `list_screenshots`,
> `get_visual_tree` `maxDepth`/`filter`, popup visibility across the find/tree/app-info tools,
> runtime-exception capture in `get_errors`, and tier-2 `set_window_size`, `set_theme`, `click_at`, plus
> `invoke` `select_item`/`scroll_by`. `click_at` shipped as the automation-resolution variant (no
> synthetic pointer). **Phase 4:** `compare_screenshots` (4.1) and `get_property_sources` (4.2, via the
> public `GetDiagnostic` API) done; per-control `file:line` tagging (4.3) shipped as opt-in
> `EnableSourceTagging` on `.Name(...)`.
>
> **Beyond the plan:** `AgentConnectionMonitor` raises UI-thread `Connected`/`Disconnected`/`StatusChanged`
> events (activity-based, since the transport is stateless HTTP) so an app can show a live "agent
> connected" indicator (wired into the sample's window title).
>
> **Post-feedback refinements (from an agent driving the tools):**
> - `click_at` and `invoke`'s typed fallbacks now **climb to the nearest actionable control** (a pixel/label
>   lands on the inner `AccessText`, not the `Button`) and the result reports which control it resolved to,
>   so a click on the label can't silently no-op.
> - Interaction target resolution gained a **visible-text fallback** (`AgentToolContext.FindInteractionTarget`)
>   mirroring `find_text`, so a button addressable by its caption in `find_text` is also invokable by it.
> - `invoke`/`click_at`/the escape-hatch tools wrap their body in try/catch → an actionable message instead
>   of the MCP SDK's opaque `An error occurred invoking 'invoke'`; the no-focus `key`/`type` message now
>   tells you to pass `name` or focus first.
> - **Escape hatch:** `ViewModelInspector` (core, dependency-free) + tier-2 `set_view_model` /
>   `invoke_command` set a VM property or run an `ICommand`/method directly, to reach awkward states (e.g.
>   a recovery banner) without killing/restarting the process.

## Current state (already shipped)

`get_visual_tree` (+ non-default HAlign/VAlign/Margin), `get_layout` (per-control layout report),
`list_components`, `screenshot_window` / `screenshot_control`, `highlight` (frame overlay + screenshot),
`get_errors` (build/binding/converter), `invoke` (tier-2: invoke/select/toggle/set/expand/collapse/
focus/scroll/context_menu/key/type).

## Architecture rules (do not violate)

- **Core** (`Avalonia.Markup.Declarative/Diagnostics/*`) stays **dependency-free** (Avalonia only):
  all inspection/analysis logic lives here as plain static services, reusable from tests.
- **AgentTools** adds only thin MCP wrappers (`Tools/*.cs`), selector resolution and marshaling via
  `AgentToolContext.RunOnUiThreadAsync`.
- Read-only tools → `InspectionTools` with `ReadOnly = true`. State-changing tools → `InteractionTools`,
  registered only behind `EnableInteraction` (tier-2).
- Every phase: headless-Skia tests in `Avalonia.Markup.Declarative.Diagnostics.Tests` + update
  `docs/agent-tools.md` tables and both READMEs.
- Selector convention (already established): Name → visible label (automation name) → type name.

Verified facts to rely on:
- `CallerFilePath`/`CallerLineNumber` flow **only** into `ViewBuildingException` messages; they are
  NOT stored per control. `HotReloadManager` tracks live instances by **type**, not file.
- Screenshots render at 96 DPI (`ControlScreenshotService.StandardDpi`), so **image pixels == DIP
  coordinates** — pixel coords from a screenshot can be fed straight into hit-testing.
- `VisualTreeDumpOptions.MaxDepth` already exists but is not exposed on the MCP tool.

---

## Phase 1 — Discovery & targeted inspection (read-only)

Closes the "understand what I'm looking at" gap: today the agent sees the tree and one control's
layout, but cannot read arbitrary properties, map pixels→tree, or find things by visible text.

### 1.1 `get_properties(selector, properties?)`  [M]
Read property values of one control.
- Core: new `PropertyInspector.DescribeProperties(Control, string[]? names)`.
- Default output: a curated common set (Background, Foreground, FontSize, IsEnabled, DataContext type,
  Classes incl. pseudo-classes, Tag, …) **plus every locally-set styled property** (enumerate via
  `AvaloniaPropertyRegistry.Instance.GetRegistered(control)` + `control.IsSet(prop)`).
- `properties` arg: explicit list (styled property name or CLR property via reflection fallback).
- Value formatting: reuse conventions (`ISolidColorBrush` → color hex, shorten long strings, type name
  for complex objects).

### 1.2 `hit_test(x, y, windowId?)`  [S]
Pixel → control chain. The reverse of screenshots: agent sees an artifact at (x,y), asks what's there.
- Core: `HitTester.Describe(TopLevel, Point)` using `top.GetVisualsAt(point)`; report topmost → root
  chain with type/#Name/bounds, mark which nodes are named.
- Document explicitly: coordinates are window-client DIPs == screenshot pixels.

### 1.3 `find_text(text)`  [S]
Visible text → controls. Complement of hit_test for when the agent reads a screenshot.
- Core: `ControlLocator.FindAllByText(Visual root, string text)` — substring, case-insensitive, checks
  `TextBlock.Text`, `TextBox.Text`, `ContentControl.Content as string`, automation name.
- Tool returns matches with type/#Name/bounds/window, capped (e.g. 50) with an overflow note.

### 1.4 `get_visual_tree`: `maxDepth?`, `filter?` params  [S]
Large apps produce token-heavy dumps.
- Expose existing `MaxDepth`; add `Filter` to `VisualTreeDumpOptions`: show only subtrees containing a
  type/name substring match (keep ancestor lines of matches for context, skip non-matching branches).

### 1.5 `get_app_info()`  [S]
One cheap orientation call for the start of a session.
- Windows (title, index, ClientSize, DPI/RenderScaling), open popup roots (see 2.3), focused element
  (type/#Name), `ActualThemeVariant`/`RequestedThemeVariant`, Avalonia version, hot-reload active
  (`ComponentRegistry` non-empty), whether interaction tier is enabled.

### 1.6 `get_data_context(selector, depth?)`  [M]
Binding debugging needs to see the VM.
- Core: `DataContextInspector.Describe(object dc, int depth)` — public readable properties via
  reflection, depth default 1 (max 3), cycle-safe (reference set), collections summarized
  (`Count=N, first items…`), values formatted/shortened; note whether `INotifyPropertyChanged`.
- Never invoke property getters that throw — catch per-property and report `<threw: Message>`.

### 1.7 `get_source(selector)`  [S]
Tie a control back to code — the agent edits code, so "which component built this?" is the key hop.
- Walk visual ancestors to the nearest `ViewBase`; report its `Type.FullName` + assembly, plus the
  full ancestor chain of ViewBase components (nested views).
- The agent greps the repo for `class <TypeName>` itself — no file tracking needed.
- (Exact file:line per control is Phase 4.3 — do NOT attempt it here.)

---

## Phase 2 — Verification loop (read-only + overlay + error coverage)

Closes "did my change actually work?" — turning screenshot-staring into structured signals.

### 2.1 `layout_audit(rootName?)`  [M]
Automated layout lint over a subtree. The single highest-value tool of this plan for вёрстка.
- Core: `LayoutAuditor.Audit(Visual root, TopLevel top)` returning findings:
  - `zero-size` — IsVisible but width/height ≤ 0;
  - `off-screen` / `partially-clipped` — vs `top.ClientSize` (reuse logic from `LayoutInspector`);
  - `out-of-parent` — child bounds exceed parent bounds (skip inside ScrollViewer/Canvas — legitimate);
  - `overlap` — visible siblings in the same Panel intersecting > 1px (note: same Grid cell overlap is
    often intentional — report with a caveat marker);
  - `text-clipped` — TextBlock/TextBox with DesiredSize > arranged Bounds (+epsilon);
  - `hidden-by-ancestor` — IsVisible true but IsEffectivelyVisible false.
- Output: compact list `severity kind Type #Name [bounds] detail`, deduped, capped with counts.
- Tool: `layout_audit` (ReadOnly). Empty result → "no layout anomalies found".

### 2.2 `screenshot_window(annotate?)`  [M]
Add `annotate: bool` param — one image where every **named** control is boxed and labeled.
- Implementation choice (decide in code): temporary `ControlHighlightService.Highlight(all named)` →
  capture → `Clear()` in a finally (simplest, reuses shipped overlay and stays pixel-true), vs drawing
  on a `RenderTargetBitmap` DrawingContext post-render. Prefer the highlight-reuse variant.
- Label = `#Name` only (short); add `filter?` param (type/name substring) to avoid clutter.

### 2.3 Popup/flyout visibility  [M]
Today an agent opening a ComboBox/ContextMenu/Flyout cannot see the popup (PopupRoot is a separate
top-level, not in `desktop.Windows`).
- Core: `PopupLocator.GetOpenPopupRoots()` — walk all top-levels + component roots for
  `Popup { IsOpen: true }` descendants, resolve `popup.Host` → the popup's `TopLevel`; also handles
  Flyout/ContextMenu/ComboBox (they all host through Popup).
- Integrate: `AgentToolContext.GetTopLevels()` gains an `includePopups` path used by `FindControl`/
  `FindControls`, `get_visual_tree` (dump popup content under a marked `[popup]` node),
  `screenshot_window` (popup root addressable by index), `hit_test`, `get_app_info` (list open popups).
- Test: headless window + opened `Popup` → tree contains popup content, screenshot of popup works.

### 2.4 `wait_for(selector, condition, timeoutMs?)` + `wait_idle()`  [M]
Sync primitives so the agent doesn't busy-poll `get_visual_tree` after `invoke`/hot reload.
- AgentTools-only (no core): background loop polling via `RunOnUiThreadAsync` every ~100 ms.
- Conditions: `exists | gone | visible | hidden | enabled | bounds-stable` (bounds unchanged for
  ~300 ms). Timeout default 5000 ms, cap ~30 s. Returns what happened + final state (type/#Name/bounds).
- `wait_idle`: `await Dispatcher.UIThread.InvokeAsync(() => {}, DispatcherPriority.ApplicationIdle)` +
  a layout flush; returns when the dispatcher drained — use after hot reload or animations.

### 2.5 Runtime exception capture  [S]
Biggest debugging blind spot: an exception in an event handler (e.g. button click) is invisible to
`get_errors` today.
- Hook in `UseAgentInspector` (next to `BindingErrorSink.Install()`):
  `Dispatcher.UIThread.UnhandledException` (log, **do not** set `Handled` — never change app behavior)
  and `TaskScheduler.UnobservedTaskException`.
- New `DiagnosticCategory.Runtime`; entries include exception type, message, and top app-frame of the
  stack. Flows through existing `get_errors`.
- Consider an `Uninstall`/idempotent-install mirror of `BindingErrorSink` conventions.

---

## Phase 3 — Interaction & probing (tier-2, behind `EnableInteraction`)

Closes "act and verify" for responsive/theming work and controls the automation layer can't reach.

### 3.1 `set_window_size(width, height, windowId?)`  [S]
Responsive verification: resize → screenshot at breakpoints (e.g. 400/800/1200 wide).
- Sets `Window.Width/Height`, flushes layout, returns the resulting ClientSize (may be clamped by
  Min/Max) + previous size so the agent can restore.

### 3.2 `set_theme(variant)`  [S]
`Application.Current.RequestedThemeVariant` = `Light | Dark | Default`. Returns previous + actual
variant. Verify both themes with screenshots.

### 3.3 New `invoke` actions  [M]
- `select_item` (value = item text): resolve the target (or nearest ancestor) `SelectingItemsControl`;
  match an item by its text (string item, ContentControl content, container automation name) →
  set `SelectedIndex`/`SelectedItem`. Covers ComboBox/ListBox/TabControl without popup gymnastics.
- `scroll_by` (value = `"dx,dy"`): nearest `ScrollViewer` (self, ancestor, or descendant) →
  `Offset += delta`; report new offset + extent so the agent knows whether it hit the end.

### 3.4 `click_at(x, y, windowId?, button?)`  [L, experimental]
Raw pointer for custom-drawn controls without automation peers (canvas editors, charts).
- Approach: hit-test topmost `InputElement` at the point → raise `PointerPressed`/`PointerReleased`
  routed events with a synthetic `Pointer`. **Feasibility risk**: constructing `PointerEventArgs`/
  `PointerPoint` from public API in the targeted Avalonia version — spike first; if not constructible,
  fall back to automation `Invoke` on the hit control and say so in the tool result.
- Mark `Destructive = true`, document limitations honestly (no hover, no drag in v1).

---

## Phase 4 — Stretch (do only on demand)

### 4.1 `compare_screenshots`  [M]
Before/after diff without eyeballing: each capture gets an id (ring buffer of last ~10 in memory);
`compare_screenshots(idA, idB?)` → changed-region bbox, % changed pixels, optional diff PNG
(via `Bitmap.CopyPixels` — no new dependencies).

### 4.2 `get_property_sources(selector, property)`  [M, investigate]
Where a value came from (local / style / binding / animation). Public surface is limited
(`IsSet`, `GetBaseValue`, `IsAnimating`; DevTools uses internals) — spike first, ship only what the
public API supports, otherwise drop.

### 4.3 Per-control source tagging (file:line)  [L, opt-in]
Debug-only attached property stamped in `.Name()`/`_set` from `CallerFilePath`/`CallerLineNumber` so
`get_source` returns exact locations. Costs memory/perf on every build call — must be off by default,
measure before shipping; only worth it if 1.7 (type-level mapping) proves insufficient in practice.

---

## Suggested implementation order

Highest leverage first, each step independently shippable:

1. **2.5** runtime exceptions (tiny, removes a blind spot)
2. **2.1** layout_audit
3. **1.1** get_properties + **1.4** tree filters
4. **1.2** hit_test + **1.3** find_text + **1.5** get_app_info
5. **2.3** popup support
6. **2.4** wait_for/wait_idle
7. **2.2** annotated screenshots
8. **1.6** get_data_context + **1.7** get_source
9. Phase 3 (3.1 → 3.2 → 3.3 → 3.4)
10. Phase 4 on demand

## Non-goals

- Anything that changes app behavior silently (exception swallowing, input hooks) — observers only.
- Network exposure — loopback stays the hard rule.
- Duplicating the external `avalonia_devtools` MCP: this inspector's edge is being in-process with
  the declarative library (components, hot reload, build errors, source mapping) — keep leaning into
  that, not into generic DevTools parity.
