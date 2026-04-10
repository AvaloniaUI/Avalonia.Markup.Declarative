using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.StyleSetterGenerators;

internal sealed class BindFromExpressionStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource is "global::Avalonia.Data.IBinding" or "global::Avalonia.Data.IBinding?")
        {
            return null;
        }

        var genericParams = info.IsGeneric ? "<T, TViewModel>" : "<TViewModel>";
        return $"public static Style<{info.ReturnType}> {info.ExtensionName}{genericParams}(this Style<{info.ReturnType}> style, TViewModel source, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? bindingMode = null, IValueConverter? converter = null) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
               $"   => style._addSetterCompiledBinding({info.ControlTypeName}.{info.MemberName}Property!, source, getter, bindingMode, converter);";
    }
}