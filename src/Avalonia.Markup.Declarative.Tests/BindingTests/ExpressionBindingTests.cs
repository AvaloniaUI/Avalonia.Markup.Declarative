using Avalonia.Controls;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class ExpressionBindingTests : AvaloniaTestBase
{

    public class ExpressionBindingTestView : ComponentBase
    {
        protected override object Build() =>
            new StackPanel().Children(
                new ToggleSwitch()
                    .OnContent("Erase mode: On")
                    .OffContent("Erase mode: Off")
                    .IsChecked(() => IsToggleChecked, v => IsToggleChecked = v ?? false),

                new TextBlock()
                    .Ref(out MyTextBlock)
                    .Text(() => State.StateProp)
            );

        public TextBlock MyTextBlock = null!;

        public SeparatedViewState State { get; set; } = new();

        private bool IsToggleChecked { get; set; }
    }
    public class SeparatedViewState : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _stateProp = "Separate state property";

        public string StateProp
        {
            get => _stateProp;
            set
            {
                _stateProp = value;
                OnPropertyChanged();
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void UpdatePropertyWithoutNotification(string newValue) => _stateProp = newValue;
    }

    [Fact]
    public void TextBlock_Binding_TextShouldBeUpdatedOnStateHasChanged()
    {
        var view = new ExpressionBindingTestView();
        // Attach to visual tree to ensure template is applied
        var window = new Window { Content = view };
        window.Show();
        // Process layout and rendering
        Dispatcher.UIThread.RunJobs();

        var state = view.State;

        view.UpdateState(() => state.UpdatePropertyWithoutNotification("Updated!"));

        var textBlock = view.MyTextBlock;
        Assert.NotNull(textBlock);

        textBlock.Text.Should().Be("Updated!");
    }

    [Fact]
    public void TextBlock_Binding_TextShouldBeUpdatedOnPropertyChanged()
    {
        var view = new ExpressionBindingTestView();
        // Attach to visual tree to ensure template is applied
        var window = new Window { Content = view };
        window.Show();
        // Process layout and rendering
        Dispatcher.UIThread.RunJobs();

        var state = view.State;

        state.StateProp = "Notified!";

        var textBlock = view.MyTextBlock;
        Assert.NotNull(textBlock);

        textBlock.Text.Should().Be("Notified!");
    }

}