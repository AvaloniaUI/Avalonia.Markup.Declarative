using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;
public class AttachedPropertyMagicalSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info) =>
        $"public static T {info.ExtensionName}<T>"
        + $"(this T control, "
        + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null)"
        + $" where T : {info.AttachedPropertyHostTypeName}{Environment.NewLine}"
        + $" => control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => {info.ControlTypeName}.Set{info.MemberName}(control, value), bindingMode, converter, bindingSource);";
}