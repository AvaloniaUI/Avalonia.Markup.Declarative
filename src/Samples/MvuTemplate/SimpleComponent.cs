using Avalonia.Styling;

namespace MvuTemplate;

public class SimpleComponent : ComponentBase
{
    [Inject] SampleDataService DataService { get; set; } = null!;

    public SimpleComponent() : base()
    {
        this.Styles(
            new Style<Border>(x => x.Class("wrapper-panel"))
                .BorderThickness(new Thickness(1))
                .Background(Brushes.CadetBlue)
                .CornerRadius(6)
                .Margin(16)
                .ClipToBounds(true)
        );
    }

    protected override object Build() =>
        new Border()
            .Classes("wrapper-panel")
            .BorderThickness(1)
            .Child(
                new StackPanel()
                    .VerticalAlignment(VerticalAlignment.Center)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Children(
                        new TextBlock().Ref(out _textBlock1)
                            .Text("Hello world"),
                        new TextBlock()
                            .Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"),
                        new NumericUpDown()
                            .Value(Counter, BindingMode.TwoWay),
                        new Button()
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .Content("Click me")
                            .OnClick(OnButtonClick)
                    )
            );

    private TextBlock _textBlock1 = null!;
    private decimal _counter;

    public decimal Counter
    {
        get => _counter;
        set
        {
            _counter = value;
            StateHasChanged();
        }
    }

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++; //state updates on setter

        _textBlock1.Text = DataService.GetData();
    }
}