using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless.XUnit;
using Avalonia.Markup.Declarative.Diagnostics;
using Avalonia.Threading;
using Declarative.Avalonia.AgentTools;
using Declarative.Avalonia.AgentTools.Tools;
using ModelContextProtocol.Protocol;

namespace Declarative.Avalonia.AgentTools.Tests;

/// <summary>
/// Smoke test that drives EVERY MCP tool over <see cref="AgentDemoView"/> and asserts the P1–P6
/// acceptance criteria. The tools are the real static handlers; they marshal to the UI thread (already
/// current under <c>[AvaloniaFact]</c>) and resolve the window through the component registry.
/// </summary>
public class AgentToolsSmokeTests
{
    static AgentToolsSmokeTests() =>
        AgentToolContext.Options = new AgentInspectorOptions { EnableInteraction = true };

    // These [AvaloniaFact]s share one Application/dispatcher for the whole assembly. Each test gets a
    // fresh window (a freshly shown window renders into the compositor's hit-test scene, which real
    // pointer routing uses); leftover windows are torn down first so exactly one top-level is discoverable.
    private static (Window Window, AgentDemoView View, AgentDemoViewModel Vm) ShowDemo()
    {
        foreach (var leftover in AgentToolContext.GetTopLevels().OfType<Window>().ToList())
        {
            leftover.Content = null; // detach → unregister the view synchronously
            leftover.Close();
        }
        Dispatcher.UIThread.RunJobs();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        Dispatcher.UIThread.RunJobs();

        var view = new AgentDemoView();
        // Set the window DataContext too, so the escape hatches' default (main-window) target resolves —
        // the nested-state P3 scenario is still exercised via AppState.UiState.ShowBrushSettings.
        var window = new Window { Width = 520, Height = 520, Title = "AgentDemo", Content = view, DataContext = view.ViewModel };
        window.Show();
        window.Activate();
        Dispatcher.UIThread.RunJobs();
        global::Avalonia.Headless.AvaloniaHeadlessPlatform.ForceRenderTimerTick();
        Dispatcher.UIThread.RunJobs();
        return (window, view, (AgentDemoViewModel)view.ViewModel!);
    }

    private static void ResetDemo(Window window)
    {
        window.Content = null;
        window.Close();
        Dispatcher.UIThread.RunJobs();
    }

    private static Rect SliderBounds(Window window)
    {
        var slider = AgentToolContext.FindControl("RawSlider")!;
        Assert.NotNull(slider);
        var bounds = VisualBoundsHelper.GetClientBounds(slider, window);
        Assert.NotNull(bounds);
        return bounds!.Value;
    }

    private static (bool IsError, string Text, bool HasImage) Unpack(CallToolResult result)
    {
        var text = string.Join("\n", result.Content.OfType<TextContentBlock>().Select(b => b.Text));
        var hasImage = result.Content.OfType<ImageContentBlock>().Any();
        return (result.IsError is true, text, hasImage);
    }

    // ── P1: real pointer input drives a raw-pointer control ──────────────────────────────────────

    [AvaloniaFact]
    public async Task P1_drag_scrubs_raw_slider_with_no_automation_peer()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            Assert.Equal(0, vm.Value);

            var b = SliderBounds(window);
            var y = b.Center.Y;
            var from = new Point(b.X + b.Width * 0.1, y);
            var to = new Point(b.X + b.Width * 0.8, y);

            var result = await InteractionTools.Drag(from.X, from.Y, to.X, to.Y, "Left", 12, 0, null, null);
            Dispatcher.UIThread.RunJobs();

            Assert.Contains("drag Left", result);
            // The custom Border slider scrubbed to ~80% purely from synthesized real pointer input.
            Assert.True(vm.Value > 50, $"expected value scrubbed past 50, got {vm.Value}. ({result})");
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task P1_tap_enters_text_edit_mode_without_a_peer()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            Assert.False(vm.IsEditing);

            var b = SliderBounds(window);
            var result = await InteractionTools.Tap(b.Center.X, b.Center.Y, null, null, null);
            Dispatcher.UIThread.RunJobs();

            Assert.Contains("tap Left", result);
            Assert.True(vm.IsEditing, $"tap should have entered edit mode. ({result})");
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task P1_escape_and_enter_reach_focused_textbox()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            var editor = (TextBox)AgentToolContext.FindControl("ValueEditor")!;
            editor.Focus();
            Dispatcher.UIThread.RunJobs();
            Assert.True(editor.IsFocused, "editor should be focused before pressing keys.");

            var escape = await InteractionTools.Invoke(null, "key", "Escape");
            Dispatcher.UIThread.RunJobs();
            Assert.Equal("Escape", vm.LastKey);

            var enter = await InteractionTools.Invoke(null, "key", "Enter");
            Dispatcher.UIThread.RunJobs();
            // Avalonia parses Enter to Key.Return.
            Assert.True(vm.LastKey is "Enter" or "Return", $"expected Enter/Return, got {vm.LastKey}");

