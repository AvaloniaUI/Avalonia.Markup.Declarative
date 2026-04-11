using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.StyleSetterGenerators;

internal sealed class BindFromExpressionStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource is "global::Avalonia.Data.IBinding" or "global::Avalonia.Data.IBinding?")
        {
            return null;
        }

        var genericParams = info.IsGeneric ? "<T, TViewModel>" : "<TViewModel>";

        // Метод С передачей source (для привязки стиля к стейту SFC)
        var withSource = $"public static Style<{info.ReturnType}> {info.ExtensionName}{genericParams}(this Style<{info.ReturnType}> style, TViewModel source, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? bindingMode = null, IValueConverter? converter = null{CallerInfoParameters}) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
                         $"   => style._addSetterCompiledBinding({info.ControlTypeName}.{info.MemberName}Property!, source, getter, bindingMode, converter, _callerFile, _callerLine);";

        // Метод БЕЗ передачи source (для привязки стиля к DataContext)
        var withoutSource = $"public static Style<{info.ReturnType}> {info.ExtensionName}{genericParams}(this Style<{info.ReturnType}> style, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? bindingMode = null, IValueConverter? converter = null{CallerInfoParameters}) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
                            $"   => style._addSetterCompiledBinding({info.ControlTypeName}.{info.MemberName}Property!, getter, bindingMode, converter, _callerFile, _callerLine);";

        return PrefixDocumentation(info.XmlDoc, withSource) + SymbolUtilities.NewLine + PrefixDocumentation(info.XmlDoc, withoutSource);
    }
}