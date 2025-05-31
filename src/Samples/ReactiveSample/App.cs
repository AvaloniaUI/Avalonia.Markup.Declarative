using ReactiveSample.Views;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var appBuilder = AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia Reactive Sample")
    .Content(new MainView());

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);