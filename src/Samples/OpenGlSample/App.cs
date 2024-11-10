using Microsoft.Extensions.DependencyInjection;
using OpenGlSample;

var services = new ServiceCollection();

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .UseServiceProvider(services.BuildServiceProvider())
    // uncomment the line below to enable rider ht reload workaround
    //.UseRiderHotReload()
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia MVU Template")
    .Width(800)
    .Height(600)
    .Content(new OpenGlView());

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);