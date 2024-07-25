namespace AvaloniaExtensionGenerator.Generators.EventGenerators;

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

        var extensionText =
            $"    public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString}) => {Environment.NewLine}"
            + $"        control._setEvent(({eventHandler}) ((_, args) => {actionCallStr}), h => control.{eventName} += h);";

        if (Config.BaseTypes.Contains(@event.ControlType))
        {
            extensionText =
                $"    public static T {extensionName}<T>"
                + $"(this T control, {argsString}) where T : {controlTypeName} => {Environment.NewLine}"
                + $"        control._setEvent(({eventHandler}) ((_, args) => {actionCallStr}), h => control.{eventName} += h);";
        }

        return extensionText;
    }
}