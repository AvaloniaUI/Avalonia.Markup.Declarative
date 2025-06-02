using AvaloniaExtensionGenerator.ExtensionInfos;

namespace AvaloniaExtensionGenerator.Generators.EventGenerators;

public class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string? GetExtension(EventExtensionInfo @event)
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

        var extensionBody =
            $" =>{Environment.NewLine} control._setEvent(({eventHandler}) (({lambdaParameters}) => {actionCallStr}), h => control.{eventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", Avalonia.Interactivity.RoutingStrategies? routes = null";

            extensionBody = Environment.NewLine + "{" + Environment.NewLine +
                            $"  control.AddHandler({@event.ControlTypeName}.{@eventName}Event, (_, args) => action(args), routes ?? {@event.ControlTypeName}.{@eventName}Event.RoutingStrategies);" + Environment.NewLine +
                            "  return control;" + Environment.NewLine +
                            "}" + Environment.NewLine;
        }


        var extensionText =
            (@event.IsObsolete ? "[Obsolete]" : "")
            + $"public static {@event.ReturnType} {extensionName}{@event.GenericArg}"
            + $"(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint} "
            + extensionBody;

        return extensionText;
    }

}
