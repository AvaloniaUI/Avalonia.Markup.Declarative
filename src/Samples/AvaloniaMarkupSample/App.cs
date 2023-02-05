using AvaloniaMarkupSample;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .SetupWithLifetime(lifetime);


lifetime.MainWindow = new Window()
    .Title("Avalonia markup samples")
    .Content(new MainView());

#if DEBUG
    lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);