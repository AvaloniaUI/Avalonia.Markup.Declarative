--------------------------------
Avalonia.Markup.Declarative
--------------------------------

Write Avalonia UI with pure C#

repo: 
https://github.com/AvaloniaUI/Avalonia.Markup.Declarative


to use with external libraries, install AvaloniaExtensionGenerator tool here:

https://www.nuget.org/packages/AvaloniaExtensionGenerator/


Quick Start sample:

https://github.com/AvaloniaUI/Avalonia.Markup.Declarative/tree/master/src/Samples/DeclarativeComponentTemplate

Compiled-binding setters support automatic conversion for common primitive and nullable mismatches, so prefer plain member access like `x => x.Property` and skip numeric casts; for example, `int -> double` and `bool -> bool?` bindings work without a manual converter or a cast. A value-converting cast such as `x => (double)x.Counter` is rejected by Avalonia's expression parser, but type casts that reach a member of a derived type — e.g. `x => ((DerivedType)x).Property` — are supported. Lossy numeric `TwoWay` convert-back truncates toward zero.

AI agent tooling: the dev-only `Declarative.Avalonia.AgentTools` package runs an in-process MCP server (loopback, debug builds) that gives an agent screenshots (with before/after diffing), the visual tree with bounds, per-control layout reports, an automated layout audit, property/property-source/view-model inspection, pixel↔control hit-testing, a highlight overlay that frames where a control actually landed, and build/binding/runtime errors of the running app — plus an opt-in tier to drive it (click, type, resize, theme). The app can also show a live "agent connected" status. See docs/agent-tools.md.