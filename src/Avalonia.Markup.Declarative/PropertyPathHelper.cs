using System;

namespace Avalonia.Markup.Declarative;

public static class PropertyPathHelper
{
    public static string GetNameFromPropertyPath(string path)
    {
        if (path == null)
            return "";

        // if default value passed via ?? operator, remove it
        path = RemoveNullCoalescingOperator(path);

        //look for property name start position, skip it's parent declaration
        var propertyNameStartIndex = path.IndexOf('.', path.LastIndexOf(')') + 1) + 1;

        //getting property name and clean it from special symbols
        return path.Substring(propertyNameStartIndex)
            .Replace("?", "")
            .Trim('"', '@', ' ', '\t');
    }

    private static string RemoveNullCoalescingOperator(string path) =>
        !path.Contains("??") ? path : path.Substring(0, path.IndexOf("??", StringComparison.Ordinal));
}