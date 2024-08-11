using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators.EventGenerators;

public abstract class EventGeneratorBase : IEventExtensionGenerator
{
    public ExtensionGeneratorConfig Config { get; set; } = null!;

    public string? GetEventExtension(EventInfo @event, out IEnumerable<string> usedNamespaces)
    {
        var namespaces = new HashSet<string>();
        var info = new EventExtensionInfo(@event, t => GetTypeDeclarationSourceCode(t, namespaces));

        if (!string.IsNullOrWhiteSpace(info.ControlType.Namespace))
            namespaces.Add(info.ControlType.Namespace);

        usedNamespaces = namespaces;

        var prefix = "";
        if (info.IsObsolete)
            prefix = $"\t[Obsolete(\"{info.ObsoleteMessage}\")]{Environment.NewLine}";

        return prefix + GetEventExtensionOverride(info);
    }

    public abstract string GetEventExtensionOverride(EventExtensionInfo info);

    public string GetTypeDeclarationSourceCode(Type valueType, HashSet<string> namespaces)
    {
        if (!string.IsNullOrWhiteSpace(valueType.Namespace))
            namespaces.Add(valueType.Namespace);

        var result = valueType.Name;

        if (valueType.IsGenericType)
        {
            result = result.Split('`')[0];
            var genericArguments = valueType.GetGenericArguments();
            var args = string.Join(",", genericArguments.Select(x => GetTypeDeclarationSourceCode(x, namespaces)));
            result += $"<{args}>";
        }

        var hasConflictingNamespace = namespaces.Any(x => x.EndsWith(result));

        //handle cases when Type is equal namespace name, i.e.
        //Avalonia.Controls.Calendar
        //ContextMenu
        //Animation
        //Dock

        if (hasConflictingNamespace)
        {
            result = valueType.Namespace + "." + result;
        }

        return result;
    }

}