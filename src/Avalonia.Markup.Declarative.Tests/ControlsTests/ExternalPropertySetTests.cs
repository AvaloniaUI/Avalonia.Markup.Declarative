using Avalonia.Controls;
using Avalonia.Threading;
using Xunit.Abstractions;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class SliderWithLabel : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Ref(out _labelTextBlock)
                    .Text(() => Label),

                new Slider()
                    .Ref(out _slider)
                    .Value(() => Value, v => Value = v)
            );

    private TextBlock _labelTextBlock = null!;
    private Slider _slider = null!;
    public double Value { get; set; }
    public string Label { get; set; } = "";

    public string GetRealLabelValue() => _labelTextBlock.Text ?? "Not set";

    public void ChangeSliderValue(double value)
    {
        _slider.Value = value;
    }
}
public class ExternalPropertySetTestView : ComponentBase
{
    protected override object Build() => new SliderWithLabel()
        .Ref(out SliderWithLabel)
        .Label(() => "Hello world") // Initial label value with lazy evaluation
        .Value(() => Value, v => Value = v);


    public SliderWithLabel SliderWithLabel = null!;
    public double Value { get; set; } = 1;

    public string? GetRealLabelValue() => SliderWithLabel.GetRealLabelValue();

    protected override void OnAfterInitialized()
    {
        base.OnAfterInitialized();
    }
}

public class ExternalPropertySetTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public void ExternalPropertySetTestView_ExpressionBinding_Applied_AfterCreation()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var realLabelValue = view.GetRealLabelValue();
        Assert.Equal("Hello world", realLabelValue);
    }

    [Fact]
    public void ExternalPropertySetTestView_BindPropertyChangeInnerValue()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var expectedValue = 100;
        view.Value(expectedValue); //initiates StateHasChanged notification on the view

        var realParentValue = view.Value;
        var realInnerValue = view.SliderWithLabel.Value;
        Assert.Equal(expectedValue, realParentValue);
        Assert.Equal(expectedValue, realInnerValue);
    }

}