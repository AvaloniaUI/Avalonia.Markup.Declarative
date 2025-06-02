using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;
public class MagicalSetterWithConverterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"[Obsolete]{Environment.NewLine}"
        + $"public static {info.ReturnType} {info.ExtensionName}<TValue{(!info.IsGeneric ? "" : "," + info.ReturnType)}>"
        + $"(this {info.ReturnType} control, "
        + $"TValue value, FuncValueConverter<TValue, {info.ValueTypeSource}> converter, BindingMode? bindingMode = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Environment.NewLine}"
        + $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.ExtensionName} = converter.TryConvert(value)!, bindingMode, converter, bindingSource);";
}