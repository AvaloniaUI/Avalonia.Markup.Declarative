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

        if (field.AssociatedSymbol != null)
        {
            ExtensionName = field.AssociatedSymbol.Name.Replace("Property", "");
            MemberName = field.AssociatedSymbol.Name.Replace("Property", "");
        }

        ValueType = field.Type;
        ControlTypeName = ControlType.ToString();

        var t = field.Type as INamedTypeSymbol;

        var type = t.TypeArguments.LastOrDefault();

        if (type == null)
        {
            type = t;
        }

        ValueTypeSource = type.ToString();

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