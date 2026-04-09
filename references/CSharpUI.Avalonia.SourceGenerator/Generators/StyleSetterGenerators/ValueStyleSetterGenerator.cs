using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.StyleSetterGenerators;

public class ValueStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueTypeSource.ToString() == "IBinding")
        {
            return "// Skipped as return type is IBinding";
        }

        //direct type access
        var extensionText =
            $"    /// <summary>{info.Comment}</summary>{Extensions.NewLine}" +
            $"    public static global::CSharpUI.Avalonia.Styles.Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this global::CSharpUI.Avalonia.Styles.Style<{info.ReturnType}> style, {info.ValueTypeSource} value){info.GenericConstraint}{Extensions.NewLine}" +
            $"        => style._addSetter({info.ControlTypeName}.{info.MemberName}Property!, value!);";

        return extensionText;
    }
}