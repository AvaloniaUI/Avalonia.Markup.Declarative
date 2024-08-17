namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class AvaloniaPropertyBindSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null){Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, avaloniaProperty, bindingMode, converter, overrideView);";

        //base type generic acess
        if (info.CanBeGenericConstraint)
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : {info.ControlTypeName}{Environment.NewLine}" +
                $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, avaloniaProperty, bindingMode, converter, overrideView);";
        }

        return extensionText;
    }
}