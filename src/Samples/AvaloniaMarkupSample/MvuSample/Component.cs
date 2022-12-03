namespace AvaloniaMarkupSample.MvuSample;

public class Component : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text("This is nested MVU Component"),

                new TextBlock()
                    .Text(Bind(InnerContent))
            );

    public string InnerContent { get; set; } = "Parameter value";
}