using Avalonia.Controls;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class ExpressionBindingTests : AvaloniaTestBase
{
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

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class ExpressionBindingTestView : ViewBase<SeparatedViewState>
    {
        public ExpressionBindingTestView(SeparatedViewState state) : base(state) { }

        protected override object Build(SeparatedViewState? vm) =>
            new StackPanel().Children(
                new TextBlock()
                    .Ref(out MyTextBlock)
                    .Text(vm!, x => x.StateProp)
            );

        public TextBlock MyTextBlock = null!;
    }

    [Fact]
    public void TextBlock_Binding_TextShouldBeUpdatedOnPropertyChanged()
    {
        var state = new SeparatedViewState();
        var view = new ExpressionBindingTestView(state);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        state.StateProp = "Notified!";
        Dispatcher.UIThread.RunJobs();

        var textBlock = view.MyTextBlock;
        Assert.NotNull(textBlock);
        textBlock.Text.Should().Be("Notified!");
    }
}
