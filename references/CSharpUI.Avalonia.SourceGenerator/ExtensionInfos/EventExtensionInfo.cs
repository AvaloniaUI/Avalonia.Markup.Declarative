using CSharpUI.Avalonia.SourceGenerator.Generators;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;

public class EventExtensionInfo : IMemberExtensionInfo
{
    public string MemberName { get; }
    public IEventSymbol EventInfo { get; }
    public ITypeSymbol ControlType { get; }
    public string ControlTypeName { get; }

    public string EventHandler { get; }
    public string EventName { get; }
    public List<string> EventParameterTypes { get; } = [];
    public bool IsGeneric { get; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";
    public string? Comment { get; set; }


    public bool IsRoutedEvent { get; set; }
    public bool IsObsolete { get; set; }

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 && EventParameterTypes[0] == "System.Object" &&
        EventParameterTypes[1].EndsWith("EventArgs");

    public bool HasSingleParameter => EventParameterTypes.Count == 0;
    public bool HasMultipleParameters => EventParameterTypes.Count > 0;

    public EventExtensionInfo(IEventSymbol eventInfo)
    {
        if (eventInfo.ContainingType == null)
            throw new NullReferenceException("Control type cannot be NULL");

        if (eventInfo.Type == null)
            throw new NullReferenceException("Event handler type cannot be NULL");

        EventInfo = eventInfo;
        ControlType = eventInfo.ContainingType;
        ControlTypeName = ControlType.GetFullTypeName();
        EventName = EventInfo.Name;
        MemberName = EventName;
        EventHandler = eventInfo.Type.GetFullTypeName();

        if (EventHandler.StartsWith("EventHandler"))
        {
            EventHandler = "global::System." + EventHandler;
        }

        EventParameterTypes.Add("global::System.Object?");

        var eventArgType = eventInfo.Type;

        if (eventArgType.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T && eventInfo.Type is INamedTypeSymbol nts)
        {
            var t = nts.TypeArguments[0];

            eventArgType = t;
        }

        if (eventArgType is INamedTypeSymbol nts2)
        {
            if (nts2.IsGenericType)
            {
                EventParameterTypes.Add(nts2.TypeArguments[0].GetFullTypeName());
            }
            else
            {
                EventParameterTypes.Add("global::System.EventArgs");
            }
        }

        IsObsolete = EventInfo.GetAttributes().Any(a => a.AttributeClass?.Name == nameof(ObsoleteAttribute));
        IsGeneric = !eventInfo.ContainingType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
    }

    private static bool HasRoutedEventArgs(ImmutableArray<IParameterSymbol> parameters)
    {
        return parameters.Any(x => IsRoutedEventArgType(x.Type));

        static bool IsRoutedEventArgType(ITypeSymbol? type)
        {
            while (type != null)
            {
                if (type.Name == "RoutedEventArgs")
                    return true;

                type = type.BaseType;
            }
            return false;
        }
    }
}