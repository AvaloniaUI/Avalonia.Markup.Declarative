namespace AvaloniaExtensionGenerator.SetterGenerators;

public class BindFromExpressionSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, Func<{info.ValueTypeSource}> func, [CallerArgumentExpression(\"func\")] string? expression = null){Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, func, expression);";

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, Func<{info.ValueTypeSource}> func, [CallerArgumentExpression(\"func\")] string? expression = null) where T : {info.ControlTypeName}{Environment.NewLine}" +
                $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, func, expression);";
        }

        return extensionText;
    }
}