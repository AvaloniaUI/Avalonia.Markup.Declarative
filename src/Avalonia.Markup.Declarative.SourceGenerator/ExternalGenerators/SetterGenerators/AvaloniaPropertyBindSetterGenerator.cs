using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.SetterGenerators;

internal sealed class AvaloniaPropertyBindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, AvaloniaProperty avaloniaProperty, AvaloniaObject source, BindingMode? bindingMode = null, IValueConverter? converter = null) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"   => control._setPropertyBinding({info.ControlTypeName}.{info.FieldSymbol.Name}, avaloniaProperty, source, bindingMode, converter);";
}
