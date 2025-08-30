using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.Data;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class CommandBindingTests : AvaloniaTestBase
{
    private record struct MyObject(string MyProperty);

    private class Vm : INotifyPropertyChanged
    {
        private MyObject _myObject = new("Start");
        public MyObject MyObject
        {
            get => _myObject;
            set { if (_myObject.Equals(value)) return; _myObject = value; OnPropertyChanged(); }
        }

        public void MyCommand(object? param) => MyObject = new($"Param:{param is Vm}");

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private class CommandView : ViewBase<Vm>
    {
        public CommandView() : base(new Vm()) { }

        protected override object Build(Vm? vm) =>
            new StackPanel()
                .Children(
                    new TextBlock().Ref(out _text).Text(() => vm!.MyObject.MyProperty),
                    new Button()
                        .Ref(out _button)
                        .Content("Execute Command")
                        .Command(new Binding(nameof(Vm.MyCommand)))
                        .CommandParameter(new Binding { Source = vm })
                );

        public TextBlock _text = null!;
        public Button _button = null!;
    }

    [Fact]
    public void Button_Command_Binding_To_MethodName_Works_With_CommandParameter()
    {
        var view = new CommandView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Start", view._text.Text);

        // Simulate click by executing command
        var cmd = view._button.Command;
        var param = view._button.CommandParameter;
        Assert.NotNull(cmd);
        Assert.True(cmd!.CanExecute(param));
        cmd.Execute(param);
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Param:True", view._text.Text);
    }
}
