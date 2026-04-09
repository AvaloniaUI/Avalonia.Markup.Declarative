using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.SetterGenerators;

public class BindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        // skip IBinding properties to avoid duplicates from other generators
        if (info.ValueType.Name == "IBinding")
            return null;

        return
            $"    /// <summary>{info.Comment}</summary>{Extensions.NewLine}" +
            $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, global::Avalonia.Data.IBinding binding){info.GenericConstraint}{Extensions.NewLine}" +
            $"        => control._set({info.ControlTypeName}.{info.MemberName}, binding);";
    }
}