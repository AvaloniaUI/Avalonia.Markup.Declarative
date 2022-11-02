namespace AvaloniaMarkupSample.MvuSample;

public partial class MvuComponent : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text("This is nested MVU Component"),

                new TextBlock()
                    .Text(Bind(ComponentParameter)),

                new Button()
                    .Content("Update separate state")
                    .OnClick(OnButtonClick)
            );

    public string ComponentParameter { get; set; } = "Parameter value";

    private void OnButtonClick(RoutedEventArgs obj)
    {
        ComponentParameter = "111";
        StateHasChanged();
    }
}