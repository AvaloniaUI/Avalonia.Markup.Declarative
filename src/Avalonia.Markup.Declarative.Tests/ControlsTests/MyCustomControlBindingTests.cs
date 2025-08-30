using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class MyCustomControlBindingTests : AvaloniaTestBase
{
    public class TestCustomControl : ViewBase
    {
        private string? _newValue;
        public static readonly DirectProperty<TestCustomControl, string?> NewValueProperty =
            AvaloniaProperty.RegisterDirect<TestCustomControl, string?>(nameof(NewValue), o => o.NewValue, (o, v) => o.NewValue = v);

        public string? NewValue
        {
            get => _newValue;
            set { SetAndRaise(NewValueProperty, ref _newValue, value); UpdateCanSave(); }
        }

        private string? _savedValue;
        public static readonly DirectProperty<TestCustomControl, string?> SavedValueProperty =
            AvaloniaProperty.RegisterDirect<TestCustomControl, string?>(nameof(SavedValue), o => o.SavedValue, (o, v) => o.SavedValue = v);

        public string? SavedValue
        {
            get => _savedValue;
            set { SetAndRaise(SavedValueProperty, ref _savedValue, value); UpdateCanSave(); }
        }

        private bool _canSave;
        public static readonly DirectProperty<TestCustomControl, bool> CanSaveProperty =
            AvaloniaProperty.RegisterDirect<TestCustomControl, bool>(nameof(CanSave), o => o.CanSave);

        public bool CanSave
        {
            get => _canSave;
            private set => SetAndRaise(CanSaveProperty, ref _canSave, value);
        }

        private void UpdateCanSave() => CanSave = SavedValue != NewValue;

        public void Save() => SavedValue = NewValue;
        public void Cancel() => NewValue = SavedValue;

        protected override object Build() =>
            new Grid()
                .Children(
                    new TextBox().Ref(out TextBox).Text(NewValueProperty, BindingMode.TwoWay),
                    new Button().Ref(out CancelButton).IsEnabled(CanSaveProperty),
                    new Button().Ref(out SaveButton).IsEnabled(CanSaveProperty)
                );

        public TextBox TextBox = null!;
        public Button SaveButton = null!;
        public Button CancelButton = null!;
    }

    public class Host : ViewBase
    {
        protected override object Build() => new TestCustomControl().Ref(out Control);
        public TestCustomControl Control = null!;
    }

    [Fact]
    public void CustomControl_AvaloniaPropertyBindings_Work()
    {
        var host = new Host();
        var window = new Window { Content = host };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var control = host.Control;

        control.NewValue = "A";
        control.SavedValue = "A";
        Dispatcher.UIThread.RunJobs();
        Assert.False(control.CanSave);

        control.NewValue = "B";
        Dispatcher.UIThread.RunJobs();
        Assert.True(control.CanSave);

        control.Save();
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(control.SavedValue, control.NewValue);
        Assert.False(control.CanSave);

        control.SavedValue = "C";
        Dispatcher.UIThread.RunJobs();
        Assert.True(control.CanSave);

        control.Cancel();
        Dispatcher.UIThread.RunJobs();
        Assert.Equal("C", control.NewValue);
        Assert.False(control.CanSave);
    }
}
