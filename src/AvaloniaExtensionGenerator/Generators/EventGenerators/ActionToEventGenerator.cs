namespace AvaloniaExtensionGenerator.Generators.EventGenerators;

public class ActionToEventGenerator : EventGeneratorBase
{
    public override string GetEventExtensionOverride(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        var eventParameterTypes = @event.EventParameterTypes;
        var argsString = $"Action<{string.Join(", ", eventParameterTypes)}> action";

        // Generate the lambda parameter names (arg0, arg1, etc.)
        var lambdaParameters = string.Join(", ", eventParameterTypes.Select((type, index) => $"arg{index}"));

        // Generate the action call string
        var actionCallStr = $"action({lambdaParameters})";

        // If the delegate has more than one parameter, split them into individual arguments
        if (@event.HasMultipleParameters)
        {
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((type, index) => $"arg{index}"));
        }
        else if (@event.HasSingleParameter)
        {
            lambdaParameters = "arg0";
        }
        else
        {
            lambdaParameters = "args";
        }

        if (@event.HasStandardSignature)
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes.Skip(1))}> action";
            actionCallStr = actionCallStr.Replace("arg0, ", "");
        }

        var eventName = @event.EventName;
        var extensionName = "On" + eventName;
        var controlTypeName = @event.ControlType.FullName;

        var extensionText =
            $"    public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString}) => {Environment.NewLine}"
            + $"        control._setEvent(({eventHandler}) (({lambdaParameters}) => {actionCallStr}), h => control.{eventName} += h);";

        if (@event.CanBeGenericConstraint)
        {
            extensionText =
                $"    public static T {extensionName}<T>"
                + $"(this T control, {argsString}) where T : {controlTypeName} => {Environment.NewLine}"
                + $"        control._setEvent(({eventHandler}) (({lambdaParameters}) => {actionCallStr}), h => control.{eventName} += h);";
        }

        return extensionText;
    }
}
