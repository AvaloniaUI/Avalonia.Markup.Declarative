# SourceGenerator Migration Plan

## Summary

- [x] Migrate external/framework extension generation from `AvaloniaExtensionGenerator` into `Avalonia.Markup.Declarative.SourceGenerator`.
- [x] Auto-generate for `Avalonia.Base`, `Avalonia.Controls`, `Avalonia.Markup`, `Avalonia.Themes.Fluent` when referenced.
- [ ] Preserve the current generated public API shape used by samples and consumers.
- [x] Track progress in this checklist during implementation.

## Implementation

- [x] Add public `GenerateMarkupExtensionsForAssemblyAttribute(Type anchorType)` in the runtime package.
- [x] Add source-generator discovery for referenced assemblies.
- [x] Auto-include minimal framework assemblies.
- [x] Add attribute-driven opt-in generation for non-framework libraries.
- [x] Deduplicate assemblies selected by auto-discovery and attributes.
- [x] Build a symbol-based host for external/framework types.
- [x] Port property generation overloads used by the stand-alone generator.
- [x] Port attached-property generation.
- [x] Port event generation, including routed events.
- [x] Port style setter generation.
- [x] Preserve `Avalonia.Markup.Declarative` namespace and `_MarkupExtensions` class naming.
- [x] Match stand-alone filtering for obsolete and readonly members.
- [x] Generate for `Avalonia.AvaloniaObject`-derived types, not only `Avalonia.Visual`.
- [ ] Keep existing local `IDeclarativeViewBase` generation working.

## Integration

- [x] Move sample projects away from checked-in `ControlExtensions.Generated` compilation.
- [x] Add assembly attributes in samples for non-framework external libraries.
- [ ] Verify framework extensions work without user attributes.
- [ ] Verify external library extensions work through the new attribute.

## Validation

- [ ] Build `Avalonia.Markup.Declarative.SourceGenerator`.
- [ ] Build sample projects that rely on generated extensions.
- [ ] Build tests project.
- [x] Update this file with completed checkboxes as milestones land.
