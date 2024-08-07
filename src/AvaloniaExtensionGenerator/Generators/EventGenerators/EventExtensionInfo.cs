using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators.EventGenerators;

public class EventExtensionInfo
{
    public EventInfo EventInfo { get; }

    public Type ControlType { get; }

    public string EventHandler { get; }

    public string EventName { get; }

    public string EventArguments { get; }
    public string? ObsoleteMessage { get; } = null;
    public bool IsObsolete => ObsoleteMessage != null;
    public EventExtensionInfo(EventInfo eventInfo, Func<Type, string> TypeDeclarationFunc)
    {
        if (eventInfo.DeclaringType == null)
            throw new NullReferenceException("Control type can not be NULL");

        if (eventInfo.EventHandlerType == null)
            throw new NullReferenceException("Event handler type can not be NULL");


        EventInfo = eventInfo;
        ControlType = eventInfo.DeclaringType;
        EventName = EventInfo.Name;
        EventHandler = TypeDeclarationFunc(EventInfo.EventHandlerType);
        EventArguments = string.Join(",", EventInfo.EventHandlerType.GenericTypeArguments.Select(x => x.Name));
        ObsoleteMessage = eventInfo.GetCustomAttribute<ObsoleteAttribute>()?.Message;
    }
}