            Assert.Contains("real input", escape);
            Assert.Contains("real input", enter);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task P1_pointer_press_move_release_gesture_scrubs()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            var b = SliderBounds(window);
            var y = b.Center.Y;

            await InteractionTools.PointerPress(b.X + b.Width * 0.1, y, "Left", null, null);
            await InteractionTools.PointerMove(b.X + b.Width * 0.5, y, null, null);
            await InteractionTools.PointerMove(b.X + b.Width * 0.9, y, null, null);
            var release = await InteractionTools.PointerRelease(b.X + b.Width * 0.9, y, "Left", null, null);
            Dispatcher.UIThread.RunJobs();

            Assert.Contains("pointer release", release);
            Assert.True(vm.Value > 50, $"press/move/release gesture should scrub the slider, got {vm.Value}.");
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task ClickAt_uses_real_pointer_by_default()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            var b = SliderBounds(window);
            var result = await InteractionTools.ClickAt(b.Center.X, b.Center.Y, null, null);
            Dispatcher.UIThread.RunJobs();

            Assert.Contains("real pointer", result);
            // A click at the slider (no scrub) is a tap → edit mode, proving real pointer delivery.
            Assert.True(vm.IsEditing);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    // ── P2: structured, actionable escape-hatch errors ───────────────────────────────────────────

    [AvaloniaFact]
    public async Task P2_invoke_command_bad_path_returns_structured_error()
    {
        var (window, _, _) = ShowDemo();
        try
        {
            var result = await InteractionTools.InvokeCommandTool(null, "ViewCommands.ToggleBrushSettingsCommand", null);

            Assert.DoesNotContain("An error occurred", result);
            Assert.Contains("no member 'ViewCommands'", result);
            Assert.Contains("AgentDemoViewModel", result);
            Assert.Contains("Available ICommand properties", result);
            Assert.Contains("ToggleBrushSettingsCommand", result);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task P2_invoke_command_good_path_executes()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            Assert.False(vm.AppState.UiState.ShowBrushSettings);
            var result = await InteractionTools.InvokeCommandTool(null, "ToggleBrushSettingsCommand", null);
            Dispatcher.UIThread.RunJobs();

            Assert.Contains("Executed command", result);
            Assert.True(vm.AppState.UiState.ShowBrushSettings);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    // ── P3: list_bindable + deep-path targeting reaches nested app state ──────────────────────────

    [AvaloniaFact]
    public async Task P3_list_bindable_reveals_nested_state_and_deep_set_opens_popup()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            var bindable = await InteractionTools.ListBindable(null);
            Assert.Contains("AppState", bindable);
            Assert.Contains("ToggleBrushSettingsCommand", bindable);
            Assert.Contains("Sub-objects", bindable);

            // A wrong shallow path is diagnostic about what actually exists.
            var wrong = await InteractionTools.SetViewModel(null, "ShowBrushSettings", "true");
            Assert.Contains("no member 'ShowBrushSettings'", wrong);

            // The deep path resolves and flips the real state, opening the bound popup.
            var deep = await InteractionTools.SetViewModel(null, "AppState.UiState.ShowBrushSettings", "true");
            Dispatcher.UIThread.RunJobs();
            Assert.Contains("ShowBrushSettings", deep);
            Assert.True(vm.AppState.UiState.ShowBrushSettings);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    // ── P4: one coordinate frame; visual-tree center round-trips through hit_test ────────────────

    [AvaloniaFact]
    public async Task P4_visual_tree_center_round_trips_through_hit_test()
    {
        var (window, _, _) = ShowDemo();
        try
        {
            var tree = await InspectionTools.GetVisualTree(null, null, "RawSlider");
            Assert.Contains("#RawSlider", tree);
            Assert.Contains("abs=", tree);
            Assert.Contains("center=", tree);

            // Take the slider's absolute center (the frame the tree reports) and hit_test it.
            var b = SliderBounds(window);
            var hit = await InspectionTools.HitTest(b.Center.X, b.Center.Y, null);

            Assert.Contains("#RawSlider", hit);
            // P7: the topmost control there is a raw Border, so the drivability hint says pointer-only.
            Assert.Contains("raw-pointer-only", hit);
        }
        finally
        {
            ResetDemo(window);
        }
    }

    // ── P5 + P6: closed popup is guided open, then captured with a rendered frame ─────────────────

    [AvaloniaFact]
    public async Task P5_P6_closed_popup_hint_then_open_and_capture()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            // P5: screenshotting the closed popup is a guided dead-end, not a bare "zero size".
            var closed = Unpack(await InspectionTools.ScreenshotControl("BrushSettingsPopup", null));
            Assert.True(closed.IsError);
            Assert.Contains("open_popup", closed.Text);

            // Regression: a container that merely *contains* the closed popup is NOT mistaken for one —
            // it captures normally.
            var container = Unpack(await InspectionTools.ScreenshotControl("DemoRoot", null));
            Assert.False(container.IsError, container.Text);
            Assert.True(container.HasImage);

            // open_popup opens it in one call.
            var opened = await InteractionTools.OpenPopup("BrushSettingsPopup");
            Dispatcher.UIThread.RunJobs();
            Assert.Contains("Opened popup", opened);
            Assert.True(vm.AppState.UiState.ShowBrushSettings);

            // P6: capturing right after opening yields a rendered (non-degenerate) frame.
            var shot = Unpack(await InspectionTools.ScreenshotControl("BrushSettings", null));
            Assert.False(shot.IsError, shot.Text);
            Assert.True(shot.HasImage);

            var frame = ControlScreenshotService.CaptureTopLevelStable(window);
            Assert.False(ControlScreenshotService.IsDegenerate(frame.Bgra), "captured frame should not be empty/flat.");
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task Popup_opens_via_click_trigger_too()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            var b = VisualBoundsHelper.GetClientBounds(AgentToolContext.FindControl("OpenByClick")!, window)!.Value;
            await InteractionTools.Tap(b.Center.X, b.Center.Y, null, null, null);
            Dispatcher.UIThread.RunJobs();

            Assert.True(vm.AppState.UiState.ShowBrushSettings, "clicking the trigger button should open the popup.");
        }
        finally
        {
            ResetDemo(window);
        }
    }

