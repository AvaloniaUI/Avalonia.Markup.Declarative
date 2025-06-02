using Avalonia.Skia;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;

namespace ExternalLibrarySample;

public class ChartViewModel
{
    public ISeries[] Series { get; set; } =
        [
            new LineSeries<double>
            {
                Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                Fill = null
            }
        ];

    public void UpdateData()
    {
        var rnd = new Random();
        Series =
        [
            new LineSeries<double>
            {
                Values = Enumerable.Range(0,10).Select(x=> rnd.NextDouble()*10).ToArray(),
                Fill = null
            }
        ];

    }

    public void UpdateColor(ColorChangedEventArgs colorChangedEventArgs)
    {
        foreach (var s in Series.OfType<LineSeries<double>>())
        {
            s.Fill =  new SolidColorPaint(colorChangedEventArgs.NewColor.ToSKColor());
        }
    }
}