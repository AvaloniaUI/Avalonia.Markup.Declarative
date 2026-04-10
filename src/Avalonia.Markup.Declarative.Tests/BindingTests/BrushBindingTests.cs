using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class BrushBindingTests : AvaloniaTestBase
{
    public class BrushViewModel : INotifyPropertyChanged
    {
        private IBrush _borderColor = Brushes.Red;

        public IBrush BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public class BorderBrushView : ViewBase<BrushViewModel>
    {
        public BorderBrushView(BrushViewModel vm) : base(vm) { }

        protected override object Build(BrushViewModel? vm) =>
            new Border()
                .Ref(out _border)
                .BorderBrush(vm!, x => x.BorderColor)
                .BorderThickness(3);

        public Border _border = null!;
    }

    [Fact]
    public void Border_BorderBrush_ExpressionBinding_Updates()
    {
        var vm = new BrushViewModel();
        var view = new BorderBrushView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(Brushes.Red, view._border.BorderBrush);

        vm.BorderColor = Brushes.Green;
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(Brushes.Green, view._border.BorderBrush);
    }
}
