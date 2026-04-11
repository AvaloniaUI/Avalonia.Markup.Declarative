using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class ViewFactoryTests : AvaloniaTestBase
{
    [Fact]
    public void Create_Uses_Generated_Factory_For_Internal_Control()
    {
        var control = ViewFactory.Create<InternalFactoryControl>();

        Assert.NotNull(control);
        Assert.IsType<InternalFactoryControl>(control);
    }
}

internal sealed class InternalFactoryControl : Button
{
    internal InternalFactoryControl()
    {
    }
}