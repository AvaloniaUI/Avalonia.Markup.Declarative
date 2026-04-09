#nullable enable

using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

internal class PropertyExtensionInfo : IMemberExtensionInfo
{
    public IFieldSymbol FieldSymbol { get; }
    public INamedTypeSymbol ControlType { get; }
    public string ControlTypeName { get; }
    public string ExtensionName { get; protected set; }
    public string MemberName { get; }
    public ITypeSymbol ValueType { get; }
    public string ValueTypeSource { get; }
    public bool IsGeneric { get; }
    public string ReturnType { get; protected set; }
    public string GenericConstraint { get; protected set; } = "";
    public string GenericArg { get; protected set; } = "";

    public PropertyExtensionInfo(IFieldSymbol field)
    {
        FieldSymbol = field;
        ControlType = field.ContainingType ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.GetMemberName();
        MemberName = field.GetMemberName();
        ValueType = field.Type.GetLastGenericArgument();
        ControlTypeName = ControlType.GetFullTypeName();
        ValueTypeSource = ValueType.GetFullTypeName();

        IsGeneric = !ControlType.IsSealed;
        ReturnType = ControlTypeName;

        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
    }
}
