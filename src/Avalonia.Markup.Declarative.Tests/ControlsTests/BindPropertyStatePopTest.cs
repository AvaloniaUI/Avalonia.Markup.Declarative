using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class BindPropertyStatePopTest : AvaloniaTestBase
{
    [Fact]
    public void ExternalPropertySetTestView_InnerValueChangePoppedToParentComponent()
    {
        var view = new SliderTestView();

        var window = new Window { Content = view };
        window.Show();

        Assert.Equal(1, view.Value);

        var expectedValue = 50;
        view._wrapper._slider.Value = expectedValue;

        Assert.Equal(expectedValue, view._wrapper.Value);
        view._wrapper.UpdateState();
        view.UpdateState();
        Assert.Equal(expectedValue, view.Value);
    }

    public class SliderWrapper : ComponentBase
    {
        protected override object Build() =>
            new StackPanel().Children(
                new NumericUpDown()
                    .Col(1)
                    .Width(80)
                    .Minimum(() => 0)
                    .Maximum(() => 100)
                    .Increment(1)
                    .Value(() => (decimal?)Value, v => Value = (double)v!),

                new Slider()
                    .Ref(out _slider)
                    .Value(() => Value, v => Value = v)
            );

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
}