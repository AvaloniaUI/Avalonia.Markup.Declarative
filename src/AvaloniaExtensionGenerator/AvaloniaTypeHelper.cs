using System.Reflection;
using Avalonia;

namespace AvaloniaExtensionGenerator;

public static class AvaloniaTypeHelper
{
    public static IEnumerable<Type> GetControlTypes(IConfig config)
    {
        var baseControlType = typeof(AvaloniaObject);

        if (config.TypesToProcess == null)
        {
            throw new NullReferenceException("List of types is not set");
        }

        var controlTypes = config.TypesToProcess
            .Where(p => IsAccepatbleControlType(p) && baseControlType.IsAssignableFrom(p))
            .ToList();

        controlTypes.AddRange(config.BaseTypes);

        return controlTypes.Distinct();
    }

    private static bool IsAccepatbleControlType(Type controlType)
    {
        if(!controlType.IsPublic)
            return false;
        if (controlType.IsGenericType)
            return false;
        if (controlType.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;
        return true;
    }

    public static void AddUsedNamespaces(IEnumerable<string> usedNamespaces, ref HashSet<string> namespaces)
    {
        foreach (var ns in usedNamespaces)
            namespaces.Add(ns);
    }


}