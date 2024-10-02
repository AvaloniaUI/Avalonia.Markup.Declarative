using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

public class ValueOverloadsStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        var extensionText = "";
        // overloads for primitive types like margin
        if (!info.ValueType.Module.ScopeName.StartsWith("System")
            && info.ValueType.IsValueType
            && info.ValueType.GetConstructors().Length > 1)
        {
            foreach (var constructor in info.ValueType.GetConstructors())
            {
                var ps = constructor.GetParameters();
                var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.FullName} {x.Name}"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                extensionText += $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                 $"   => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, new {info.ValueTypeSource}({argVals}));";
            }
        }
        return extensionText;
    }
}