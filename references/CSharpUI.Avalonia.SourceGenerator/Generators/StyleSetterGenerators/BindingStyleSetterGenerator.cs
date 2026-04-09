using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.StyleSetterGenerators;

public class BindingStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueType.Name == "IBinding")
            return $"//Skipped {info.ExtensionName} because already exist in value setters";

        //direct type access
        var extensionText =
            $"    /// <summary>{info.Comment}</summary>{Extensions.NewLine}" +
            $"    public static global::CSharpUI.Avalonia.Styles.Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this global::CSharpUI.Avalonia.Styles.Style<{info.ReturnType}> style, global::Avalonia.Data.IBinding binding){info.GenericConstraint}{Extensions.NewLine}" +
            $"        => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, binding);";

        return extensionText;
    }
}