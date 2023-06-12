using System;
using System.Reflection;

namespace AvaloniaExtensionGenerator.SetterGenerators;
public class MagicalSetterWithConverterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        var argsString = $"TValue value, FuncValueConverter<TValue, {info.ValueTypeSource}> converter, BindingMode? bindingMode = null, object? bindingSource = null,"
                + $" [CallerArgumentExpression(\"value\")] string? ps = null)";
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}<TValue>"
            + $"(this {info.ControlTypeName} control, {argsString}"
            + getSetterBody();

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T,TValue>"
                + $"(this T control, {argsString}"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody()
        {
            var setterAction = $"() => control.{info.ExtensionName} = converter.TryConvert(value)";
            return
                $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, {setterAction}, bindingMode, converter, bindingSource);";
        }

        return extensionText;
    }
}