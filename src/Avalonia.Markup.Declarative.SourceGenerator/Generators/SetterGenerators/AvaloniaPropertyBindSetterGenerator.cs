using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;

internal sealed class AvaloniaPropertyBindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldSymbol.Name}, avaloniaProperty, bindingMode, converter, overrideView);";
}
