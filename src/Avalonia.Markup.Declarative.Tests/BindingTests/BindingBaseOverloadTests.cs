using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Styling;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

// Regression coverage for issue #121: the source generator emits a named overload for every
// property/attached-property/style setter that accepts a ready-made BindingBase, so a reflection
// Binding or a compiled binding can be passed directly:
//     new TextBlock().Text(new Binding("Name"))
//     new TextBlock().Text(CompiledBinding.Create<Vm, string>(x => x.Name, source: vm))
public class BindingBaseOverloadTests : AvaloniaTestBase
{
    public class Vm : INotifyPropertyChanged
    {
        private string _name = "initial";
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        private int _row;
        public int Row { get => _row; set { _row = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? n = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }

    // ---- reflection Binding resolved via the inherited DataContext ----
    public class ReflectionBindingView : ViewBase<Vm>
    {
        public ReflectionBindingView(Vm vm) : base(vm) { }
        protected override object Build(Vm? vm) =>
            new TextBlock()
                .Ref(out Tb)
                .Text(new Binding(nameof(Vm.Name)));
        public TextBlock Tb = null!;
    }

    [Fact]
    public void ReflectionBinding_Overload_BindsAndStaysReactive()
    {
        var vm = new Vm();
        var view = new ReflectionBindingView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("initial");

        vm.Name = "updated";
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("updated");
    }

    // ---- compiled binding created explicitly ----
    public class CompiledBindingView : ViewBase<Vm>
    {
        public CompiledBindingView(Vm vm) : base(vm) { }
        protected override object Build(Vm? vm) =>
            new TextBlock()
                .Ref(out Tb)
                .Text(CompiledBinding.Create<Vm, string>(x => x.Name, source: vm!));
        public TextBlock Tb = null!;
    }

    [Fact]
    public void CompiledBinding_Overload_BindsAndStaysReactive()
    {
        var vm = new Vm();
        var view = new CompiledBindingView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("initial");

        vm.Name = "changed";
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("changed");
    }

    // ---- reflection Binding with an explicit Source (no DataContext plumbing) ----
    [Fact]
    public void ReflectionBinding_WithExplicitSource_Binds()
    {
        var vm = new Vm { Name = "srcval" };
        var tb = new TextBlock()
            .Text(new Binding(nameof(Vm.Name)) { Source = vm });

        var window = new Window { Content = tb };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        tb.Text.Should().Be("srcval");
    }

    // ---- TwoWay reflection binding round-trips ----
    [Fact]
    public void ReflectionBinding_TwoWay_UpdatesSource()
    {
        var vm = new Vm { Name = "start" };
        var box = new TextBox()
            .Text(new Binding(nameof(Vm.Name)) { Source = vm, Mode = BindingMode.TwoWay });

        var window = new Window { Content = box };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        box.Text.Should().Be("start");

        box.Text = "typed";
        Dispatcher.UIThread.RunJobs();

        vm.Name.Should().Be("typed");
    }

    // ---- style setter binding overload (DataContext-relative reflection binding) ----
    public class StyledView : ViewBase<Vm>
    {
        public StyledView(Vm vm) : base(vm) { }

        // BuildStyles() runs from the base constructor before any derived field is set, so the
        // binding must be DataContext-relative: the root TextBlock inherits the view's DataContext.
        protected override StyleGroup? BuildStyles() =>
        [
            new Style<TextBlock>()
                .Text(new Binding(nameof(Vm.Name)))
        ];

        protected override object Build(Vm? vm) =>
            new TextBlock().Ref(out Tb);

        public TextBlock Tb = null!;
    }

    [Fact]
    public void StyleSetter_BindingOverload_Applies()
    {
        var vm = new Vm { Name = "styled" };
        var view = new StyledView(vm);
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.Tb.Text.Should().Be("styled");
    }

    // ---- attached-property binding overload ----
    [Fact]
    public void AttachedProperty_BindingOverload_Applies()
    {
        var vm = new Vm { Row = 3 };
        var child = new Border()
            .Grid_Row(new Binding(nameof(Vm.Row)) { Source = vm });

        var grid = new Grid().Children(child);
        var window = new Window { Content = grid };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Grid.GetRow(child).Should().Be(3);
    }
}
