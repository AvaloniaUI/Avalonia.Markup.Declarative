using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.StyleSetterGenerators;

internal sealed class BindingStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource == "global::Avalonia.Data.IBinding")
        {
            return null;
        }

        return $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, IBinding binding) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
               $"=> style._addSetter({info.ControlTypeName}.{info.MemberName}Property, binding);";
    }
}
