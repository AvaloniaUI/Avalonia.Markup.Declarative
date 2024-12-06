using Avalonia.Markup.Declarative.SourceGenerator;
using AvaloniaExtensionGenerator.Generators;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace AvaloniaExtensionGenerator.ExtensionInfos;

public class EventExtensionInfo : IMemberExtensionInfo
{
    public string MemberName { get; }
    public IEventSymbol EventInfo { get; }
    public ITypeSymbol ControlType { get; }
    public string ControlTypeName { get; }

    public string EventHandler { get; }
    public string EventName { get; }
    public List<string> EventParameterTypes { get; } = new List<string>();
    public bool IsGeneric { get; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";

    public bool IsRoutedEvent { get; set; }

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 && EventParameterTypes[0] == "System.Object" &&
        EventParameterTypes[1].EndsWith("EventArgs");

    public bool HasSingleParameter => EventParameterTypes.Count == 1;
    public bool HasMultipleParameters => EventParameterTypes.Count > 1;


    public EventExtensionInfo(IEventSymbol eventInfo)
    {
        if (eventInfo.ContainingType == null)
            throw new NullReferenceException("Control type cannot be NULL");

        if (eventInfo.Type == null)
            throw new NullReferenceException("Event handler type cannot be NULL");

        EventInfo = eventInfo;
        ControlType = eventInfo.ContainingType;
        ControlTypeName = ControlType.ToString();
        EventName = EventInfo.Name;
        MemberName = EventName;
        EventHandler = EventInfo.Type.ToString();

        var methodInfo = eventInfo.Type.GetMembers("Invoke").FirstOrDefault();
        if (methodInfo is IMethodSymbol method)
        {
            var parameters = method.Parameters;
            foreach (var parameter in parameters)
                EventParameterTypes.Add(parameter.Type.ToString());

            if (HasRoutedEventArgs(parameters))
            {
                var routedEventFieldInfo = ControlType.GetMembers(EventName + "Event").First(x => x.IsStatic && x.DeclaredAccessibility == Accessibility.Public);
                IsRoutedEvent = routedEventFieldInfo != null; //if routed event field located in base class, ignore it and count it classic event
            }

        }

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

        bool IsRoutedEventArgType(ITypeSymbol? type)
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
