using AvaloniaExtensionGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class CommonPropertyBindingSetterExtension : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, IBinding binding){Environment.NewLine}"
            + $"   => control._setCommonBindingEx(({info.ValueType} value) => control.{info.ExtensionName} = value, binding);";

        return extensionText;
    }
}