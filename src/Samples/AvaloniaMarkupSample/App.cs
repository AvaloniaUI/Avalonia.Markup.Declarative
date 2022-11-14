using AvaloniaMarkupSample;

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop =>
    {
        desktop.MainWindow = new Window()
                .Title("Avalonia markup samples")
                .Content(new MainView());
    }, args);