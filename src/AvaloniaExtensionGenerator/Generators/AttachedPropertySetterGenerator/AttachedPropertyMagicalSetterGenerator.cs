using AvaloniaExtensionGenerator.Generators.SetterGenerators;

namespace AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;
public class AttachedPropertyMagicalSetterGenerator : SetterGeneratorBase
{
    public override bool CanGenerateOverride(PropertyExtensionInfo info) => info.IsAttachedProperty;

    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        var argsString = $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                + $" [CallerArgumentExpression(\"value\")] string? ps = null)";

        var extensionText =
            $"public static T {info.ExtensionName}<T>"
            + $"(this T control, {argsString}"
            + $" where T : {info.AttachedPropertyHostTypeName}{Environment.NewLine}"
            + $" => control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => {info.ControlTypeName}.Set{info.PropertyName}(control, value), bindingMode, converter, bindingSource);";

        return extensionText;
    }
}