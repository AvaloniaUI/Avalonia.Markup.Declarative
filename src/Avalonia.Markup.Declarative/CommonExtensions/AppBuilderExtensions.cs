using System;

namespace Avalonia.Markup.Declarative;

public static class AppBuilderExtensions
{
    private static IServiceProvider? _serviceProvider;
    internal static IServiceProvider? ServiceProvider => _serviceProvider;

    public static AppBuilder UseServiceProvider(this AppBuilder appBuilder, IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        return appBuilder;
    }

    public static AppBuilder UseHotReload(this AppBuilder appBuilder, bool enable = true)
    {
        if (enable)
        {
            HotReloadManager.Activate();
        }
        else
        {
            HotReloadManager.Deactivate();
        }
        return appBuilder;
    }

    public static AppBuilder UseRiderHotReload(this AppBuilder appBuilder, bool enable = true, int checkIntervalInMilliseconds = 2000)
    {
        if (enable)
        {
            HotReloadManager.ActivateRiderHotReload();
            HotReloadManager.SetRiderRiderCheckInterval(checkIntervalInMilliseconds);
        }
        else
        {
            HotReloadManager.DeactivateRiderHotReload();
        }

        return appBuilder;
    }


}