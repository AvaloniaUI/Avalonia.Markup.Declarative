namespace MvuTemplate.Views;

public class MvuComponent : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .VerticalAlignment(VerticalAlignment.Center)
            .HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                new TextBlock()
                    .Text(Bind(CounterText)),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );

    public int Counter { get; set; }
    public string CounterText => $"Counter: {Counter}";
    
    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        StateHasChanged();
    }
}