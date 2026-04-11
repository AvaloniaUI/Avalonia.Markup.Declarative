using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class CommandBindingTests : AvaloniaTestBase
{
    private record struct CmdObject(string MyProperty);

    private class Vm : INotifyPropertyChanged
    {
        private CmdObject _myObject = new("Start");
        public CmdObject MyObject
        {
            get => _myObject;
            set { if (_myObject.Equals(value)) return; _myObject = value; OnPropertyChanged(); }
        }

        public void MyCommand(object? param) => MyObject = new($"Param:{param is Vm}");

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private class CommandView : ViewBase<Vm>
    {
        public CommandView(Vm vm) : base(vm) { _vm = vm; }
        private Vm _vm;

        protected override object Build(Vm? vm) =>
            new StackPanel()
                .Children(
                    new TextBlock().Ref(out _text).Text(vm!, x => x.MyObject.MyProperty),
                    new Button()
                        .Ref(out _button)
                        .Content("Execute Command")
                        .OnClick(_ => _vm.MyCommand(_vm))
                );

        public TextBlock _text = null!;
        public Button _button = null!;
    }

    [Fact]
    public void Button_Click_Updates_Text_Via_ViewModel()
    {
        var vm = new Vm();
        var view = new CommandView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Start", view._text.Text);

        // Simulate click via raising the Click event
        view._button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Param:True", view._text.Text);
    }
}
