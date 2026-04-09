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

        return $"public static T {info.ExtensionName}<T>(this T control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : {info.AttachedPropertyHostTypeName} {SymbolUtilities.NewLine}" +
               $"   => control._set({info.ControlTypeName}.{info.FieldSymbol.Name}!, func, onChanged, expression);";
    }
}
