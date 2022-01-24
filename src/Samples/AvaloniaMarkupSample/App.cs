//this line is required to support Net 6 hot reload for Views

using AvaloniaMarkupSample;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(Avalonia.Markup.Declarative.HotReloadManager))]

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