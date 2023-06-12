using System;
using System.Reflection;

namespace AvaloniaExtensionGenerator.SetterGenerators;
public class MagicalSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        var argsString = $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                + $" [CallerArgumentExpression(\"value\")] string? ps = null)";
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}"
            + $"(this {info.ControlTypeName} control, {argsString}"
            + getSetterBody();

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>"
                + $"(this T control, {argsString}"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody() => $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.PropertyName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }
}