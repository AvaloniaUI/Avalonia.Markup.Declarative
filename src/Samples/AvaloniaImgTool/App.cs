using AvaloniaImgTool.GenerateImageFromText;
using AvaloniaImgTool.Services;
using Microsoft.Extensions.DependencyInjection;

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var services = new ServiceCollection();
services.AddSingleton<HuggingFaceService>();
services.AddSingleton(new SettingsService());
services.AddSingleton(new SaveFilePickerService(() => lifetime.MainWindow.StorageProvider));

FluentTheme GetFluentTheme() =>
    new(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
    { Mode = FluentThemeMode.Light };

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b => b.Instance?.Styles.Add(GetFluentTheme()))
    .UseServiceProvider(services.BuildServiceProvider())
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia Image tool app")
    .Content(new GenerateImageComponent());

lifetime.Start(args);