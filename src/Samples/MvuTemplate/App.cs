using Microsoft.Extensions.DependencyInjection;
using MvuTemplate;
using System.Diagnostics.CodeAnalysis;

var services = new ServiceCollection();
services.AddSingleton<SampleDataService>();

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var serviceProvider = services.BuildServiceProvider();

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .UseServiceProvider(serviceProvider)
    .UseComponentControlFactory(new ControlFactory(serviceProvider))
    .UseViewInitializationStrategy(ViewInitializationStrategy.Lazy) //optional: set view initialization strategy
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia MVU Template")
    .Width(800)
    .Height(600)
    .Content(new MainView());

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);

public class SampleDataService
{
    public string GetData() => "this text is from sample data service";
}

// This is a factory class that create controls and injects services into them
public class ControlFactory(IServiceProvider serviceProvider) : IComponentControlFactory
{
    public TControl CreateControlInstance<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TControl>() 
        where TControl : Control => ActivatorUtilities.CreateInstance<TControl>(serviceProvider);
}