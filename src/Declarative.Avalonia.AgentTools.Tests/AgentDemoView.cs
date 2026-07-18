using System;
using System.ComponentModel;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Avalonia.Media;

namespace Declarative.Avalonia.AgentTools.Tests;

/// <summary>
/// The demo the smoke test drives. It deliberately reproduces the failure classes the AgentTools work
/// targets:
/// <list type="bullet">
/// <item>(a) a <b>custom slider</b> built from <see cref="Border"/>/<see cref="Canvas"/> with hand-written
///   <c>PointerPressed/Moved/Released</c> handlers and <b>no automation peer</b> — scrubbed by dragging,
///   entered into text-edit mode by a tap;</item>
/// <item>(b) a <b>Popup</b> opened both by a view-model command and by a click trigger, its
///   <c>IsOpen</c> bound to nested app state (<c>AppState.UiState.ShowBrushSettings</c>);</item>
/// <item>(c) the whole content nested in a <see cref="LayoutTransformControl"/> (UI-scale), with the popup
///   content living in its own visual root.</item>
/// </list>
/// Built with plain Avalonia API + reflection bindings so it needs no generated markup extensions.
/// </summary>
public sealed class AgentDemoView : ViewBase<AgentDemoViewModel>
{
    public const double SliderWidth = 240;
    public const double SliderHeight = 32;
    public const double ThumbWidth = 20;

    public AgentDemoView() : base(new AgentDemoViewModel())
    {
    }

    protected override object Build(AgentDemoViewModel vm)
    {
        // ── (a) Custom raw-pointer slider ────────────────────────────────────────────────────────
        var thumb = new Border
        {
            Name = "Thumb",
            Width = ThumbWidth,
            Height = SliderHeight,
            Background = Brushes.SteelBlue,
        };

        var track = new Border
        {
            Name = "Track",
            Width = SliderWidth,
            Height = SliderHeight,
            Background = Brushes.LightGray,
        };

        var canvas = new Canvas { Width = SliderWidth, Height = SliderHeight };
        canvas.Children.Add(track);
        canvas.Children.Add(thumb);

        var slider = new Border
        {
            Name = "RawSlider",
            Width = SliderWidth,
            Height = SliderHeight,
            Background = Brushes.Transparent,
            Child = canvas,
        };

        WireSlider(slider, track, thumb, vm);

        void PositionThumb() => Canvas.SetLeft(thumb, vm.Value / 100.0 * (SliderWidth - ThumbWidth));
        PositionThumb();
        vm.PropertyChanged += (_, e) =>
        {
            if (e.PropertyName == nameof(AgentDemoViewModel.Value))
                PositionThumb();
        };

        // ── Value label + text-edit field ───────────────────────────────────────────────────────
        var label = new TextBlock { Name = "ValueLabel" };
        label.Bind(TextBlock.TextProperty, new Binding(nameof(AgentDemoViewModel.Value)) { StringFormat = "Value: {0:0}" });

        var editor = new TextBox { Name = "ValueEditor", Width = SliderWidth };
        editor.Bind(TextBox.TextProperty, new Binding(nameof(AgentDemoViewModel.Value)) { Mode = BindingMode.TwoWay });
        // Record real key events so the test can prove synthesized Escape/Enter reach the focused box.
        // handledEventsToo: TextBox marks Enter/Escape handled in its own OnKeyDown, but the routed event
        // still bubbles to this instance handler.
        editor.AddHandler(InputElement.KeyDownEvent, (_, e) => vm.LastKey = e.Key.ToString(), RoutingStrategies.Bubble, handledEventsToo: true);
        vm.RequestEditorFocus = () => editor.Focus();

        // ── (b) Popup opened by command and by click trigger ────────────────────────────────────
        var openByCommand = new Button { Name = "OpenByCommand", Content = "Open (command)" };
        openByCommand.Bind(Button.CommandProperty, new Binding(nameof(AgentDemoViewModel.ToggleBrushSettingsCommand)));

        var openByClick = new Button { Name = "OpenByClick", Content = "Open (click)" };
        openByClick.Click += (_, _) => vm.AppState.UiState.ShowBrushSettings = !vm.AppState.UiState.ShowBrushSettings;

        var popupContent = new Border
        {
            Name = "BrushSettings",
            Background = Brushes.MediumPurple,
            Padding = new Thickness(16),
            Child = new TextBlock { Name = "BrushSettingsText", Text = "Brush settings content", Foreground = Brushes.White },
        };

        var popup = new Popup
        {
            Name = "BrushSettingsPopup",
            PlacementTarget = slider,
            Placement = PlacementMode.Bottom,
            Child = popupContent,
        };
        popup.Bind(Popup.IsOpenProperty, new Binding("AppState.UiState.ShowBrushSettings") { Mode = BindingMode.TwoWay });

        var content = new StackPanel
        {
            Name = "DemoRoot",
            Spacing = 8,
            Margin = new Thickness(20),
        };
        content.Children.Add(label);
        content.Children.Add(slider);
        content.Children.Add(editor);
        content.Children.Add(openByCommand);
        content.Children.Add(openByClick);
        content.Children.Add(popup);

        // ── (c) UI-scale wrapper ──────────────────────────────────────────────────────────────────
        return new LayoutTransformControl
        {
            Name = "ScaleHost",
            LayoutTransform = new ScaleTransform(1.25, 1.25),
            Child = content,
        };
    }

