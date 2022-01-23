namespace AvaloniaExtensionGenerator;

public class ActionToEventGenerator : EventGeneratorBase
{
    public override string GetEventExtensionOverride(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        var eventArgsType = @event.EventArguments;
        var argsString = $"Action<{eventArgsType}> action";

        var actionCallStr = "action(args)";

        if (string.IsNullOrWhiteSpace(eventArgsType))
        {
            argsString = $"Action action";
            eventArgsType = "EventArgs";
            actionCallStr = "action()";
        }

        var eventName = @event.EventName;
        var extensionName = "On" + eventName;
        var controlTypeName = @event.ControlType.Name;
        var nl = Environment.NewLine;
        
        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString}) {{{nl}"
            + $"void Handler(object sender, {eventArgsType} args) => {actionCallStr};{nl}"
            + $"return control._setEvent(({eventHandler}) Handler, h => control.{eventName} += h, h => control.{eventName} -= h);{nl}"
            + "}";

        return extensionText;
    }
}