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

        return $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, Func<{info.ValueTypeSource}> func, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(func))] string? expression = null) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
               $"   => style._addSetterEx({info.ControlTypeName}.{info.MemberName}Property!, expression, bindingMode, converter, bindingSource);";
    }
}