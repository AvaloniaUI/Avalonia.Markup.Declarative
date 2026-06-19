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

Compiled-binding setters support automatic conversion for common primitive and nullable mismatches. Prefer `x => x.Property` without casts; for example, `int -> double` and `bool -> bool?` bindings work without a manual converter, and lossy numeric `TwoWay` convert-back truncates toward zero.