using System.Diagnostics.CodeAnalysis;
using LiveChartsCore.SkiaSharpView.Avalonia;

namespace ExternalLibrarySample;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(ChartsComponent))]
public class ChartsComponent() : ComponentBase
{
    //Markup
    protected override object Build() =>
        new Grid().Cols("Auto, *")
            .Children(
                new StackPanel().Children(
                    new Button()
                        .Content("Update data")
                        .VerticalAlignment(VerticalAlignment.Top)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .Margin(new Thickness(left: 0, top: 16, right: 0, bottom: 0))
                        .OnClick(_ =>
                        {
                            ViewModel?.UpdateData();
                            StateHasChanged();
                        }),

                    new ColorPicker()
                        .Margin(0, 16)
                        .OnColorChanged(c =>
                        {
                            ViewModel?.UpdateColor(c);
                            StateHasChanged();
                        })
                        .BorderThickness(1)
                        .BorderBrush(Brushes.Gray)
                ),

                BuildChartArea().Col(1)
            );

    private Control BuildChartArea()
    {
        try
        {
            return new CartesianChart()
                .Series(() => ViewModel?.Series)
                .Background(Brushes.WhiteSmoke)
                .AnimationsSpeed(TimeSpan.FromMilliseconds(1500));
        }
        catch (Exception ex) when (IsDependencyCompatibilityException(ex))
        {
            var rootCause = GetRootCause(ex);

            return new Border()
                .Padding(20)
                .Margin(16)
                .Background(Brushes.MistyRose)
                .BorderBrush(Brushes.IndianRed)
                .BorderThickness(1)
                .Child(
                    new StackPanel()
                        .Spacing(10)
                        .Children(
                            new TextBlock()
                                .FontSize(18)
                                .FontWeight(FontWeight.SemiBold)
                                .Text("LiveCharts sample is unavailable with the current package set."),

                            new TextBlock()
                                .TextWrapping(TextWrapping.Wrap)
                                .Text("Cause: LiveChartsCore.SkiaSharpView.Avalonia 2.1.0-dev-247 declares Avalonia 11.0.0, while ExternalLibrarySample currently resolves Avalonia 12.0.0."),

                            new TextBlock()
                                .TextWrapping(TextWrapping.Wrap)
                                .Text($"Runtime error: {rootCause.GetType().Name}: {rootCause.Message}"),

                            new TextBlock()
                                .TextWrapping(TextWrapping.Wrap)
                                .Text("What to do: either switch this sample to an Avalonia 11 package set, or upgrade LiveChartsCore.SkiaSharpView.Avalonia to a build compiled for Avalonia 12 when such a package is available.")
                        ));
        }
    }

    private static Exception GetRootCause(Exception exception)
    {
        while (exception.InnerException != null)
        {
            exception = exception.InnerException;
        }

        return exception;
    }

    private static bool IsDependencyCompatibilityException(Exception exception)
    {
        exception = GetRootCause(exception);
        return exception is MissingFieldException or MissingMethodException or TypeLoadException;
    }

    //Code
    public ChartViewModel? ViewModel { get; set; } = new();
}