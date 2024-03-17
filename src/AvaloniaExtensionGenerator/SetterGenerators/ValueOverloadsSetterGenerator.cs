using System;
using System.Linq;
using System.Reflection;

namespace AvaloniaExtensionGenerator.SetterGenerators;

public class ValueOverloadsSetterGenerator : SetterGeneratorBase
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
                            $"public static T {info.ExtensionName}<T>(this T control, {argDefs}) where T : {info.ControlTypeName}{nl}" +
                            $"   => control._set(() => control.{info.PropertyName} = new {info.ValueTypeSource}({argVals}));";
                    }
                    else
                    {
                        extensionText += nl +
                            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, {argDefs}){nl}" +
                            $"   => control._set(() => control.{info.PropertyName} = new {info.ValueTypeSource}({argVals}));";
                    }
                }
            }
            return extensionText;
        }
}