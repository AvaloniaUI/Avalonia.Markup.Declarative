using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaMarkupSample.CommonSamples;

public class ItemControlSampleViewModel : INotifyPropertyChanged
{
    private string _selectedItem = "one";
    public string SelectedItem
    {
        get => _selectedItem;
        set { _selectedItem = value; OnPropertyChanged(); }
    }

    public List<string> Items { get; set; } =
    [
        "one",
        "two",
        "four"
    ];

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

public class ItemControlSampleView() : ViewBase<ItemControlSampleViewModel>(new ItemControlSampleViewModel())
{
    protected override object Build(ItemControlSampleViewModel? vm) =>
        new StackPanel()
            .Children(
                new ListBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(vm!.Items)
                    .ItemTemplate<string>(item =>
                        new TextBlock()
                            .Background(Brushes.Beige)
                            .Text(item)
                    )
                    .SelectedItem(vm!, x => x.SelectedItem, BindingMode.TwoWay),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(vm!, x => x.SelectedItem)
            );
}
