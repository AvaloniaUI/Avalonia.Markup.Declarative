using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.SetterGenerators;

internal sealed class BindFromExpressionSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
    {
        var genericParams = info.IsGeneric ? "<T, TViewModel, TValue>" : "<TViewModel, TValue>";

        var withSource = $"public static {info.ReturnType} {info.ExtensionName}{genericParams}(this {info.ReturnType} control, TViewModel source, Expression<Func<TViewModel, TValue>> getter, BindingMode? mode = null, IValueConverter? converter = null{CallerInfoParameters}) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
                         $"   => control._setCompiledBinding({info.ControlTypeName}.{info.FieldSymbol.Name}!, source, getter, mode, converter{CallerInfoArguments});";

        //var withoutSource = $"public static {info.ReturnType} {info.ExtensionName}{genericParams}(this {info.ReturnType} control, Expression<Func<TViewModel, TValue>> getter, BindingMode? mode = null, IValueConverter? converter = null{CallerInfoParameters}) {info.GenericConstraint} {SymbolUtilities.NewLine}" +
        //                    $"   => control._setCompiledBinding({info.ControlTypeName}.{info.FieldSymbol.Name}!, getter, mode, converter{CallerInfoArguments});";

        return withSource; // + SymbolUtilities.NewLine + withoutSource;
    }
}