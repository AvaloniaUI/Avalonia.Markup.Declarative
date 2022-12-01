using System.Reflection;

namespace AvaloniaExtensionGenerator.EventGenerators;

public class EventExtensionInfo
{
    public EventInfo EventInfo { get; }

    public Type ControlType { get; set; }

    public string EventHandler { get; set; }

    public string EventName { get; set; }

    public string EventArguments { get; set; }

    public EventExtensionInfo(EventInfo eventInfo, Func<Type, string> TypeDeclarationFunc)
    {
        EventInfo = eventInfo;
        ControlType = eventInfo.DeclaringType;
        EventName = EventInfo.Name;
        EventHandler = TypeDeclarationFunc(EventInfo.EventHandlerType);
        EventArguments = string.Join(",", EventInfo.EventHandlerType.GenericTypeArguments.Select(x => x.Name));
    }
}