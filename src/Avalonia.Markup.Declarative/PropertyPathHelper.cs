namespace Avalonia.Markup.Declarative;

public static class PropertyPathHelper
{
    public static string GetPropertyName(string path)
    {
        if (path == null)
            return "";

        var p = path;

        if (p.Contains("??"))
        {
            var index = p.IndexOf("??");
            p = p.Substring(0, index);
        }
        int startIndex = p.IndexOf('.', p.LastIndexOf(')') + 1) + 1;
        return p.Substring(startIndex).Replace("?", "").Trim('"', '@', ' ', '\t');
    }

}