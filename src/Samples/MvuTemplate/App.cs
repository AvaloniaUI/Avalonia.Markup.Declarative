using Microsoft.Extensions.DependencyInjection;
using MvuTemplate;

var services = new ServiceCollection();
services.AddSingleton<SampleDataService>();

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .UseServiceProvider(services.BuildServiceProvider())
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia MVU Template")
    .Content(new SimpleComponent());

lifetime.Start(args);

public class SampleDataService
{
    public string GetData() => "this text is from sample data service";
}