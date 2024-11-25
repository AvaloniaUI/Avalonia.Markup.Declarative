using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class BindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IBinding binding) {info.GenericConstraint}{Environment.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, binding);";

}
