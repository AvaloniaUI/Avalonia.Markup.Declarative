using AvaloniaExtensionGenerator.Generators;
using System.Reflection;

namespace AvaloniaExtensionGenerator.ExtensionInfos;
public class PropertyExtensionInfo : IMemberExtensionInfo
{
    public FieldInfo FieldInfo { get; }
    public Type ControlType { get; }
    public string ControlTypeName { get; }
    public string ExtensionName { get; protected set; }
    public string MemberName { get; }
    public Type ValueType { get; }
    public object ValueTypeSource { get; }
    public bool IsGeneric { get; }
    public bool IsAttachedProperty { get; set; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";


    public PropertyExtensionInfo(FieldInfo field)
    {
        FieldInfo = field;
        ControlType = field.DeclaringType ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.Name.Replace("Property", "");
        MemberName = field.Name.Replace("Property", "");
        ValueType = field.FieldType.GetGenericArguments().Last();
        ControlTypeName = ControlType.GetTypeDeclarationSourceCode();
        ValueTypeSource = ValueType.GetTypeDeclarationSourceCode();

        IsAttachedProperty = field.FieldType.Name.StartsWith("AttachedProperty");
        IsGeneric = !field.DeclaringType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
    }

    public static IMemberExtensionInfo Create(FieldInfo fieldInfo)
    {
        return new PropertyExtensionInfo(fieldInfo);
    }
}