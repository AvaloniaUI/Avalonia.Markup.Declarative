using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class CommonPropertySetterExtension : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        var argsString = $"{info.ValueType} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, {argsString}){Environment.NewLine}"
            + $"   => control._setCommonEx(ps, () => control.{info.ExtensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }
}