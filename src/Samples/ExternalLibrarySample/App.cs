using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using ExternalLibrarySample;
using LiveChartsCore.SkiaSharpView.Avalonia;
using Microsoft.Extensions.DependencyInjection;

// Generates Extensions for Avalonia Controls
[assembly: GenerateMarkupForAssembly(typeof(CartesianChart))]

var services = new ServiceCollection();

var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

var sp = services.BuildServiceProvider();

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(b =>
    {
        b.Instance?.Styles.Add(new FluentTheme(sp));
        b.Instance?.Styles.Add(
            (IStyle)AvaloniaXamlLoader.Load(new Uri("avares://Avalonia.Controls.ColorPicker/Themes/Fluent/Fluent.xaml")));
    })
    .UseServiceProvider(sp)
    // uncomment the line below to enable rider ht reload workaround
    //.UseRiderHotReload()
    .SetupWithLifetime(lifetime);

lifetime.MainWindow = new Window()
    .Title("Avalonia External Library Sample")
    .Width(800)
    .Height(600)
    .Content(new ChartsComponent());

#if DEBUG
lifetime.MainWindow.AttachDevTools();
#endif

lifetime.Start(args);
