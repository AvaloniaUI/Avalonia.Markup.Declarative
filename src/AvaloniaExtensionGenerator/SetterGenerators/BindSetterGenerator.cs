using System;
using System.Reflection;

namespace AvaloniaExtensionGenerator.SetterGenerators
{
    public class BindSetterGenerator : SetterGeneratorBase
    {
        public override string GetPropertySetterExtensionOverride(PropertyExtensionInfo info)
        {
            //direct type access
            var extensionText =
                $"public static {info.ControlTypeName} {info.ExtensionName}(this {info.ControlTypeName} control, Binding binding){Environment.NewLine}" +
                $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, binding);";

            //base type generic acess
            if (Config.BaseTypes.Contains(info.ControlType))
            {
                extensionText =
                    $"public static T {info.ExtensionName}<T>(this T control, Binding binding) where T : {info.ControlTypeName}{Environment.NewLine}" +
                    $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}, binding);";
            }

            return extensionText;
        }
    }
}