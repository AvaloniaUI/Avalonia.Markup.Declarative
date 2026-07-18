using System;
using System.ComponentModel;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Headless;
using Avalonia.Headless.XUnit;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Diagnostics.Tests;

/// <summary>
/// Unit coverage for the diagnostics helpers that back the reworked agent tools: the shared coordinate
/// frame, drivability classification, structured view-model diagnostics, closed-popup handling, the
/// degenerate-frame guard, and real input synthesis.
/// </summary>
public class AgentToolingDiagnosticsTests
{
    private static (Window Window, Control Root) Show(Control content, double w = 400, double h = 300)
    {
        var window = new Window { Width = w, Height = h, Content = content };
        window.Show();
        window.Activate();
        Dispatcher.UIThread.RunJobs();
        AvaloniaHeadlessPlatform.ForceRenderTimerTick();
        Dispatcher.UIThread.RunJobs();
        return (window, content);
    }

    [AvaloniaFact]
    public void VisualBoundsHelper_accounts_for_layout_transform_scale()
    {
        var inner = new Border { Width = 100, Height = 40, Background = Brushes.Red };
        var host = new LayoutTransformControl { LayoutTransform = new ScaleTransform(2, 2), Child = inner };
        var (window, _) = Show(host);
        try
        {
            var abs = VisualBoundsHelper.GetClientBounds(inner, window);
            Assert.NotNull(abs);
            // 100x40 scaled 2x → 200x80 in absolute client-DIP space.
            Assert.Equal(200, abs!.Value.Width, 1);
            Assert.Equal(80, abs.Value.Height, 1);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void ControlDrivability_distinguishes_button_from_raw_border()
    {
        var button = new Button { Content = "Go" };
        var border = new Border { Background = Brushes.Gray };
        var (window, _) = Show(new StackPanel { Children = { button, border } });
        try
        {
            Assert.True(ControlDrivability.Classify(button).AutomationInvokable);
            var raw = ControlDrivability.Classify(border);
            Assert.False(raw.AutomationInvokable);
            Assert.True(raw.RawPointerOnly);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void ListBindable_lists_commands_settables_and_subobjects()
    {
        var report = ViewModelInspector.ListBindable(new NestedViewModel());

        Assert.Contains("Settable properties", report);
        Assert.Contains("Flag", report);
        Assert.Contains("ICommand properties", report);
        Assert.Contains("DoCommand", report);
        Assert.Contains("Sub-objects", report);
        Assert.Contains("Ui", report); // the nested state root, reachable via a dotted path
    }

    [AvaloniaFact]
    public void Resolution_failure_names_missing_member_and_lists_alternatives()
    {
        var vm = new NestedViewModel();

        var command = ViewModelInspector.InvokeCommand(vm, "ViewCommands.DoCommand", null);
        Assert.DoesNotContain("An error occurred", command);
        Assert.Contains("no member 'ViewCommands'", command);
        Assert.Contains("NestedViewModel", command);
        Assert.Contains("DoCommand", command);

        // The deep, valid path resolves through the nested state object.
        var deep = ViewModelInspector.SetValue(vm, "Ui.Shown", "true");
        Assert.Contains("Shown", deep);
        Assert.True(vm.Ui.Shown);
    }

    [AvaloniaFact]
    public void IsDegenerate_detects_flat_buffers_only()
    {
        var flat = new byte[64 * 4]; // all zero → uniform
        Assert.True(ControlScreenshotService.IsDegenerate(flat));

        var varied = new byte[64 * 4];
        for (var i = 0; i < varied.Length; i++)
            varied[i] = (byte)(i * 7);
        Assert.False(ControlScreenshotService.IsDegenerate(varied));
    }

    [AvaloniaFact]
    public void PopupLocator_open_sets_isopen_and_describes_closed()
    {
        var popup = new Popup { Name = "MyPopup", Child = new TextBlock { Text = "content" } };
        var panel = new StackPanel { Children = { new Button { Content = "Owner" }, popup } };
        var (window, _) = Show(panel);
        try
        {
            Assert.False(popup.IsOpen);
            Assert.NotNull(PopupLocator.DescribeIfClosedPopup(popup));
            Assert.Contains("open_popup", PopupLocator.DescribeIfClosedPopup(popup)!);

            var result = PopupLocator.Open(new Visual[] { window }, "MyPopup");
            Dispatcher.UIThread.RunJobs();
            Assert.Contains("Opened popup", result);
            Assert.True(popup.IsOpen);
            Assert.Null(PopupLocator.DescribeIfClosedPopup(popup)); // no longer a closed-popup dead end
        }
        finally
        {
            popup.IsOpen = false;
            window.Close();
        }
    }

    [AvaloniaFact]
    public void InputSynthesizer_press_move_release_fires_real_pointer_events()
    {
        var border = new Border { Width = 200, Height = 60, Background = Brushes.SteelBlue };
        var pressed = 0;
        var moved = 0;
        var released = 0;
        border.AddHandler(InputElement.PointerPressedEvent, (_, _) => pressed++, RoutingStrategies.Bubble, true);
        border.AddHandler(InputElement.PointerMovedEvent, (_, _) => moved++, RoutingStrategies.Bubble, true);
        border.AddHandler(InputElement.PointerReleasedEvent, (_, _) => released++, RoutingStrategies.Bubble, true);

        var (window, _) = Show(new Decorator { Child = border });
        try
        {
            var center = VisualBoundsHelper.GetClientCenter(border, window)!.Value;

            InputSynthesizer.PointerPress(window, center, MouseButton.Left, RawInputModifiers.None);
            InputSynthesizer.PointerMove(window, new Point(center.X + 10, center.Y), RawInputModifiers.None);
            InputSynthesizer.PointerRelease(window, new Point(center.X + 10, center.Y), MouseButton.Left, RawInputModifiers.None);
            Dispatcher.UIThread.RunJobs();

            Assert.True(pressed >= 1, $"PointerPressed should fire (was {pressed}).");
            Assert.True(moved >= 1, $"PointerMoved should fire (was {moved}).");
            Assert.True(released >= 1, $"PointerReleased should fire (was {released}).");
        }
        finally
        {
            window.Close();
        }
    }

    private sealed class NestedViewModel
    {
        public bool Flag { get; set; }
        public UiState Ui { get; } = new();
        public ICommand DoCommand { get; } = new NoopCommand();
    }

    private sealed class UiState : INotifyPropertyChanged
    {
        private bool _shown;

        public bool Shown
        {
            get => _shown;
            set
            {
                _shown = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shown)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    private sealed class NoopCommand : ICommand
    {
        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) { }
        public event EventHandler? CanExecuteChanged { add { } remove { } }
    }
}
