using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;

namespace CSharpUI.Avalonia.SourceGenerator.Generators.EventGenerators;

public class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string? GetExtension(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        //var eventParameterTypes = new List<string>() { "global::System.Object?" };

        var argsString = $"global::System.Action<{string.Join(", ", @event.EventParameterTypes)}> action";

        // Generate the lambda parameter names (arg0, arg1, etc.)
        var lambdaParameters = string.Join(", ", @event.EventParameterTypes.Select((type, index) => $"arg{index}"));

        // Generate the action call string
        var actionCallStr = $"action({lambdaParameters})";

        var extensionBody =
            $"        => control._setEvent(({eventHandler})(({lambdaParameters}) => {actionCallStr}), h => control.{@event.EventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", global::Avalonia.Interactivity.RoutingStrategies? routes = null";

            extensionBody =
                  $"{Extensions.NewLine}{{{Extensions.NewLine}"
                + $"        => control.AddHandler({@event.ControlTypeName}.{@event.EventName}Event, (_, args) => action(args), routes ?? default(RoutingStrategies));"
                + $"}}{Extensions.NewLine}";
        }

        var extensionText =
            $"    /// <summary>{@event.Comment}</summary>{Extensions.NewLine}" +
            (@event.IsObsolete ? "    [Obsolete]" + Extensions.NewLine : "") +
            $"    public static {@event.ReturnType} {"On" + @event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint}{Extensions.NewLine}" +
            extensionBody;

        return extensionText;
    }

}