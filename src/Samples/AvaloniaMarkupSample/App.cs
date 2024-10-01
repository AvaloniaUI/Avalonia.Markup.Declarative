using Avalonia.Platform;
using AvaloniaMarkupSample;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var appBuilder = AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
    .SetupWithLifetime(lifetime);

var icon = AssetLoader.Open( new Uri($"avares://AvaloniaMarkupSample/avalonia-logo.ico"));

var menu = new NativeMenu().Items(
    new NativeMenuItem()
        .Header("File")
        .Items(
            new NativeMenuItem()
                .Header("Open")
                .OnClick(OnOpenClick),

            new NativeMenuItemSeparator(),

            new NativeMenuItem()
                .Header("Close")
                .OnClick(_ => Environment.Exit(0))
        )
);

appBuilder.Instance?.TrayIcon_Icons(
    [
        new TrayIcon()
            .Icon(new WindowIcon(icon))
            .Menu(menu)
    ]
);

lifetime.MainWindow = new Window()
    .Title("Avalonia markup samples")
    .Content(new MainView())
    .NativeMenu_Menu(menu);

void OnOpenClick(EventArgs e)
{

}

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);