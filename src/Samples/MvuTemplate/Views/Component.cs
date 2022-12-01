using Avalonia.Markup.Declarative.Mvu;

namespace MvuTemplate.Views;

public class Component : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .VerticalAlignment(VerticalAlignment.Center)
            .HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                new TextBlock()
                    .Ref(out _textBlock1)
                    .Text("Hello world"),
                new TextBlock()
                    .Text(Bind(CounterText)),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );

    private TextBlock _textBlock1 = null!;

    [Inject] SampleDataService DataService { get; set; } = null!;

    public int Counter { get; set; }
    public string CounterText => $"Counter: {Counter}";

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        _textBlock1.Text = DataService.GetData();
        StateHasChanged();
    }
}