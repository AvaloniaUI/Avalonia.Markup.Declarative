namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class BindSetterGenerator : SetterGeneratorBase
{
    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        //direct type access
        var extensionText =
            $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, IBinding binding){Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, binding);";

        //base type generic acess
        if (info.CanBeGenericConstraint)
        {
            extensionText =
                $"public static T {info.ExtensionName}<T>(this T control, IBinding binding) where T : {info.ControlTypeName}{Environment.NewLine}" +
                $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, binding);";
        }

        return extensionText;
    }
}
