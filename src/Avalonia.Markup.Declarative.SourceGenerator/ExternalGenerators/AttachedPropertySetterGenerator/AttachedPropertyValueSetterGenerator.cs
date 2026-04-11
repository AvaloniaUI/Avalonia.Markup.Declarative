using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.AttachedPropertySetterGenerator;

internal sealed class AttachedPropertyValueSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        if (string.IsNullOrWhiteSpace(info.AttachedPropertyHostTypeName))
        {
            return null;
        }

         return $"public static T {info.ExtensionName}<T>(this T control, {info.ValueTypeSource} value{CallerInfoParameters}) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
             $"   => control._set(() => {info.ControlTypeName}.Set{info.MemberName}(control, value!), _callerFile, _callerLine);";
    }
}