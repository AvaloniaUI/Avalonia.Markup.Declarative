using AvaloniaExtensionGenerator.Generators;
using System.Reflection;

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

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 && EventParameterTypes[0] == "System.Object" &&
        EventParameterTypes[1].EndsWith("EventArgs");

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

        var methodInfo = eventInfo.EventHandlerType.GetMethod("Invoke");
        if (methodInfo != null)
        {
            foreach (var parameter in methodInfo.GetParameters())
            {
                EventParameterTypes.Add(parameter.ParameterType.GetTypeDeclarationSourceCode());
                if(parameter.ParameterType.BaseType?.Name == "RoutedEventArgs")
                    IsRoutedEvent = true;
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

}
