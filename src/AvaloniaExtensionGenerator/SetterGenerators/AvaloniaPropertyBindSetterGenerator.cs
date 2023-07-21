namespace AvaloniaExtensionGenerator.SetterGenerators;

public class AvaloniaPropertyBindSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null){Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, avaloniaProperty, bindingMode, converter);";

        //base type generic acess
        if (Config.BaseTypes.Contains(info.ControlType))
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : {info.ControlTypeName}{Environment.NewLine}" +
                $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, avaloniaProperty, bindingMode, converter);";
        }

        return extensionText;
    }
}