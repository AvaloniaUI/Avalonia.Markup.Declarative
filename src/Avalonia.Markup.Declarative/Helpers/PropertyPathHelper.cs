using System;
using System.Linq;

namespace Avalonia.Markup.Declarative.Helpers;

internal static class PropertyPathHelper
{
    private static readonly char[] StopChars = [' ', '?', ',', '\"', '@', '\t', '\n', ')', '(', '=', '>', '<', '+', '-', '*', '/', '!', '&', '|'];
    
    public static string GetNameFromPropertyPath(string? path)
    {
        if (path == null)
            return "";

        path = path.Trim();
        
        if (string.IsNullOrEmpty(path))
            return "";

        // Handle lambda expressions: "() => PropertyName" or "() => PropertyName.SubProperty"
        if (path.Contains("=>"))
        {
            // Extract the part after =>
            var arrowIndex = path.LastIndexOf("=>");
            if (arrowIndex != -1)
            {
                var afterArrow = path.Substring(arrowIndex + 2).Trim();
                
                // Recursively process the part after =>
                return GetNameFromPropertyPath(afterArrow);
            }
        }

        var propFound = false;
        var startIndex = 0;

        // Find the last closing bracket - ignore all characters before it
        var lastClosingBracket = path.LastIndexOf(')');
        if (lastClosingBracket != -1)
        {
            startIndex = lastClosingBracket + 1;
        }

        for (var i = startIndex; i < path.Length; i++)
        {
            var curChar = path[i];

            // Skip leading whitespace
            if (!propFound && curChar == ' ')
                continue;

            // Found special characters after property name, ie: @vm.Property ?? 0
            if (propFound && Array.IndexOf(StopChars, curChar) > -1)
                return path.Substring(startIndex, i - startIndex).Trim();
          
            if (!propFound && curChar == '.')
            {
                // Found start of property name
                startIndex = i + 1;
                propFound = true;
            }
        }

        // No special characters - just property name, ie: vm.Property
        if (propFound)
            return path.Substring(startIndex).Trim();

        // No parent object, ie: TextProperty or plain property name
        return path.TrimStart('@').Trim();
    }
}