using Avalonia.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public record struct MyObject(string MyProperty);

public class TestViewModel : INotifyPropertyChanged
{
    private MyObject _myObject = new("Initial");

    public MyObject MyObject
    {
        get => _myObject;
        set
        {
            if (_myObject == value) return;
            _myObject = value;
            OnPropertyChanged();
        }
    }

    public void MyCommand(object? commandParameter) => MyObject = new MyObject("New value");

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public class TestView(TestViewModel vm) : ViewBase<TestViewModel>(vm)
{
    protected override object Build(TestViewModel? vm) =>
        new StackPanel().Children(
            new TextBlock()
                .Text(vm!, x => x.MyObject.MyProperty)
                .Ref(out MyTextBlock)
        );

    public TextBlock MyTextBlock = null!;
}

public class ViewBaseBindingTests : AvaloniaTestBase
{
    [Fact]
    public void TextBlock_Binding_InitialValue()
    {
        var vm = new TestViewModel();
        var view = new TestView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Initial", view.MyTextBlock.Text);
    }

    [Fact]
    public void TextBlock_Updates_When_ViewModel_Changes()
    {
        var vm = new TestViewModel();
        var view = new TestView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Initial", view.MyTextBlock.Text);

        vm.MyCommand(null);
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(vm.MyObject.MyProperty, view.MyTextBlock.Text);
    }
}
