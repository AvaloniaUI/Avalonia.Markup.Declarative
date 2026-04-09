using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;

internal sealed class MagicalSetterWithConverterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"[Obsolete]{SymbolUtilities.NewLine}" +
        $"public static {info.ReturnType} {info.ExtensionName}<TValue{(info.IsGeneric ? ",T" : "")}>(this {info.ReturnType} control, TValue value, FuncValueConverter<TValue, {info.ValueTypeSource}> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"=> control._setEx({info.ControlTypeName}.{info.FieldSymbol.Name}, ps, () => control.{info.MemberName} = converter.TryConvert(value)!, bindingMode, converter, bindingSource);";
}
