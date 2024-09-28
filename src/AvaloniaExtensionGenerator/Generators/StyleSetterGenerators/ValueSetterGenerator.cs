using AvaloniaExtensionGenerator.Generators.SetterGenerators;

namespace AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

public class ValueStyleSetterGenerator : SetterGeneratorBase
{
    public override bool CanGenerateOverride(PropertyExtensionInfo info) => true;

    public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
    {
//    public static Style<TElement> Background<TElement>(this Style<TElement> style, Brush brush) where TElement : TemplatedControl =>
//        AddSetter(style, new Setter(TemplatedControl.BackgroundProperty, brush));

        //direct type access
        var extensionText =
            $"public static Style<{info.ControlTypeName}> {info.ExtensionName}(this Style<{info.ControlTypeName}> style, {info.ValueTypeSource} value){Environment.NewLine}"
            + getSetterBody();

        //base type generic acess
        if (info.CanBeGenericConstraint)
        {
            extensionText =
                $"public static Style<T> {info.ExtensionName}<T>(this Style<T> style, {info.ValueTypeSource} value)"
                + $" where T : {info.ControlTypeName}{Environment.NewLine}"
                + getSetterBody();
        }

        string getSetterBody() => $"=> style._addSetter({info.ControlTypeName}.{info.PropertyName}Property, value);";

        return extensionText;
    }
}
