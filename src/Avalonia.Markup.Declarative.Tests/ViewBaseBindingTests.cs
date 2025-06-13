using Avalonia.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative.Tests;

public record struct MyObject(string MyProperty);

/// <summary>
/// Classical ViewModel for testing purposes, implementing INotifyPropertyChanged
/// </summary>
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

    public void MyCommand(object? commandParameter) => MyObject = new MyObject($"New value");

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public class TestView(TestViewModel vm) : ViewBase<TestViewModel>(vm)
{
    protected override object Build(TestViewModel? vm) =>
        new TextBlock()
            .Text(() => vm?.MyObject.MyProperty ?? "")
            .Ref(out MyTextBlock);

    public TextBlock MyTextBlock = null!; // Using a field to check it's value in tests
}

public class ViewBaseBindingTests
{
    [Fact]
    public void TextBlock_Binding_RegistersComputedState()
    {
        var vm = new TestViewModel();
        var view = new TestView(vm);


        // Should have a computed state for the Text property
        Assert.Contains(view.__viewComputedStates, s =>
            s is ViewPropertyComputedState<TextBlock, string> state &&
            state.GetterFunc() == "Initial");

        Assert.Equal("Initial", view.MyTextBlock.Text);
    }

    [Fact]
    public void TextBlock_Updates_When_ViewModel_Changes()
    {
        var vm = new TestViewModel();
        var view = new TestView(vm);

        // Initial value check
        Assert.Equal("Initial", view.MyTextBlock.Text);

        // Act: update the ViewModel
        vm.MyCommand(null);

        // Force property changed propagation if needed

        // Assert: TextBlock.Text should reflect the new value
        Assert.Equal(vm.MyObject.MyProperty, view.MyTextBlock.Text);
    }
}