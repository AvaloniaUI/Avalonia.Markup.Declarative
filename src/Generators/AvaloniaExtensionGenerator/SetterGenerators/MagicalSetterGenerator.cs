using System.Reflection;

namespace AvaloniaExtensionGenerator;
    public class MagicalSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(ExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, {info.ValueTypeSource} value, "
            + $"[CallerArgumentExpression(\"value\")] string ps = null){Environment.NewLine}"
            + getSetterBody();

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, {info.ValueTypeSource} value,"
                + $" [CallerArgumentExpression(\"value\")] string ps = null)"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody() => $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.PropertyName} = value);";

        return extensionText;
    }
}