using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class ValueOverloadsSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
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
                    var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.FullName} {x.Name} = default!"));
                    var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                        extensionText += Environment.NewLine +
                                         $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                         $"   => control._set(() => control.{info.MemberName} = new {info.ValueTypeSource}({argVals}));";
                }
            }
            return extensionText;
        }
} 