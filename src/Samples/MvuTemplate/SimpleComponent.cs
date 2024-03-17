using Avalonia.Styling;

namespace MvuTemplate;

public class SimpleComponent : ComponentBase
{
    [Inject] SampleDataService DataService { get; set; } = null!;

    protected override StyleGroup? BuildStyles()
    {
        return base.BuildStyles();
    }

    protected override object Build() =>
        new StackPanel()
            .BindClass(() => Bounds.Width < 400, "narrow")
            .VerticalAlignment(VerticalAlignment.Center)
            .HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                new TextBlock().Ref(out _textBlock1)
                    .Text("Hello world"),
                new TextBlock()
                    .Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"),
                new NumericUpDown()
                    .Value(() => Counter, onChanged: v => Counter = v),
                new Button()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );

    private TextBlock _textBlock1 = null!;

    private decimal? Counter { get; set; } = 0;

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++; //state updates on setter

        _textBlock1.Text = DataService.GetData();
    }
}