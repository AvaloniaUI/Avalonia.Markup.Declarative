using Avalonia.Controls;
using System.Globalization;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class BindPropertySameLevelSyncTest : AvaloniaTestBase
{
    [Fact]
    public void ExternalPropertySetTestView_InnerValueChangePoppedToParentComponent()
    {
        var view = new SliderTestView();

        var window = new Window { Content = view };
        window.Show();

        Assert.Equal(1, view.Value);

        var expectedValue = 50;
        view._sliderEx._slider.Value = expectedValue;

        Assert.Equal(expectedValue, view._sliderEx.Value);
        Assert.Equal(expectedValue, view._sliderEx._slider.Value);
        Assert.Equal(expectedValue, view._sliderEx._numericUpDown.Value);
        Assert.Equal(expectedValue, view.Value);
    }

    public class SliderWrapperEx : ComponentBase
    {
        protected override object Build() =>
        new Grid()
            .Rows("Auto,Auto")
            .Cols("Auto,*, 20")
            .Margin(0, 4)
            .Children(
                new TextBlock()
                    .Text(() => Label),

                new NumericUpDown()
                    .Col(1)
                    .Ref(out _numericUpDown)
                    .Width(80)
                    .Minimum(() => (decimal)Minimum)
                    .Maximum(() => (decimal)Maximum)
                    .NumberFormat(new NumberFormatInfo() { NumberDecimalDigits = 0 })
                    .Increment(1)
                    .Value(() => (decimal?)Value, v => { if (v.HasValue) Value = (double)v.Value; }),

                new TextBlock()
                    .Text(() => Units)
                    .Margin(4)
                    .Col(2),

                new Slider()
                    .Ref(out _slider)
                    .Row(1)
                    .ColSpan(3)
                    .TickFrequency(1)
                    .IsSnapToTickEnabled(true)
                    .Maximum(() => Maximum)
                    .Minimum(() => Minimum)
                    .SmallChange(1)
                    .LargeChange(10)
                    .Value(() => Value, v => Value = v)
            );

        public double Value { get; set; } = 0;
        public double Minimum { get; set; } = 0;
        public double Maximum { get; set; } = 100;
        public string Label { get; set; } = "";
        public string Units { get; set; } = "";

        public Slider _slider = null!;
        public NumericUpDown _numericUpDown = null!;
    }
    public class SliderTestView : ComponentBase
    {
        protected override object Build() =>
            new SliderWrapperEx()
                .Ref(out _sliderEx)
                .Value(() => Value, v => Value = v);

        public SliderWrapperEx _sliderEx = null!;
        public double Value { get; set; } = 1d;
    }
}