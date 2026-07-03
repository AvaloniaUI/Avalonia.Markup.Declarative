using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.StyleSetterGenerators;

/// <summary>
/// Generates a named style-setter overload for each property that accepts a ready-made <c>BindingBase</c>, e.g.
/// <c>new Style&lt;TextBlock&gt;().Text(new Binding("Value"))</c>. Avalonia treats a <c>BindingBase</c> assigned to a
/// <c>Setter.Value</c> as a binding, so this routes through the existing <c>_addSetter</c> value setter. See issue #121.
/// </summary>
internal sealed class BindFromBindingStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource is "global::Avalonia.Data.BindingBase" or "global::Avalonia.Data.BindingBase?")
        {
            return null;
        }

        return PrefixDocumentation(info.XmlDoc,
            $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, BindingBase binding{CallerInfoParameters}) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
            $"   => style._addSetter({info.ControlTypeName}.{info.MemberName}Property!, binding, _callerFile, _callerLine);");
    }
}
