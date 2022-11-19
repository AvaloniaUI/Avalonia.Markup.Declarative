using Microsoft.Extensions.DependencyInjection;
using MvuTemplate;
using MvuTemplate.Views;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };
FluentTheme GetFluentTheme() =>
    new(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
        { Mode = FluentThemeMode.Light };

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(GetFluentTheme()))
    .SetupWithLifetime(lifetime);

var services = new ServiceCollection();

services.AddSingleton<SampleDataService>();

var serviceProvider = services.BuildServiceProvider();
Mvu.SetServiceProvider(serviceProvider);

lifetime.MainWindow = new MainWindow();
lifetime.Start(args);

public class MainWindow : Window
{
    public MainWindow() =>
        this.Title("Avalonia MVU Template")
            .Content(new MvuComponent());
}