using System.Reflection;
using Avalonia;

namespace AvaloniaExtensionGenerator;

public static class AvaloniaTypeHelper
{
    public static IEnumerable<Type> GetControlTypes(Config config)
    {
        var baseControlType = typeof(AvaloniaObject);
        var controlTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => IsAccepatbleControlType(p) && baseControlType.IsAssignableFrom(p))
            .ToList();

        controlTypes.AddRange(config.BaseTypes);

        return controlTypes.Distinct();
    }

    private static bool IsAccepatbleControlType(Type controlType)
    {
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