using Avalonia.Controls;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class ListBoxBindingTests : AvaloniaTestBase
{
    public class ListBoxSampleView : ComponentBase
    {
        protected override object Build() =>
            new StackPanel()
                .Children(
                    new ListBox()
                        .Ref(out _listBox)
                        .ItemsSource(() => Items)
                        .ItemTemplate<string>(item =>
                            new FuncComponent<string>(item, s =>
                                new TextBlock().Text(() => s)))
                        .SelectedItem(() => SelectedItem, v => SelectedItem = (string)v),

                    new TextBlock().Ref(out _selectedText).Text(() => SelectedItem)
                );

        public ListBox _listBox = null!;
        public TextBlock _selectedText = null!;

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

        public List<string> Items { get; set; } = new() { "one", "two", "four" };
    }

    [Fact]
    public void ListBox_SelectedItem_TwoWay_Works()
    {
        var view = new ListBoxSampleView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Initial state should propagate to control
        Assert.Equal("one", view.SelectedItem);
        Assert.Equal("one", (string?)view._listBox.SelectedItem);

        // Programmatic change should update control
        view.SelectedItem = "two"; // setter triggers StateHasChanged
        Dispatcher.UIThread.RunJobs();
        Assert.Equal("two", (string?)view._listBox.SelectedItem);

        // Control-side change should pop back to view after UpdateState
        view._listBox.SelectedItem = "four";
        view.UpdateState();
        Dispatcher.UIThread.RunJobs();
        Assert.Equal("four", view.SelectedItem);
        Assert.Equal("four", view._selectedText.Text);
    }
}
