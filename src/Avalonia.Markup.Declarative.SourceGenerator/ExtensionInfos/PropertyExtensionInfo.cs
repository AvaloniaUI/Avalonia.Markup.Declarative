using Avalonia.Markup.Declarative.SourceGenerator;
using AvaloniaExtensionGenerator.Generators;
using Microsoft.CodeAnalysis;

namespace AvaloniaExtensionGenerator.ExtensionInfos;
public class PropertyExtensionInfo : IMemberExtensionInfo
{
    public IFieldSymbol FieldInfo { get; }
    public ITypeSymbol ControlType { get; }
    public string ControlTypeName { get; }
    public string ExtensionName { get; protected set; }
    public string MemberName { get; }
    public ITypeSymbol ValueType { get; }
    public object ValueTypeSource { get; }
    public bool IsGeneric { get; }
    public bool IsAttachedProperty { get; set; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";


    public PropertyExtensionInfo(IFieldSymbol field)
    {
        FieldInfo = field;
        ControlType = field.ContainingType ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.Name.Replace("Property", "");
        MemberName = field.Name.Replace("Property", "");
        ValueType = field.Type;
        ControlTypeName = $"{ControlType.GetFullNamespace()}.{ControlType.Name}".TrimStart('.');

        var type = (field.Type as INamedTypeSymbol).TypeArguments[1];

        ValueTypeSource = $"{type.GetFullNamespace()}.{type.Name}".TrimStart('.');

        IsAttachedProperty = field.Type.Name.StartsWith("AttachedProperty");
        IsGeneric = !field.Type.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
    }

    public static IMemberExtensionInfo Create(IFieldSymbol fieldInfo)
    {
        return new PropertyExtensionInfo(fieldInfo);
    }
}