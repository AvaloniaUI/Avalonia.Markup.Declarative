using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;
public class MagicalSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)=>
        $"[Obsolete]{Environment.NewLine}"
        + $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}"
        + $"(this {info.ReturnType} control,"
        + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Environment.NewLine}"
        + $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.MemberName} = value!, bindingMode, converter, bindingSource);";

}