    private static void WireSlider(Border slider, Border track, Border thumb, AgentDemoViewModel vm)
    {
        var pressX = 0.0;
        var moved = false;

        slider.PointerPressed += (_, e) =>
        {
            e.Pointer.Capture(slider);
            pressX = e.GetPosition(slider).X;
            moved = false;
            e.Handled = true;
        };

        slider.PointerMoved += (_, e) =>
        {
            if (!e.GetCurrentPoint(slider).Properties.IsLeftButtonPressed)
                return;

            var x = e.GetPosition(slider).X;
            if (Math.Abs(x - pressX) > 3)
                moved = true;

            vm.Value = Math.Clamp(x / SliderWidth * 100.0, 0, 100);
        };

        slider.PointerReleased += (_, e) =>
        {
            e.Pointer.Capture(null);
            // A tap (no scrub) switches into text-edit mode and focuses the editor — no automation peer
            // involved, so only real synthetic input can trigger this.
            if (!moved)
            {
                vm.IsEditing = true;
                vm.RequestEditorFocus?.Invoke();
            }

            e.Handled = true;
        };
    }
}

/// <summary>View-model for <see cref="AgentDemoView"/>.</summary>
public sealed class AgentDemoViewModel : INotifyPropertyChanged
{
    private double _value;
    private bool _isEditing;
    private string? _lastKey;

    /// <summary>The slider value (0–100), driven by dragging the custom slider.</summary>
    public double Value
    {
        get => _value;
        set => Set(ref _value, value, nameof(Value));
    }

    /// <summary>True once the slider is tapped — the demo's "text input mode".</summary>
    public bool IsEditing
    {
        get => _isEditing;
        set => Set(ref _isEditing, value, nameof(IsEditing));
    }

    /// <summary>The last key delivered to the focused editor (records synthesized Escape/Enter).</summary>
    public string? LastKey
    {
        get => _lastKey;
        set => Set(ref _lastKey, value, nameof(LastKey));
    }

    /// <summary>Nested app state, so the real popup-open flag lives at AppState.UiState.ShowBrushSettings
    /// rather than on the root view-model (the P3 scenario).</summary>
    public AppStateModel AppState { get; } = new();

    /// <summary>Toggles the (nested) popup-open flag — the command a button binds to (P2 scenario).</summary>
    public ICommand ToggleBrushSettingsCommand { get; }

    /// <summary>Hook the view sets so a tap can focus the editor without the VM knowing the control.</summary>
    public Action? RequestEditorFocus { get; set; }

    public AgentDemoViewModel() =>
        ToggleBrushSettingsCommand = new RelayCommand(
            _ => AppState.UiState.ShowBrushSettings = !AppState.UiState.ShowBrushSettings);

    public event PropertyChangedEventHandler? PropertyChanged;

    private void Set<T>(ref T field, T value, string name)
    {
        if (Equals(field, value))
            return;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

/// <summary>App-state root holding a nested UI-state object.</summary>
public sealed class AppStateModel
{
    public UiStateModel UiState { get; } = new();
}

/// <summary>Nested UI state; the popup-open flag lives here (deep path AppState.UiState.ShowBrushSettings).</summary>
public sealed class UiStateModel : INotifyPropertyChanged
{
    private bool _showBrushSettings;

    public bool ShowBrushSettings
    {
        get => _showBrushSettings;
        set
        {
            if (_showBrushSettings == value)
                return;
            _showBrushSettings = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShowBrushSettings)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

/// <summary>Minimal <see cref="ICommand"/>.</summary>
public sealed class RelayCommand : ICommand
{
    private readonly Action<object?> _execute;
    private readonly Func<object?, bool>? _canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

    public void Execute(object? parameter) => _execute(parameter);

    public event EventHandler? CanExecuteChanged
    {
        add { }
        remove { }
    }
}
