namespace AvaloniaMarkupSample;

public class ItemControlSampleView : ComponentBase
{
    protected override object Build() =>
        new ItemsControl()
            .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
            .Items(Bind(Items))
            .ItemTemplate<string>(s => new Button().Content(s));

    public List<string> Items { get; set; } = new()
    {
        "one",
        "two",
        "four"
    };
}