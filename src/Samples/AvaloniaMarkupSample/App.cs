//this line is required to support Net 6 hot reload for Views

using AvaloniaMarkupSample;


AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop =>
    {
        desktop.MainWindow =
            new Window()
                .Title("Avalonia markup samples")
                .Content(new MainView());
    }, args);