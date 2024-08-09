namespace AvaloniaMarkupSample;

public class ItemControlSampleView : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new ListBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(Bind(Items))
                    .ItemTemplate<string>(item =>
                        //needed to keep current view context for lambda bindings
                        new FuncComponent<string>(item, s =>
                            new TextBlock()
                            .Background(Brushes.Beige)
                            .Text(() => s))
                    )
                    .SelectedItem(() => SelectedItem, v => SelectedItem = (string)v),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(() => SelectedItem)
            );

    private string _selectedItem = "one";
    public string SelectedItem
    {
        get => _selectedItem;
        set
        {
            _selectedItem = value;
            StateHasChanged();
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