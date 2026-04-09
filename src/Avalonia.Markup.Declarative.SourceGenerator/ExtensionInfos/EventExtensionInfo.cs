#nullable enable

using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

internal sealed class EventExtensionInfo : IMemberExtensionInfo
{
    public string MemberName { get; }
    public string ControlTypeName { get; }
    public string EventHandler { get; }
    public string EventName { get; }
    public List<string> EventParameterTypes { get; } = [];
    public string ReturnType { get; }
    public string GenericConstraint { get; } = "";
    public string GenericArg { get; } = "";
    public bool IsRoutedEvent { get; }
    public bool IsObsolete { get; }

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 &&
        EventParameterTypes[0] == "global::System.Object?" &&
        EventParameterTypes[1].Contains("EventArgs", StringComparison.Ordinal);

    public EventExtensionInfo(IEventSymbol eventInfo)
    {
        ControlTypeName = eventInfo.ContainingType.GetFullTypeName();
        EventName = eventInfo.Name;
        MemberName = EventName;
        EventHandler = eventInfo.Type.GetFullTypeName();
        IsObsolete = eventInfo.IsObsolete();
        IsRoutedEvent = IsRoutedEventSymbol(eventInfo);

        if (!eventInfo.ContainingType.IsSealed)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
        else
        {
            ReturnType = ControlTypeName;
        }

        if (eventInfo.Type is INamedTypeSymbol delegateType && delegateType.DelegateInvokeMethod is { } invokeMethod)
        {
            foreach (var parameter in invokeMethod.Parameters)
            {
                EventParameterTypes.Add(parameter.Type.GetFullTypeName());
            }
        }
    }

    private static bool IsRoutedEventSymbol(IEventSymbol eventInfo)
    {
        if (eventInfo.Type is not INamedTypeSymbol delegateType || delegateType.DelegateInvokeMethod is not { } invokeMethod)
        {
            return false;
        }

        var hasRoutedArgs = invokeMethod.Parameters.Any(static x => x.Type.IsOrInheritsFrom("Avalonia.Interactivity.RoutedEventArgs"));
        if (!hasRoutedArgs)
        {
            return false;
        }

        return eventInfo.ContainingType.GetMembers($"{eventInfo.Name}Event")
            .OfType<IFieldSymbol>()
            .Any(static x => x.IsStatic && x.DeclaredAccessibility == Accessibility.Public);
    }
}
