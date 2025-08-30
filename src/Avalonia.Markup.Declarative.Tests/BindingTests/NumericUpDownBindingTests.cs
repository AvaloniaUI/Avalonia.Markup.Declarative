using Avalonia.Controls;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class NumericUpDownBindingTests : AvaloniaTestBase
{
    public class NumericView : ComponentBase
    {
        protected override object Build() =>
            new NumericUpDown()
                .Ref(out _num)
                .Value(() => (decimal?)Counter, v => Counter = v ?? Counter);

        public NumericUpDown _num = null!;
    public decimal Counter { get; set; } = 0m;
    }

    [Fact]
    public void NumericUpDown_TwoWay_LambdaBinding_Works()
    {
        var view = new NumericView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

    // Initial propagation
    Assert.Equal(0m, view.Counter);
    Assert.Equal((decimal?)0m, view._num.Value);

        // Programmatic change -> control
    view.Counter = 5m;
    view.UpdateState();
        Dispatcher.UIThread.RunJobs();
    Assert.Equal((decimal?)5m, view._num.Value);

        // Control change -> view (pop)
    view._num.Value = 12m;
        view.UpdateState();
        Dispatcher.UIThread.RunJobs();
    Assert.Equal(12m, view.Counter);
    }
}
