using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Provides extension methods for configuring an <see cref="AppBuilder"/>.
/// </summary>
public static class AppBuilderExtensions
{
    private static IComponentControlFactory? _componentControlFactory;
    private static IServiceProvider? _serviceProvider;

    /// <summary>
    /// Gets the current <see cref="IServiceProvider"/> instance.
    /// </summary>
    internal static IServiceProvider? ServiceProvider => _serviceProvider;

    /// <summary>
    /// Gets the current <see cref="IComponentControlFactory"/> instance.
    /// </summary>
    internal static IComponentControlFactory? ComponentControlFactory => _componentControlFactory;

    /// <summary>
    /// Configures the <see cref="AppBuilder"/> to use the specified <see cref="IServiceProvider"/>.
    /// </summary>
    /// <param name="appBuilder">The <see cref="AppBuilder"/> to configure.</param>
    /// <param name="serviceProvider">The <see cref="IServiceProvider"/> to use.</param>
    /// <returns>The configured <see cref="AppBuilder"/>.</returns>
    public static AppBuilder UseServiceProvider(this AppBuilder appBuilder, IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        return appBuilder;
    }

    public static AppBuilder UseComponentControlFactory(this AppBuilder appBuilder, IComponentControlFactory componentControlFactory)
    {
        _componentControlFactory = componentControlFactory;
        return appBuilder;
    }

    /// <summary>
    /// Enables or disables hot reload functionality for the application.
    /// </summary>
    /// <param name="appBuilder">The <see cref="AppBuilder"/> to configure.</param>
    /// <param name="enable">A value indicating whether to enable hot reload. Defaults to <c>true</c>.</param>
    /// <returns>The configured <see cref="AppBuilder"/>.</returns>
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

    /// <summary>
    /// Enables or disables Rider-specific hot reload functionality for the application.
    /// </summary>
    /// <param name="appBuilder">The <see cref="AppBuilder"/> to configure.</param>
    /// <param name="enable">A value indicating whether to enable Rider hot reload. Defaults to <c>true</c>.</param>
    /// <param name="checkIntervalInMilliseconds">The interval, in milliseconds, at which to check for changes. Defaults to 2000 milliseconds.</param>
    /// <returns>The configured <see cref="AppBuilder"/>.</returns>
    [Obsolete("Latest rider does not need this hack to support hot-reload")]
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