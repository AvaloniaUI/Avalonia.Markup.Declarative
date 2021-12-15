using Avalonia.Media;

namespace Avalonia.Markup.Declarative;

public static class ColorExtensions
{
    public static Color ToColor(this string hexString)
    {
        return Color.Parse(hexString);
    }
}