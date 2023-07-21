namespace AvaloniaExtensionGenerator.SetterGenerators;


public class ValueSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, {info.ValueTypeSource} value){Environment.NewLine}"
            + getSetterBody();

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, {info.ValueTypeSource} value)"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody() => $"=> control._set(() => control.{info.PropertyName} = value);";

        return extensionText;
    }
}
