namespace AvaloniaMarkupSample.MvuSample;

public partial class MvuComponent : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text("This is nested MVU Component"),

                new TextBlock()
                    .Text(Bind(ComponentParameter))
            );

    public string ComponentParameter { get; set; } = "Parameter value";
}