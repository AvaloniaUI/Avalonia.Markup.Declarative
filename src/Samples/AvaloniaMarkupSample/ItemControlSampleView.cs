namespace AvaloniaMarkupSample;

public class ItemControlSampleView : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new ListBox()
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Items(Bind(Items))
                    .ItemTemplate<string>(s =>
                        new TextBlock()
                            .Background(Brushes.Beige)
                            .Text(s)
                    )
                    .SelectedItem(Bind(SelectedItem)),

                new TextBlock()
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Text(Bind(SelectedItem))
            );

    private string? _selectedItem = "one";
    public string? SelectedItem
    {
        get => _selectedItem;
        set
        {
            _selectedItem = value;
            OnPropertyChanged();
        }
    }

    public List<string> Items { get; set; } = new()
    {
        "one",
        "two",
        "four"
    };
}