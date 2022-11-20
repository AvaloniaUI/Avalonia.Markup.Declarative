namespace MvuTemplate.Views;

public class MvuComponent : MvuComponentBase
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

    private TextBlock _textBlock1;

    [Inject] SampleDataService SampleDataService { get; set; }

    public int Counter { get; set; }
    public string CounterText => $"Counter: {Counter}";

    public SampleDataService DataService { get; set; }

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        _textBlock1.Text = SampleDataService.GetData();
        StateHasChanged();
    }
}