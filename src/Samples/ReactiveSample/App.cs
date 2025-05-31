using Avalonia.ReactiveUI;
using ReactiveSample.ViewModels;
using ReactiveSample.Views;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var appBuilder = AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .UseReactiveUI()
    .SetupWithLifetime(lifetime); // This has to run last

lifetime.MainWindow = new Window
{
    Content = new MainView()
                .DataContext(new MainViewModel())
};

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);