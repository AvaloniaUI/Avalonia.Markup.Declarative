using AvaloniaExtensionGenerator.SetterGenerators;

namespace AvaloniaExtensionGenerator.StyleSetterGenerators;

public class ValueOverloadsStyleSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        var nl = Environment.NewLine;
        var extensionText = "";
        // overloads for primitive types like margin
        if (!info.ValueType.Module.ScopeName.StartsWith("System")
            && info.ValueType.IsValueType
            && info.ValueType.GetConstructors().Length > 1)
        {
            foreach (var constructor in info.ValueType.GetConstructors())
            {
                var ps = constructor.GetParameters();
                var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.Name} {x.Name}"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                if (Config.BaseTypes.Contains(info.ControlType))
                {
                    extensionText += nl +
                                     $"public static Style<T> {info.ExtensionName}<T>(this Style<T> style, {argDefs})"
                                     + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                                     + $"   => style._addSetter({info.ControlTypeName}.{info.PropertyName}Property, new {info.ValueTypeSource}({argVals}));";
                }
                else
                {
                    extensionText += nl +
                                     $"public static Style<{info.ControlTypeName}> {info.ExtensionName}(this Style<{info.ControlTypeName}> style, {argDefs}){Environment.NewLine}" +
                                     $"   => style._addSetter({info.ControlTypeName}.{info.PropertyName}Property, new {info.ValueTypeSource}({argVals}));";
                }
            }
        }
        return extensionText;
    }
}