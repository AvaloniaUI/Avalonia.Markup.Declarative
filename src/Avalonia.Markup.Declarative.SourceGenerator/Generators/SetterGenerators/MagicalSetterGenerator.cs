using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;

internal sealed class MagicalSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"[Obsolete]{SymbolUtilities.NewLine}" +
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"=> control._setEx({info.ControlTypeName}.{info.FieldSymbol.Name}, ps, () => control.{info.MemberName} = value!, bindingMode, converter, bindingSource);";
}
