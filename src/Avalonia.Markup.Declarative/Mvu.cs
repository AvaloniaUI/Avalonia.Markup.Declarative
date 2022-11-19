using System;

namespace Avalonia.Markup.Declarative;

public class Mvu
{
    private static IServiceProvider _serviceProvider;
    internal static IServiceProvider ServiceProvider => _serviceProvider;

    public static void SetServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
}