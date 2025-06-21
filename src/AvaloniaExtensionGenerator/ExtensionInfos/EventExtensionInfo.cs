using AvaloniaExtensionGenerator.Generators;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AvaloniaExtensionGenerator.ExtensionInfos;

public class EventExtensionInfo : IMemberExtensionInfo
{
    public string MemberName { get; }
    public EventInfo EventInfo { get; }
    public Type ControlType { get; }
    public string ControlTypeName { get; }

    public string EventHandler { get; }
    public string EventName { get; }
    public List<string> EventParameterTypes { get; } = new List<string>();
    public bool IsGeneric { get; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";

    public bool IsRoutedEvent { get; set; }
    public bool IsObsolete { get; set; }

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 && EventParameterTypes[0] == "System.Object" &&
        Regex.IsMatch(EventParameterTypes[1], @"\b\w*EventArgs(\<.*\>)?$");

    public bool HasSingleParameter => EventParameterTypes.Count == 1;
    public bool HasMultipleParameters => EventParameterTypes.Count > 1;


    public EventExtensionInfo(EventInfo eventInfo)
    {
        if (eventInfo.DeclaringType == null)
            throw new NullReferenceException("Control type cannot be NULL");

        if (eventInfo.EventHandlerType == null)
            throw new NullReferenceException("Event handler type cannot be NULL");

        EventInfo = eventInfo;
        ControlType = eventInfo.DeclaringType;
        ControlTypeName = ControlType.GetTypeDeclarationSourceCode();
        EventName = EventInfo.Name;
        MemberName = EventName;
        EventHandler = EventInfo.EventHandlerType.GetTypeDeclarationSourceCode();
        IsObsolete = EventInfo.GetCustomAttribute<ObsoleteAttribute>() != null;

        var methodInfo = eventInfo.EventHandlerType.GetMethod("Invoke");
        if (methodInfo != null)
        {
            var parameters = methodInfo.GetParameters();
            foreach (var parameter in parameters)
                EventParameterTypes.Add(parameter.ParameterType.GetTypeDeclarationSourceCode());

            if (HasRoutedEventArgs(parameters))
            {
                var routedEventFieldInfo = ControlType.GetField(EventName + "Event", BindingFlags.Static | BindingFlags.Public);
                IsRoutedEvent = routedEventFieldInfo != null; //if routed event field located in base class, ignore it and cout it classic event
            }

        }

        IsGeneric = !eventInfo.DeclaringType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }

    }

    private static bool HasRoutedEventArgs(ParameterInfo[] parameters)
    {
        return parameters.Any(x => IsRoutedEventArgType(x.ParameterType));

        bool IsRoutedEventArgType(Type? type)
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
