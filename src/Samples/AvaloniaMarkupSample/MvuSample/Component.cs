namespace AvaloniaMarkupSample.MvuSample;

public class Component : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text("This is nested MVU Component"),

                new TextBlock()
                    .Text(() => InnerContent),

                new Button()
                    .OnClick(args =>
                    {
                        InnerContent = "Button clicked!";
                        ButtonClicked?.Invoke();
                        StateHasChanged();
                    })

            );

    public event Action? ButtonClicked; 
    public event EventHandler? Button1Clicked;
    public event EventHandler<bool>? Button2Clicked;
    public event Action<int>? Button3Clicked;
    public string InnerContent { get; set; } = "Parameter value";
}