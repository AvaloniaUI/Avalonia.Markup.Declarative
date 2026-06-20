using Avalonia;
using Avalonia.Headless;
using Avalonia.Markup.Declarative.Diagnostics.Tests;
using Avalonia.Platform;
using Avalonia.Themes.Simple;

[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

namespace Avalonia.Markup.Declarative.Diagnostics.Tests;

/// <summary>
/// Headless app bootstrap using the real Skia rendering backend so <c>RenderTargetBitmap</c> produces
/// valid PNGs in tests. Each <c>[AvaloniaFact]</c> runs on the Avalonia UI thread.
/// </summary>
public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<Application>()
            .UseSkia()
            .UseHeadless(new AvaloniaHeadlessPlatformOptions
            {
                UseHeadlessDrawing = false,
                FrameBufferFormat = PixelFormat.Bgra8888
            })
            .AfterSetup(b => b.Instance?.Styles.Add(new SimpleTheme()));
}
