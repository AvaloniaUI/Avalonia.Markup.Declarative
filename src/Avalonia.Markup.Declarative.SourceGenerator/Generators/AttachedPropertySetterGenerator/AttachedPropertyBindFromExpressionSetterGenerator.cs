using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.AttachedPropertySetterGenerator;

internal sealed class AttachedPropertyBindFromExpressionSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        if (string.IsNullOrWhiteSpace(info.AttachedPropertyHostTypeName))
        {
            return null;
        }

        return $"public static T {info.ExtensionName}<T, TViewModel>(this T control, TViewModel source, Expression<Func<TViewModel, {info.ValueTypeSource}>> getter, BindingMode? mode = null, IValueConverter? converter = null) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
               $"   => control._setCompiledBinding({info.ControlTypeName}.{info.FieldSymbol.Name}!, source, getter, mode, converter);";
    }
}
