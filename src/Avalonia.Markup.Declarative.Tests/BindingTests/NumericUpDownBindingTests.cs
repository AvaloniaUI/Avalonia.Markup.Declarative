using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class NumericUpDownBindingTests : AvaloniaTestBase
{
    public class NumericViewModel : INotifyPropertyChanged
    {
        private decimal? _counter = 0m;

        public decimal? Counter
        {
            get => _counter;
            set { _counter = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public class NumericView : ViewBase<NumericViewModel>
    {
        public NumericView(NumericViewModel vm) : base(vm) { }

        protected override object Build(NumericViewModel? vm) =>
            new NumericUpDown()
                .Ref(out _num)
                .Value(vm!, x => x.Counter, BindingMode.TwoWay);

        public NumericUpDown _num = null!;
    }

    [Fact]
    public void NumericUpDown_TwoWay_LambdaBinding_Works()
    {
        var vm = new NumericViewModel();
        var view = new NumericView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(0m, vm.Counter);
        Assert.Equal((decimal?)0m, view._num.Value);

        vm.Counter = 5m;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal((decimal?)5m, view._num.Value);

        view._num.Value = 12m;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(12m, vm.Counter);
    }
}
