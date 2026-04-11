using Avalonia.Controls;
using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Provides extension methods for configuring an <see cref="AppBuilder"/>.
/// </summary>
public static class AppBuilderExtensions
{
    internal static Func<Type, Control>? ComponentControlFactory { get; private set; }
    private static IServiceProvider? _serviceProvider;
    private static ViewInitializationStrategy _defaultViewInitializationStrategy = ViewInitializationStrategy.Lazy;

    /// <summary>
    /// Gets the current <see cref="IServiceProvider"/> instance.
    /// </summary>
    internal static IServiceProvider? ServiceProvider => _serviceProvider;

    /// <summary>
    /// Gets the default <see cref="ViewInitializationStrategy"/> used by views when not explicitly specified.
    /// </summary>
    internal static ViewInitializationStrategy DefaultViewInitializationStrategy => _defaultViewInitializationStrategy;

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


    /// <summary>
    /// Configures the application to use a custom factory for creating component controls.
    /// </summary>
    /// <remarks>Use this method to provide a custom control creation strategy for components. This is useful
    /// when integrating with dependency injection or customizing control instantiation.</remarks>
    /// <param name="appBuilder">The application builder to configure.</param>
    /// <param name="factory">A delegate that creates a control instance for the specified component type. Cannot be null.</param>
    /// <returns>The configured application builder instance.</returns>
    public static AppBuilder UseComponentControlFactory(this AppBuilder appBuilder, Func<Type, Control> factory)
    {
        ComponentControlFactory = factory;
        return appBuilder;
    }

    /// <summary>
    /// Configures the default initialization strategy for views.
    /// </summary>
    /// <param name="appBuilder">The <see cref="AppBuilder"/> to configure.</param>
    /// <param name="strategy">The <see cref="ViewInitializationStrategy"/> to use as default for all views.</param>
    /// <returns>The configured <see cref="AppBuilder"/>.</returns>
    public static AppBuilder UseViewInitializationStrategy(this AppBuilder appBuilder, ViewInitializationStrategy strategy)
    {
        _defaultViewInitializationStrategy = strategy;
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
}