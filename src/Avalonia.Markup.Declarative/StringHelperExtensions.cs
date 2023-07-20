namespace Avalonia.Markup.Declarative;

public static class StringHelperExtensions
{
    public static Avalonia.Markup.Xaml.MarkupExtensions.DynamicResourceExtension GetDynamicResource(this string dynamcResourceKey) => new Avalonia.Markup.Xaml.MarkupExtensions.DynamicResourceExtension(dynamcResourceKey);
}