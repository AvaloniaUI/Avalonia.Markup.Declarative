using Avalonia;
using Avalonia.Headless;
using Avalonia.Platform;
using Avalonia.Themes.Simple;
using Declarative.Avalonia.AgentTools.Tests;

[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

namespace Declarative.Avalonia.AgentTools.Tests;

/// <summary>
/// Headless app bootstrap using the real Skia rendering backend so <c>RenderTargetBitmap</c> produces
/// valid PNGs and the platform input sink routes synthesized input exactly as a real windowing backend
/// would. Each <c>[AvaloniaFact]</c> runs on the Avalonia UI thread.
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
