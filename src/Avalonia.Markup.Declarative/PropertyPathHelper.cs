namespace Avalonia.Markup.Declarative;

public static class PropertyPathHelper
{
    public static string GetPropertyName(string path)
    {
        if (path == null)
            return "";
        int startIndex = path.IndexOf('.', path.LastIndexOf(')') + 1) + 1;
        return path.Substring(startIndex).Replace("?", "").Trim('"', '@', ' ', '\t');
    }

}