using MvuTemplate.Views;

var builder = AppBuilder.Configure<Application>();
builder.UsePlatformDetect();

//use fluent light theme
builder.AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}")) { Mode = FluentThemeMode.Light }));

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };
builder.SetupWithLifetime(lifetime);
lifetime.MainWindow = new MainWindow();
lifetime.Start(args);

public class MainWindow : Window
{
    public MainWindow() =>
        this.Title("Avalonia MVU Template")
            .Content(new MvuComponent());
}