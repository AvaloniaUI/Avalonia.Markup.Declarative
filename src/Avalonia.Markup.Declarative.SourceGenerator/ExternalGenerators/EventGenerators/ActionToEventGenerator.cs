using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.EventGenerators;

internal sealed class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string GetExtension(EventExtensionInfo @event)
    {
        if (!@event.ReturnsVoid)
        {
            return
                (@event.IsObsolete ? "[Obsolete]" + SymbolUtilities.NewLine : string.Empty) +
                $"public static {@event.ReturnType} On{@event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {@event.EventHandler} handler) {@event.GenericConstraint} " +
                $"=> {SymbolUtilities.NewLine} control._setEvent(handler, h => control.{@event.EventName} += h);";
        }

        var eventParameterTypes = @event.EventParameterTypes;
        string argsString;
        string lambdaParameters;
        string actionCall;

        if (eventParameterTypes.Count == 0)
        {
            argsString = "Action action";
            lambdaParameters = string.Empty;
            actionCall = "action()";
        }
        else if (@event.HasStandardSignature)
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes.Skip(1))}> action";
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((_, index) => $"arg{index}"));
            actionCall = "action(arg1)";
        }
        else if (eventParameterTypes.Count == 1)
        {
            argsString = $"Action<{eventParameterTypes[0]}> action";
            lambdaParameters = "arg0";
            actionCall = "action(arg0)";
        }
        else
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes)}> action";
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((_, index) => $"arg{index}"));
            actionCall = $"action({lambdaParameters})";
        }

        var extensionBody =
            $" => {SymbolUtilities.NewLine} control._setEvent(({@event.EventHandler}) (({lambdaParameters}) => {actionCall}), h => control.{@event.EventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", Avalonia.Interactivity.RoutingStrategies? routes = null";
            extensionBody =
                SymbolUtilities.NewLine + "{" + SymbolUtilities.NewLine +
                $"  control.AddHandler({@event.ControlTypeName}.{@event.EventName}Event, (_, args) => action(args), routes ?? {@event.ControlTypeName}.{@event.EventName}Event.RoutingStrategies);" + SymbolUtilities.NewLine +
                "  return control;" + SymbolUtilities.NewLine +
                "}" + SymbolUtilities.NewLine;
        }

        return
            (@event.IsObsolete ? "[Obsolete]" + SymbolUtilities.NewLine : string.Empty) +
            $"public static {@event.ReturnType} On{@event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint} " +
            extensionBody;
    }
}
