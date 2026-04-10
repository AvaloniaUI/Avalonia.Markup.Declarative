using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.StyleSetterGenerators;

internal sealed class ValueStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
    $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {info.ValueTypeSource} value) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
        $"=> style._addSetter({info.ControlTypeName}.{info.MemberName}Property!, value!);";
}
