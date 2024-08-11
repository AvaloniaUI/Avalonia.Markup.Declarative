using System.Reflection;

namespace AvaloniaExtensionGenerator;

public static class AvaloniaTypeHelper
{
    private static Type? _styledElementType;

    public static IEnumerable<Type> GetControlTypes(ExtensionGeneratorConfig config)
    {
        if (config.TypesToProcess == null)
            throw new NullReferenceException("List of types is not set");
        
        return config.TypesToProcess.Where(IsAcceptableControlType).Distinct();
    }

    private static bool IsAcceptableControlType(Type controlType)
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
    public static bool IsStyledElement(Type controlType)
    {
        _styledElementType ??= AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.ExportedTypes)
            .FirstOrDefault(x => x.FullName == "Avalonia.StyledElement");

        if (_styledElementType == null)
            throw new NullReferenceException("Styled element Type can't be loaded");

        return _styledElementType?.IsAssignableFrom(controlType) ?? false;
    }
    public static string GetAvaloniaObjectTypeName() => "Avalonia.AvaloniaObject";
}