using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.Generators.AttachedPropertySetterGenerator;

internal sealed class AttachedPropertyMagicalSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        if (string.IsNullOrWhiteSpace(info.AttachedPropertyHostTypeName))
        {
            return null;
        }

        return $"public static T {info.ExtensionName}<T>(this T control, {info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : {info.AttachedPropertyHostTypeName}{SymbolUtilities.NewLine}" +
               $" => control._setEx({info.ControlTypeName}.{info.FieldSymbol.Name}, ps, () => {info.ControlTypeName}.Set{info.MemberName}(control, value), bindingMode, converter, bindingSource);";
    }
}
