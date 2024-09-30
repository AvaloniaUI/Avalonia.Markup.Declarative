using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;
public class MagicalSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)=>
        $"public static {info.ControlTypeName} {info.ExtensionName}{info.GenericArg}"
        + $"(this {info.ReturnType} control,"
        + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(\"value\")] string? ps = null) {info.GenericConstraint}"
        + $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.MemberName} = value, bindingMode, converter, bindingSource);";

}