using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.AttachedPropertySetterGenerator;

/// <summary>
/// Generates a named overload for each attached property that accepts a ready-made <c>BindingBase</c>, e.g.
/// <c>new TextBlock().Grid_Row(new Binding("Row"))</c>. See issue #121.
/// </summary>
internal sealed class AttachedPropertyBindFromBindingSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        if (string.IsNullOrWhiteSpace(info.AttachedPropertyHostTypeName))
        {
            return null;
        }

        if (info.ValueTypeSource is "global::Avalonia.Data.BindingBase" or "global::Avalonia.Data.BindingBase?")
        {
            return null;
        }

        return PrefixDocumentation(info.XmlDoc,
            $"public static T {info.ExtensionName}<T>(this T control, BindingBase binding{CallerInfoParameters}) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
            $"   => control.BindValue({info.ControlTypeName}.{info.FieldSymbol.Name}!, binding{CallerInfoArguments});");
    }
}
