using Xunit;
using Avalonia.Headless;
using Avalonia.Platform;
using Avalonia.Themes.Simple;

[assembly: CollectionBehavior(DisableTestParallelization = true, MaxParallelThreads = 1)]

namespace Avalonia.Markup.Declarative.Tests;

public abstract class AvaloniaTestBase
{
    static AvaloniaTestBase()
    {
        if (Application.Current == null)
        {
            AppBuilder.Configure<Application>()
                .AfterSetup(b => b.Instance?.Styles.Add(new SimpleTheme()))
                .UseHeadless(new AvaloniaHeadlessPlatformOptions { UseHeadlessDrawing = true, FrameBufferFormat = PixelFormat.Bgra8888 })
                .SetupWithoutStarting();
        }
    }
}