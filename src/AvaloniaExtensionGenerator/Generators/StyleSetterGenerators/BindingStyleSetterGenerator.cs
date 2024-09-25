using AvaloniaExtensionGenerator.Generators.SetterGenerators;

namespace AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

public class BindingStyleSetterGenerator : SetterGeneratorBase
{
    public override bool CanGenerateOverride(PropertyExtensionInfo info) => !info.IsAttachedProperty;

    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
        if (info.ValueType.Name == "IBinding")
            return $"//Skipped {info.ExtensionName} because already exist in value setters";

        //direct type access
        var extensionText =
            $"public static Style<{info.ControlTypeName}> {info.ExtensionName}(this Style<{info.ControlTypeName}> style, IBinding binding){Environment.NewLine}"
            + getSetterBody();

        //base type generic acess
        if (info.CanBeGenericConstraint)
        {
            extensionText =
                $"public static Style<T> {info.ExtensionName}<T>(this Style<T> style, IBinding binding)"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody() => $"=> style._addSetter({info.ControlTypeName}.{info.PropertyName}Property, binding);";

        return extensionText;
    }
}
