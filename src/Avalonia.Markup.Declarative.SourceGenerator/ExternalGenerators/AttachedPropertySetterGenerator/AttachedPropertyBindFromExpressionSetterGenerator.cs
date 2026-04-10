using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.AttachedPropertySetterGenerator;

internal sealed class AttachedPropertyBindFromExpressionSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        if (string.IsNullOrWhiteSpace(info.AttachedPropertyHostTypeName))
        {
            return null;
        }

        // overload with source parameter (for regular binding scenarios)
        var withSource = $"public static T {info.ExtensionName}<T, TViewModel>(this T control, TViewModel source, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? mode = null, IValueConverter? converter = null) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
                         $"   => control._setCompiledBinding({info.ControlTypeName}.{info.FieldSymbol.Name}!, source, getter, mode, converter);";

        // overload without source parameter (for DataContext-bound scenarios)
        var withoutSource = $"public static T {info.ExtensionName}<T, TViewModel>(this T control, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? mode = null, IValueConverter? converter = null) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
                            $"   => control._setCompiledBinding({info.ControlTypeName}.{info.FieldSymbol.Name}!, getter, mode, converter);";

        return withSource + SymbolUtilities.NewLine + withoutSource;
    }
}