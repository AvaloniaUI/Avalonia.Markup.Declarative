using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.SetterGenerators;

public class ValueSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
      $"    /// <summary>{info.Comment}</summary>{Extensions.NewLine}" +
      $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value){info.GenericConstraint}{Extensions.NewLine}" +
      $"        => control._set(() => control.{info.MemberName} = value!);";
}