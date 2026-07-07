using Avalonia.Platform;
using AvaloniaMarkupSample;
#if DEBUG
using Declarative.Avalonia.AgentTools;
#endif

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var appBuilder = AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b =>
    {
        b.Instance?.Styles.Add(new FluentTheme());

#if DEBUG
        b.Instance?.AttachDeveloperTools();
#endif
    })
#if DEBUG
    // Dev-only: exposes the running app to an AI agent over loopback MCP. See docs/agent-tools.md.
    // EnableInteraction turns on the tier-2 'invoke' remote-control tool (click/select/set/keys etc).
    // It is OFF by default in the package; this sample opts in deliberately so the interaction tools
    // can be exercised end-to-end. Loopback-only and Debug-only, with a startup warning printed.
    .UseAgentInspector(o => o.EnableInteraction = true)
#endif
    .SetupWithLifetime(lifetime);

var icon = AssetLoader.Open(new Uri($"avares://AvaloniaMarkupSample/avalonia-logo.ico"));

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

const string baseTitle = "Avalonia markup samples";
var mainWindow = new Window()
    .Title(baseTitle)
    .Content(new MainView())
    .NativeMenu_Menu(menu);
lifetime.MainWindow = mainWindow;

#if DEBUG
// Dev-only: reflect the agent connection status in the window title, the way Chrome shows a
// "DevTools is connected" indicator. Events are raised on the UI thread, so we can set Title directly.
AgentConnectionMonitor.StatusChanged += (_, e) =>
    mainWindow.Title = e.IsConnected ? $"🟢 Agent connected — {baseTitle}" : baseTitle;
#endif

void OnOpenClick(EventArgs e)
{

}
lifetime.Start(args);