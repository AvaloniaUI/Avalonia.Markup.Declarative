using ReactiveSample.ViewModels;
using ReactiveSample.Views;
using ReactiveUI.Avalonia;

[assembly: GenerateMarkupExtensionsForAssembly(typeof(RoutedViewHost))] //external assembly extensions source generator support

var lifetime = new ClassicDesktopStyleApplicationLifetime
{
    Args = args,
    ShutdownMode = ShutdownMode.OnLastWindowClose
};

var appBuilder = AppBuilder.Configure<Application>()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .UsePlatformDetect()
    .UseReactiveUI(_ => { })
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
                            .Content(
                                new MainView()
                                    .DataContext(new MainViewModel())
                            );

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);