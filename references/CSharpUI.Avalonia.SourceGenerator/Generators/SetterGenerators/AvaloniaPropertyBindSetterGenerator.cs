using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.SetterGenerators;

public class AvaloniaPropertyBindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"    /// <summary>{info.Comment}</summary>{Extensions.NewLine}" +
        $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, global::Avalonia.AvaloniaProperty avaloniaProperty, global::Avalonia.Data.BindingMode? bindingMode = null, global::Avalonia.Data.Converters.IValueConverter? converter = null){info.GenericConstraint}{Extensions.NewLine}" +
        $"        => control._set({info.ControlTypeName}.{info.FieldName}, avaloniaProperty, bindingMode, converter);";

}