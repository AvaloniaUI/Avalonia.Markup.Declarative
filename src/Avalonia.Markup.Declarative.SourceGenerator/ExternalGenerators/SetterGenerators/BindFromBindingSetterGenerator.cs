using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.SetterGenerators;

/// <summary>
/// Generates a named overload for each property that accepts a ready-made <c>BindingBase</c>
/// (reflection <c>Binding</c>, compiled binding, template binding, multi-binding, …), e.g.
/// <c>new TextBlock().Text(new Binding("Value"))</c>. See issue #121.
/// </summary>
internal sealed class BindFromBindingSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        // Guard against the (rare) property whose own value type is BindingBase, so the generated
        // overload never collides with the value setter of the same signature.
        if (info.ValueTypeSource is "global::Avalonia.Data.BindingBase" or "global::Avalonia.Data.BindingBase?")
        {
            return null;
        }

        return PrefixDocumentation(info.XmlDoc,
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, BindingBase binding{CallerInfoParameters}) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
            $"   => control.BindValue({info.ControlTypeName}.{info.FieldSymbol.Name}!, binding{CallerInfoArguments});");
    }
}
