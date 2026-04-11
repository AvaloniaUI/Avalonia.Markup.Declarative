using Avalonia.Declarative.Template._1;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<SampleDataService>();

var lifetime = new ClassicDesktopStyleApplicationLifetime
{
    Args = args,
    ShutdownMode = ShutdownMode.OnLastWindowClose
};

var serviceProvider = services.BuildServiceProvider();

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(builder => builder.Instance?.Styles.Add(new FluentTheme()))
    .UseServiceProvider(serviceProvider)
    .UseComponentControlFactory(type => (Control)ActivatorUtilities.CreateInstance(serviceProvider, type))
    .UseViewInitializationStrategy(ViewInitializationStrategy.Lazy)
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia Declarative Component Template")
    .Width(800)
    .Height(600)
    .Content(ViewFactory.Create<MainView>());

lifetime.Start(args);

public sealed class SampleDataService
{
    public string GetData() => "this text is from sample data service";
}