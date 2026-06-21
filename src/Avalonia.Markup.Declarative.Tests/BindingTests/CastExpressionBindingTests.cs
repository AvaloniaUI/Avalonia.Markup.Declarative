using Avalonia.Controls;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;
using Xunit;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

// Regression coverage for issue #122: explicit type casts inside a compiled-binding
// expression (e.g. x => ((DerivedType)x).Property) used to throw. Since the library
// delegates to Avalonia's native CompiledBinding.Create, casts are supported and the
// binding stays reactive.
public class CastExpressionBindingTests : AvaloniaTestBase
{
    public class BaseVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? n = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }

    public class DerivedVm : BaseVm
    {
        private string _name = "initial";
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    }

    // ---- Scenario 1: cast from base to derived: x => ((DerivedVm)x).Name ----
    public class DerivedCastView : ViewBase<BaseVm>
    {
        public DerivedCastView(BaseVm vm) : base(vm) { }
        protected override object Build(BaseVm? vm) =>
            new TextBlock()
                .Ref(out Tb)
                .Text(vm!, x => ((DerivedVm)x).Name);
        public TextBlock Tb = null!;
    }

    [Fact]
    public void Cast_BaseToDerived_InExpression_BindsAndStaysReactive()
    {
        var vm = new DerivedVm();
        var view = new DerivedCastView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("initial");

        vm.Name = "updated";
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("updated");
    }

    // ---- Scenario 2: cast object property to concrete: x => (string)x.Boxed ----
    public class BoxedVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private object _boxed = "hello";
        public object Boxed
        {
            get => _boxed;
            set { _boxed = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Boxed))); }
        }
    }

    public class BoxedCastView : ViewBase<BoxedVm>
    {
        public BoxedCastView(BoxedVm vm) : base(vm) { }
        protected override object Build(BoxedVm? vm) =>
            new TextBlock()
                .Ref(out Tb)
                .Text(vm!, x => (string)x.Boxed);
        public TextBlock Tb = null!;
    }

    [Fact]
    public void Cast_ObjectToString_InExpression_BindsAndStaysReactive()
    {
        var vm = new BoxedVm();
        var view = new BoxedCastView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("hello");

        vm.Boxed = "world";
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("world");
    }

    // ---- Scenario 3: numeric conversion cast: x => (double)x.Counter (int -> double) ----
    // This is NOT supported: Avalonia's expression parser rejects a value-converting
    // Convert node with "Invalid expression type in binding expression: Convert".
    // The cast is also unnecessary - the auto-converter handles int -> double - so the
    // guidance is to write x => x.Counter instead.
    public class NumericVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private int _counter = 5;
        public int Counter { get => _counter; set { _counter = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter))); } }
    }

    public class NumericCastView : ViewBase<NumericVm>
    {
        public NumericCastView(NumericVm vm) : base(vm) { }
        protected override object Build(NumericVm? vm) =>
            new Slider()
                .Ref(out Sl)
                .Value(vm!, x => (double)x.Counter);
        public Slider Sl = null!;
    }

    [Fact]
    public void Cast_IntToDouble_InExpression_Throws()
    {
        var vm = new NumericVm();
        var act = () => new NumericCastView(vm);

        act.Should().Throw<ViewBuildingException>()
            .WithInnerException(typeof(Avalonia.Data.Core.ExpressionParseException))
            .WithMessage("*Convert*");
    }
}
