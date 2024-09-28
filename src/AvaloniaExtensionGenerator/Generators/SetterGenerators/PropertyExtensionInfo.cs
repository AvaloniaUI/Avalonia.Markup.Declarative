using System.Collections;
using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class PropertyExtensionInfo : IMemberExtensionInfo
{
    public FieldInfo FieldInfo { get; }
    public Type ControlType { get; }
    public object ControlTypeName { get; }
    public string ExtensionName { get; }
    public string PropertyName { get; }
    public Type ValueType { get; }
    public object ValueTypeSource { get; }
    public bool IsObsolete => ObsoleteMessage != null;
    public string? ObsoleteMessage { get; } = null;

    public bool CanBeGenericConstraint { get; }
    public bool IsAttachedProperty { get; set; }
    public Type? AttachedPropertyHostType { get; set; }
    public string? AttachedPropertyHostTypeName { get; set; }


    public PropertyExtensionInfo(FieldInfo field)
    {
        FieldInfo = field;
        ControlType = field.DeclaringType ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.Name.Replace("Property", "");
        PropertyName = field.Name.Replace("Property", "");
        ValueType = field.FieldType.GetGenericArguments().Last();
        ControlTypeName = ControlType.GetTypeDeclarationSourceCode();
        ValueTypeSource = ValueType.GetTypeDeclarationSourceCode();

        IsAttachedProperty = field.FieldType.Name.StartsWith("AttachedProperty");
        if (IsAttachedProperty)
        {
            try
            {
                ExtensionName = $"{ControlType.Name}_{ExtensionName}";
                var declaredType = field.DeclaringType;

                var method = declaredType.GetMethod($"Set{PropertyName}");
                if (method != null)
                {
                    var par = method.GetParameters().FirstOrDefault();
                    if (par != null)
                    {
                        AttachedPropertyHostType = par.ParameterType;
                        AttachedPropertyHostTypeName = par.ParameterType.GetTypeDeclarationSourceCode();
                    }
                }
                // Cast the field value to the expected type (Dictionary<Type, AvaloniaPropertyMetadata>)
                //return fieldValue as Dictionary<Type, AvaloniaPropertyMetadata>;
            }
            catch
            {
                IsAttachedProperty = false;
            }
            //Debugger.Break();
        }
        CanBeGenericConstraint = !field.DeclaringType.IsSealed;

        ObsoleteMessage = field.GetCustomAttribute<ObsoleteAttribute>()?.Message;
    }
}