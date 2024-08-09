using System;

namespace Avalonia.Markup.Declarative;

internal static class PropertyPathHelper
{
    private static readonly char[] StopChars = [' ', '?', ',', '\"', '@', '\t', '\n'];
    public static string GetNameFromPropertyPath(string? path)
    {
        if (path == null)
            return "";

        var propFound = false;

        //found closing bracket - ignore all characters that was before
        var startIndex = Math.Max(0,path.LastIndexOf(')'));

        for (var i = startIndex; i < path.Length; i++)
        {
            var curChar = path[i];

            //found special characters after property name, ie: @vm.Property ?? 0
            if (propFound && Array.IndexOf(StopChars, curChar) > -1)
                return path.Substring(startIndex, i - startIndex);
          
            if (!propFound && curChar == '.')
            {
                //found start of property name
                startIndex = ++i;
                propFound = true;
            }
        }

        //no special characters - just property name, ie: vm.Property
        if (propFound)
            return path.Substring(startIndex);

        //no parent object, ie: TextProperty
        return path.TrimStart('@');
    }
}