using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;

internal sealed class BindFromExpressionSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldSymbol.Name}!, func, onChanged, expression);";
}
