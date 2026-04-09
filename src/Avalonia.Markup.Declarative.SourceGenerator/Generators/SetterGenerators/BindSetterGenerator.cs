using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;

internal sealed class BindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource == "global::Avalonia.Data.IBinding")
        {
            return null;
        }

        return $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IBinding binding) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
               $"   => control._set({info.ControlTypeName}.{info.FieldSymbol.Name}, binding);";
    }
}
