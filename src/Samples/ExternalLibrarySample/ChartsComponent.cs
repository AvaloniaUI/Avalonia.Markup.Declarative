using System.Diagnostics.CodeAnalysis;
using LiveChartsCore.SkiaSharpView.Avalonia;

namespace ExternalLibrarySample;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(ChartsComponent))]
public class ChartsComponent() : ComponentBase
{
	//Styles
	protected override StyleGroup? BuildStyles() => [];

	//Markup
    protected override object Build() =>
        new Grid().Cols("150, *")
            .Children(
                new CartesianChart()
                {
                    DataContext = new ChartViewModel(),
                    [!CartesianChart.SeriesProperty] = new Binding("Series")
                }.Col(1)
            );

    //Code

    protected override void OnAfterInitialized()
    {
    }
}