    // ── Every remaining tool runs green over the demo ────────────────────────────────────────────

    [AvaloniaFact]
    public async Task All_readonly_tools_run_over_demo()
    {
        var (window, _, _) = ShowDemo();
        try
        {
            Assert.Contains("Windows/top-levels", await InspectionTools.GetAppInfo());
            Assert.Contains("#RawSlider", await InspectionTools.GetVisualTree(null, null, null));
            Assert.Contains("Frame:", await InspectionTools.GetVisualTree(null, null, null));
            Assert.Contains("AgentDemoView", await InspectionTools.ListComponents());
            Assert.Contains("Bounds:", await InspectionTools.GetLayout("RawSlider"));
            Assert.NotNull(await InspectionTools.LayoutAudit(null));
            Assert.Contains("Button", await InspectionTools.FindText("Open (command)"));
            Assert.Contains("RawSlider", await InspectionTools.GetProperties("RawSlider", null));
            Assert.NotNull(await InspectionTools.GetPropertySources("RawSlider", null));
            Assert.Contains("AgentDemoViewModel", await InspectionTools.GetDataContext("DemoRoot", 2));
            Assert.Contains("AgentDemoView", await InspectionTools.GetSource("RawSlider"));
            Assert.Equal("UI thread is idle.", await InspectionTools.WaitIdle());
            Assert.Contains("RawSlider", await InspectionTools.WaitFor("RawSlider", "exists", 2000));
            Assert.NotNull(InspectionTools.GetErrors(null));

            var window1 = Unpack(await InspectionTools.ScreenshotWindow(null, false, null));
            Assert.False(window1.IsError, window1.Text);
            Assert.True(window1.HasImage);

            var annotated = Unpack(await InspectionTools.ScreenshotWindow(null, true, null));
            Assert.True(annotated.HasImage);

            var listed = await InspectionTools.ListScreenshots();
            Assert.Contains("screenshot", listed);

            var compared = Unpack(await InspectionTools.CompareScreenshots(null, null));
            Assert.False(compared.IsError, compared.Text);

            var highlighted = Unpack(await InspectionTools.Highlight("RawSlider", null, "#00A0FF"));
            Assert.True(highlighted.HasImage);
            Unpack(await InspectionTools.Highlight(null, "clear", null));
        }
        finally
        {
            ResetDemo(window);
        }
    }

    [AvaloniaFact]
    public async Task Remaining_interaction_tools_run_over_demo()
    {
        var (window, _, vm) = ShowDemo();
        try
        {
            // set_theme / set_window_size
            Assert.Contains("Theme", await InteractionTools.SetTheme("Dark"));
            Assert.Contains("Resized", await InteractionTools.SetWindowSize(460, 460, null));

            // invoke: focus, set, key, type against named controls
            Assert.Contains("Focused", await InteractionTools.Invoke("OpenByCommand", "focus", null));
            Assert.Contains("Invoked", await InteractionTools.Invoke("OpenByCommand", "invoke", null));
            Dispatcher.UIThread.RunJobs();
            Assert.True(vm.AppState.UiState.ShowBrushSettings); // the command ran

            // type into the (focused) editor via real text input
            var editor = (TextBox)AgentToolContext.FindControl("ValueEditor")!;
            editor.Focus();
            var typed = await InteractionTools.Invoke("ValueEditor", "type", "42");
            Dispatcher.UIThread.RunJobs();
            Assert.Contains("Typed", typed);

            // list_bindable by control name
            Assert.Contains("Bindable surface", await InteractionTools.ListBindable("DemoRoot"));
        }
        finally
        {
            ResetDemo(window);
        }
    }
}
