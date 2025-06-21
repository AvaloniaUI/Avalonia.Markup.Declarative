using Avalonia.Headless;
using Avalonia.Platform;

namespace Avalonia.Markup.Declarative.Tests;

public abstract class AvaloniaTestBase
{
    static AvaloniaTestBase()
    {
        if (Application.Current == null)
        {
            AppBuilder.Configure<Application>()
                .UseHeadless(new AvaloniaHeadlessPlatformOptions { UseHeadlessDrawing = true, FrameBufferFormat = PixelFormat.Bgra8888 })
                .SetupWithoutStarting();
        }
    }
}