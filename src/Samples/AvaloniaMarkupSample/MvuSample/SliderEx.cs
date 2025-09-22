using System.Globalization;

namespace AvaloniaMarkupSample.MvuSample;

public class SliderEx : ComponentBase
{
    protected override object Build() =>
        new Grid()
            .Rows("Auto,Auto")
            .Cols("Auto,*, 20")
            .Margin(0, 4)
            .Children(
                new TextBlock()
                    .Text(() => Label)
                    .VerticalAlignment(VerticalAlignment.Center),

                new NumericUpDown()
                    .Col(1)
                    .HorizontalAlignment(HorizontalAlignment.Right)
                    .Width(80)
                    .Minimum(() => (decimal)Minimum)
                    .Maximum(() => (decimal)Maximum)
                    .NumberFormat(new NumberFormatInfo() { NumberDecimalDigits = 0 })
                    .Increment(1)
                    .Value(() => (decimal?)Value, v => Value = (double)v!),

                new TextBlock()
                    .Text(() => Units)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Margin(4)
                    .Col(2),

                new Slider()
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
}