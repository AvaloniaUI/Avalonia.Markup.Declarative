using System.Diagnostics;
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

    public static bool IsAcceptableField(FieldInfo field)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;

        if (field.FieldType.Name.StartsWith("DirectProperty") ||
            field.FieldType.Name.StartsWith("StyledProperty") ||
            field.FieldType.Name.StartsWith("AttachedProperty") ||
            field.FieldType.Name.StartsWith("AvaloniaProperty"))
        {
            return !IsReadOnlyField(field);
        }
        return false;
    }

    public static bool IsAcceptableStyledField(FieldInfo field)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;

        if (field.FieldType.Name.StartsWith("StyledProperty"))
            return !IsReadOnlyField(field);
        
        return false;
    }

    public static bool IsReadOnlyField(FieldInfo field)
    {
        try
        {
            var controlType = field.DeclaringType;
            var extensionName = field.Name.Replace("Property", "");
            var propertyName = field.Name.Replace("Property", "");

            var propInfo = controlType?.GetProperty(propertyName);
            if (propInfo != null)
            {
                return propInfo.GetSetMethod() == null && propInfo.CanRead;
            }
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine("skipped");
        }
        return false;
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

    public static bool HasPublicTypesWithSameName(Type type)
    {
        if (type.Name == "DatePicker")
        {
            //Debugger.Break();
        }
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

        return assemblies
            .Where(assembly => type.Assembly != assembly)
            .Any(assembly => assembly.GetType(type.Name, false) != null);
    }

}