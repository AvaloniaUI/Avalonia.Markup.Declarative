using System.Globalization;

namespace AvaloniaMarkupSample.MvuSample;

public class SliderEx : ComponentBase
{
    protected override object Build() =>
        new Grid()
            .Rows("Auto,Auto")
            .Cols("Auto,*, 60, 20")
            .Margin(0, 4)
            .Children(
                new TextBlock()
                    .Text(() => Label)
                    .VerticalAlignment(VerticalAlignment.Center),

                new TextBlock()
                    .Text(() => $"Value: {Value}")
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Margin(4)
                    .Col(1),

                new NumericUpDown()
                    .Col(2)
                    .HorizontalAlignment(HorizontalAlignment.Right)
                    .MinWidth(150)
                    .Minimum(() => (decimal)Minimum)
                    .Maximum(() => (decimal)Maximum)
                    .NumberFormat(new NumberFormatInfo() { NumberDecimalDigits = 0 })
                    .Increment(1)
                    .Value(() => (decimal?)Value, v => { if (v.HasValue) Value = (double)v.Value; }),

                new TextBlock()
                    .Text(() => Units)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Margin(4)
                    .Col(3),

                new Slider()
                    .Row(1)
                    .ColSpan(4)
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