using Microsoft.Extensions.DependencyInjection;
using MvuTemplate;

var services = new ServiceCollection();
services.AddSingleton<SampleDataService>();

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
    .Content(new SimpleComponent());

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);

public class SampleDataService
{
    public string GetData() => "this text is from sample data service";
}