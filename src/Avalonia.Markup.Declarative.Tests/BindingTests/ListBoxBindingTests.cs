using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class ListBoxBindingTests : AvaloniaTestBase
{
    public class ListBoxViewModel : INotifyPropertyChanged
    {
        private string _selectedItem = "one";

        public string SelectedItem
        {
            get => _selectedItem;
            set { _selectedItem = value; OnPropertyChanged(); }
        }

        public List<string> Items { get; set; } = new() { "one", "two", "four" };

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public class ListBoxSampleView : ViewBase<ListBoxViewModel>
    {
        public ListBoxSampleView(ListBoxViewModel vm) : base(vm) { }

        protected override object Build(ListBoxViewModel? vm) =>
            new StackPanel()
                .Children(
                    new ListBox()
                        .Ref(out _listBox)
                        .ItemsSource(vm!, x => x.Items)
                        .SelectedItem(vm!, x => x.SelectedItem, BindingMode.TwoWay),

                    new TextBlock().Ref(out _selectedText).Text(vm!, x => x.SelectedItem)
                );

        public ListBox _listBox = null!;
        public TextBlock _selectedText = null!;
    }

    [Fact]
    public void ListBox_SelectedItem_TwoWay_Works()
    {
        var vm = new ListBoxViewModel();
        var view = new ListBoxSampleView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("one", vm.SelectedItem);
        Assert.Equal("one", (string?)view._listBox.SelectedItem);

        vm.SelectedItem = "two";
        Dispatcher.UIThread.RunJobs();
        Assert.Equal("two", (string?)view._listBox.SelectedItem);

        view._listBox.SelectedItem = "four";
        Dispatcher.UIThread.RunJobs();
        Assert.Equal("four", vm.SelectedItem);
        Assert.Equal("four", view._selectedText.Text);
    }
}
