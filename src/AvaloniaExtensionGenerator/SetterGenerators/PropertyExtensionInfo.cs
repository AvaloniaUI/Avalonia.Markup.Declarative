using System.Reflection;

namespace AvaloniaExtensionGenerator.SetterGenerators;

public class PropertyExtensionInfo
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

    public PropertyExtensionInfo(FieldInfo field, Func<Type, string> TypeDeclarationFunc)
    {
        FieldInfo = field;
        ControlType = field.DeclaringType;
        ExtensionName = field.Name.Replace("Property", "");
        PropertyName = field.Name.Replace("Property", "");
        ValueType = field.FieldType.GetGenericArguments().Last();
        ControlTypeName = TypeDeclarationFunc(ControlType);
        ValueTypeSource = TypeDeclarationFunc(ValueType);

        ObsoleteMessage = field.GetCustomAttribute<ObsoleteAttribute>()?.Message;
    }
}