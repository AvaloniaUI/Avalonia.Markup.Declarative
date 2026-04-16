using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Styling;
using Avalonia.Threading;
using Avalonia.VisualTree;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class ImplicitBindingConversionTests : AvaloniaTestBase
{
    public class IntSliderViewModel : INotifyPropertyChanged
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class IntSliderView : ViewBase<IntSliderViewModel>
    {
        public IntSliderView(IntSliderViewModel vm) : base(vm)
        {
        }

        public Slider Slider = null!;

        protected override object Build(IntSliderViewModel? vm) =>
            new Slider()
                .Ref(out Slider)
                .Value(vm!, x => x.Value, BindingMode.TwoWay);
    }

    public class NumericMirrorControl : ViewBase
    {
        private double _value;

        public static readonly DirectProperty<NumericMirrorControl, double> ValueProperty =
            AvaloniaProperty.RegisterDirect<NumericMirrorControl, double>(nameof(Value), control => control.Value, (control, value) => control.Value = value);

        public double Value
        {
            get => _value;
            set => SetAndRaise(ValueProperty, ref _value, value);
        }

        protected override object Build() => new Border();
    }

    public class IntMirrorView : ViewBase<IntSliderViewModel>
    {
        public IntMirrorView(IntSliderViewModel vm) : base(vm)
        {
        }

        public NumericMirrorControl Mirror = null!;

        protected override object Build(IntSliderViewModel? vm) =>
            new NumericMirrorControl()
                .Ref(out Mirror)
                .Value(vm!, x => x.Value, BindingMode.TwoWay);
    }

    public class BoolCheckBoxViewModel : INotifyPropertyChanged
    {
        private bool _enabled;

        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class BoolCheckBoxView : ViewBase<BoolCheckBoxViewModel>
    {
        public BoolCheckBoxView(BoolCheckBoxViewModel vm) : base(vm)
        {
        }

        public CheckBox CheckBox = null!;

        protected override object Build(BoolCheckBoxViewModel? vm) =>
            new CheckBox()
                .Ref(out CheckBox)
                .IsChecked(vm!, x => x.Enabled, BindingMode.TwoWay);
    }

    public class StyledOpacityItem
    {
        public StyledOpacityItem(string title, int opacity)
        {
            Title = title;
            Opacity = opacity;
        }

        public string Title { get; }

        public int Opacity { get; }
    }

    public class StyledOpacityView : ViewBase
    {
        public TabControl Tabs = null!;

        public List<StyledOpacityItem> Items { get; } =
        [
            new StyledOpacityItem("Visible", 1),
            new StyledOpacityItem("Hidden", 0),
        ];

        protected override StyleGroup? BuildStyles() =>
        [
            new Style<TabItem>()
                .Opacity(default(StyledOpacityItem)!, x => x.Opacity)
        ];

        protected override object Build() =>
            new TabControl()
                .Ref(out Tabs)
                .ItemsSource(Items)
                .ItemTemplate<StyledOpacityItem>(item => new TextBlock().Text(item.Title));
    }

    [Fact]
    public void Slider_Int_To_Double_TwoWay_Binding_Uses_AutoConversion()
    {
        var vm = new IntSliderViewModel { Value = 3 };
        var view = new IntSliderView(vm);
        var window = new Window { Content = view };

        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(3d, view.Slider.Value);

        vm.Value = 7;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(7d, view.Slider.Value);

        view.Slider.Value = 12.75;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(12, vm.Value);
    }

    [Fact]
    public void Internal_AvaloniaProperty_Int_To_Double_Binding_Uses_AutoConversion()
    {
        var vm = new IntSliderViewModel { Value = 2 };
        var view = new IntMirrorView(vm);
        var window = new Window { Content = view };

        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(2d, view.Mirror.Value);

        vm.Value = 9;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(9d, view.Mirror.Value);

        view.Mirror.Value = 4.9;
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(4, vm.Value);
    }

    [Fact]
    public void CheckBox_Bool_To_NullableBool_TwoWay_Binding_Uses_AutoConversion()
    {
        var vm = new BoolCheckBoxViewModel { Enabled = true };
        var view = new BoolCheckBoxView(vm);
        var window = new Window { Content = view };

        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.True(view.CheckBox.IsChecked);

        vm.Enabled = false;
        Dispatcher.UIThread.RunJobs();
        Assert.False(view.CheckBox.IsChecked);

        view.CheckBox.IsChecked = true;
        Dispatcher.UIThread.RunJobs();
        Assert.True(vm.Enabled);
    }

    [Fact]
    public void Style_Binding_Int_To_Double_Uses_AutoConversion()
    {
        var view = new StyledOpacityView();
        var window = new Window { Content = view };

        window.Show();
        Dispatcher.UIThread.RunJobs();

        var items = view.Tabs.GetSelfAndVisualDescendants().OfType<TabItem>().ToList();
        Assert.True(items.Count >= 2);
        Assert.Equal(1d, items[0].Opacity);
        Assert.Equal(0d, items[1].Opacity);
    }
}