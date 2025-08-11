using Avalonia.Controls;
using Avalonia.Threading;
using Xunit.Abstractions;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class SliderWithLabel : ComponentBase
{

    public double Value { get; set; }

    public string Label { get; set; } = "";

    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Ref(out _labelTextBlock)
                    .Text(() => Label),

                new Slider()
                    .Row(1)
                    .Value(() => Value, v => Value = v)
            );

    private TextBlock _labelTextBlock = null!;

    public string GetRealLabelValue() => _labelTextBlock.Text ?? "Not set";
}
public class ExternalPropertySetTestView : ComponentBase
{
    protected override object Build() => new SliderWithLabel()
        .Ref(out _sliderWithLabel)
        .Label(() => "Hello world") // Initial label value with lazy evaluation
        .Value(50); // Initial value for the slider

    private SliderWithLabel _sliderWithLabel = null!;

    public string? GetRealLabelValue() => _sliderWithLabel.GetRealLabelValue();
}

public class ExternalPropertySetTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public async Task ColorPickerView_BindingStateChanges_PreventInfiniteRecursion()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        //Should not throw exceptions after run

        var realLabelValue = view.GetRealLabelValue();
        testOutputHelper.WriteLine($"Real value: {realLabelValue}");
        Assert.Equal("Hello world", realLabelValue);
    }
}