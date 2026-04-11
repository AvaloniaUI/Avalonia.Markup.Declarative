using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.EventGenerators;

internal sealed class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string GetExtension(EventExtensionInfo @event)
    {
        var obsolete = @event.IsObsolete ? "[Obsolete]" + SymbolUtilities.NewLine : string.Empty;
        var documentation = @event.XmlDoc;

        // events with non-void return types are not supported by the standard EventHandler pattern, so we generate a simple extension method that adds the handler and returns the control for chaining.
        if (!@event.ReturnsVoid)
        {
            return $"{documentation}{obsolete}public static {@event.ReturnType} On{@event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {@event.EventHandler} handler) {@event.GenericConstraint}\n" +
                   $"{{\n" +
                   $"    control.{@event.EventName} += handler;\n" +
                   $"    return control;\n" +
                   $"}}\n";
        }

        var eventParameterTypes = @event.EventParameterTypes;
        string argsString;
        string lambdaParameters;
        string actionCall;

        // check for common event signatures to simplify the generated code and avoid unnecessary parameters in the lambda.
        // For example, if the event has a standard signature (object sender, EventArgs e), we can generate an Action<EventArgs> instead of Action<object, EventArgs>.
        if (eventParameterTypes.Count == 0)
        {
            argsString = "Action action";
            lambdaParameters = string.Empty;
            actionCall = "action()";
        }
        else if (@event.HasStandardSignature) // (object sender, EventArgs e)
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes.Skip(1))}> action";
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((_, index) => $"arg{index}"));
            actionCall = "action(arg1)"; // pass only EventArgs
        }
        else if (eventParameterTypes.Count == 1) // (T arg)
        {
            argsString = $"Action<{eventParameterTypes[0]}> action";
            lambdaParameters = "arg0";
            actionCall = "action(arg0)";
        }
        else // Arbitrary signature
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes)}> action";
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((_, index) => $"arg{index}"));
            actionCall = $"action({lambdaParameters})";
        }

        // 2. RoutedEvents (Avalonia routing events)
        if (@event.IsRoutedEvent)
        {
            return $"{documentation}{obsolete}public static {@event.ReturnType} On{@event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {argsString}, Avalonia.Interactivity.RoutingStrategies? routes = null) {@event.GenericConstraint}\n" +
                   $"{{\n" +
                   $"    control.AddHandler({@event.ControlTypeName}.{@event.EventName}Event, ({lambdaParameters}) => {actionCall}, routes ?? {@event.ControlTypeName}.{@event.EventName}Event.RoutingStrategies);\n" +
                   $"    return control;\n" +
                   $"}}\n";
        }

        // 3. Regular .NET events (create lambda directly)
        return $"{documentation}{obsolete}public static {@event.ReturnType} On{@event.EventName}{@event.GenericArg}(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint}\n" +
               $"{{\n" +
               $"    control.{@event.EventName} += ({lambdaParameters}) => {actionCall};\n" +
               $"    return control;\n" +
               $"}}\n";
    }
}