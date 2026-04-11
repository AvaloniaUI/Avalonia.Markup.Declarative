using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.SetterGenerators;

internal sealed class ValueSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
    PrefixDocumentation(info.XmlDoc,
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value{CallerInfoParameters}) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"=> control._set(() => control.{info.MemberName} = value!, _callerFile, _callerLine);");
}
