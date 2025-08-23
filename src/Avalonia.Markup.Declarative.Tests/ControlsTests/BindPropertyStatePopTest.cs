using Avalonia.Controls;
using Avalonia.Threading;
using Xunit.Abstractions;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class SliderWrapper : ComponentBase
{
    protected override object Build() =>
        new Slider()
            .Ref(out _slider)
            .Value(() => Value, v => Value = v);

    public Slider _slider = null!;
    public double Value { get; set; }
}
public class SliderTestView : ComponentBase
{
    protected override object Build() =>
        new SliderWrapper()
            .Ref(out _wrapper)
            .Value(() => Value, v => Value = v);

    public SliderWrapper _wrapper = null!;
    public double Value { get; set; } = 1d;
}

public class BindPropertyStatePopTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public void ExternalPropertySetTestView_InnerValueChangePoppedToParentComponent()
    {
        var view = new SliderTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(1, view.Value);

        var expectedValue = 50;
        view._wrapper._slider.Value = expectedValue;

        Assert.Equal(expectedValue, view._wrapper.Value);
        Assert.Equal(expectedValue, view.Value);
    }

}