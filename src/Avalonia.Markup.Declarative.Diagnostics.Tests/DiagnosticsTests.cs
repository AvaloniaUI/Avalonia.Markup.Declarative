using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Headless.XUnit;
using Avalonia.Logging;
using Avalonia.Markup.Declarative;
using Avalonia.Markup.Declarative.Diagnostics;
using Avalonia.Media;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Diagnostics.Tests;

public class DiagnosticsTests
{
    private static readonly byte[] PngSignature = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };

    // Hosts the view in a shown window so theme templates are applied and every control gets real
    // layout bounds (a detached measure/arrange never applies templated control templates).
    private static (Window Window, SampleView View) ShowSampleView()
    {
        var view = new SampleView();
        var window = new Window
        {
            Width = 400,
            Height = 300,
            Content = view
        };

        window.Show();
        Dispatcher.UIThread.RunJobs();
        return (window, view);
    }

    private static void AssertIsPng(byte[] bytes)
    {
        Assert.NotNull(bytes);
        Assert.True(bytes.Length > PngSignature.Length, "PNG output is empty.");
        Assert.Equal(PngSignature, bytes.Take(PngSignature.Length).ToArray());
    }

    [AvaloniaFact]
    public void DumpVisualTree_includes_names_and_nonzero_bounds()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var dump = VisualTreeInspector.DumpVisualTree(view);

            Assert.Contains("TextBlock", dump);
            Assert.Contains("#Title", dump);
            Assert.Contains("Button", dump);
            Assert.Contains("#Go", dump);
            // Bounds are rendered and no visible node collapsed to zero size.
            Assert.Contains("w=", dump);
            Assert.DoesNotContain("[zero-size]", dump);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void CaptureControlPng_produces_valid_png()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var png = ControlScreenshotService.CaptureControlPng(view);
            AssertIsPng(png);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void CaptureTopLevelPng_produces_valid_png()
    {
        var window = new Window
        {
            Width = 320,
            Height = 240,
            Content = new SampleView()
        };

        window.Show();
        Dispatcher.UIThread.RunJobs();

        try
        {
            var png = ControlScreenshotService.CaptureTopLevelPng(window);
            AssertIsPng(png);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DescribeLayout_reports_bounds_alignment_and_ancestor_chain()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var go = ControlLocator.FindByName(view, "Go")!;
            var report = LayoutInspector.DescribeLayout(go);

            Assert.Contains("Button #Go", report);
            Assert.Contains("Bounds:", report);
            Assert.Contains("Window-rel:", report);   // resolved because the control is in a window
            Assert.Contains("DesiredSize:", report);
            Assert.Contains("Alignment:", report);
            Assert.Contains("Visibility:", report);
            // The ancestor chain names the StackPanel that arranged the button.
            Assert.Contains("Ancestors (root", report);
            Assert.Contains("StackPanel", report);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DescribeLayout_reports_requested_size_alignment_and_margin()
    {
        var view = new LayoutSampleView();
        var window = new Window { Width = 400, Height = 300, Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        try
        {
            var sized = ControlLocator.FindByName(view, "Sized")!;
            var report = LayoutInspector.DescribeLayout(sized);

            Assert.Contains("Width=120", report);
            Assert.Contains("Height=40", report);
            Assert.Contains("Horizontal=Left", report);
            Assert.Contains("5,6,7,8", report); // margin l,t,r,b
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void FindAllByType_returns_controls_of_a_type()
    {
        var view = new SampleView();
        view.Initialize();

        var buttons = ControlLocator.FindAllByType(view, "Button");
        var missing = ControlLocator.FindAllByType(view, "NoSuchType");

        Assert.Single(buttons);
        Assert.IsType<Button>(buttons[0]);
        Assert.Empty(missing);
    }

    [AvaloniaFact]
    public void Highlight_adds_a_frame_and_clear_removes_it()
    {
        ControlHighlightService.Clear(); // isolate from any leftover state

        var (window, view) = ShowSampleView();
        try
        {
            var go = ControlLocator.FindByName(view, "Go")!;

            var added = ControlHighlightService.Highlight(new[] { go });
            Assert.Single(added);
            Assert.True(ControlHighlightService.HasActiveHighlights);

            // The overlay is renderable: a screenshot still produces a valid PNG.
            AssertIsPng(ControlScreenshotService.CaptureTopLevelPng(window));

            var removed = ControlHighlightService.Clear();
            Assert.Equal(1, removed);
            Assert.False(ControlHighlightService.HasActiveHighlights);
        }
        finally
        {
            ControlHighlightService.Clear();
            window.Close();
        }
    }

    [AvaloniaFact]
    public void LayoutAuditor_reports_off_screen_control()
    {
        var view = new BrokenLayoutView();
        var window = new Window { Width = 400, Height = 300, Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        try
        {
            var findings = LayoutAuditor.Audit(view);
            Assert.Contains(findings, f => f.Kind == "off-screen" && f.Control.Name == "Off");
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void LayoutAuditor_finds_nothing_in_a_clean_view()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var findings = LayoutAuditor.Audit(view);
            Assert.Empty(findings);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DescribeProperties_lists_state_and_local_values()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var go = (Button)ControlLocator.FindByName(view, "Go")!;
            go.Background = Brushes.Red;

            var all = PropertyInspector.DescribeProperties(go);
            Assert.Contains("Button #Go", all);
            Assert.Contains("State:", all);
            Assert.Contains("Background", all);

            var named = PropertyInspector.DescribeProperties(go, new[] { "Background" });
            Assert.Contains("Background = ", named);
            Assert.Contains("Missing = <not found>", PropertyInspector.DescribeProperties(go, new[] { "Missing" }));
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DumpVisualTree_filter_prunes_nonmatching_branches()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var dump = VisualTreeInspector.DumpVisualTree(view, new VisualTreeDumpOptions { Filter = "Go" });
            Assert.Contains("#Go", dump);
            Assert.DoesNotContain("#Title", dump);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DumpVisualTree_maxDepth_limits_traversal()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var shallow = VisualTreeInspector.DumpVisualTree(view, new VisualTreeDumpOptions { MaxDepth = 0 });
            Assert.DoesNotContain("StackPanel", shallow);

            var deeper = VisualTreeInspector.DumpVisualTree(view, new VisualTreeDumpOptions { MaxDepth = 1 });
            Assert.Contains("StackPanel", deeper);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void RuntimeErrorSink_captures_dispatcher_exception()
    {
        DiagnosticsErrorLog.Clear();
        RuntimeErrorSink.Install();

        void Swallow(object? s, DispatcherUnhandledExceptionEventArgs e) => e.Handled = true;
        Dispatcher.UIThread.UnhandledException += Swallow;
        try
        {
            Dispatcher.UIThread.Post(() => throw new InvalidOperationException("boom from handler"));
            Dispatcher.UIThread.RunJobs();

            var entries = DiagnosticsErrorLog.GetEntries();
            Assert.Contains(entries, e =>
                e.Category == DiagnosticCategory.Runtime &&
                e.Message.Contains("boom from handler", StringComparison.Ordinal));
        }
        finally
        {
            Dispatcher.UIThread.UnhandledException -= Swallow;
            RuntimeErrorSink.Uninstall();
        }
    }

    [AvaloniaFact]
    public void FindAllByText_matches_visible_text()
    {
        var view = new SampleView();
        view.Initialize();

        Assert.Single(ControlLocator.FindAllByText(view, "Hello"));
        Assert.Contains(ControlLocator.FindAllByText(view, "Go"), c => c is Button);
        Assert.Empty(ControlLocator.FindAllByText(view, "nonexistent"));
    }

    [AvaloniaFact]
    public void HitTester_returns_control_at_point()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var go = ControlLocator.FindByName(view, "Go")!;
            var center = go.TranslatePoint(new Point(go.Bounds.Width / 2, go.Bounds.Height / 2), window)!.Value;

            var description = HitTester.Describe(window, center);

            Assert.True(description.Contains("#Go"), description);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void PopupLocator_finds_open_popup_content()
    {
        var popup = new Popup { Child = new TextBlock { Text = "PopupContent", Name = "PopupText" } };
        var panel = new StackPanel();
        panel.Children.Add(new Button { Content = "Owner" });
        panel.Children.Add(popup);
        var window = new Window { Width = 300, Height = 200, Content = panel };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        popup.IsOpen = true;
        Dispatcher.UIThread.RunJobs();
        try
        {
            var popups = PopupLocator.GetOpenPopups(new Visual[] { window });
            Assert.Contains(popups, p => p.ContentRoot is TextBlock { Text: "PopupContent" });
        }
        finally
        {
            popup.IsOpen = false;
            window.Close();
        }
    }

    [AvaloniaFact]
    public void DataContextInspector_renders_properties_and_nested_depth()
    {
        var report = DataContextInspector.Describe(new SampleViewModel(), 1);
        Assert.Contains("SampleViewModel", report);
        Assert.Contains("Title = hello", report);
        Assert.Contains("Count = 3", report);
        Assert.Contains("Items", report);

        var deep = DataContextInspector.Describe(new SampleViewModel { Child = new SampleViewModel { Title = "kid" } }, 2);
        Assert.Contains("kid", deep);

        Assert.Equal("DataContext is null.", DataContextInspector.Describe(null));
    }

    [AvaloniaFact]
    public void ComponentSourceLocator_reports_owning_and_nesting_components()
    {
        var outer = new OuterView();
        var window = new Window { Width = 300, Height = 200, Content = outer };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        try
        {
            var go = ControlLocator.FindByName(window, "Go")!;
            var source = ComponentSourceLocator.Describe(go);

            Assert.Contains("SampleView", source);
            Assert.Contains("OuterView", source);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void Highlight_remove_clears_only_its_own_batch()
    {
        ControlHighlightService.Clear();

        var (window, view) = ShowSampleView();
        try
        {
            var go = ControlLocator.FindByName(view, "Go")!;
            var title = ControlLocator.FindByName(view, "Title")!;

            var batch1 = ControlHighlightService.Highlight(new[] { go });
            var batch2 = ControlHighlightService.Highlight(new[] { title });
            Assert.Single(batch1);
            Assert.Single(batch2);

            Assert.Equal(1, ControlHighlightService.Remove(batch1));
            Assert.True(ControlHighlightService.HasActiveHighlights); // batch2 remains
        }
        finally
        {
            ControlHighlightService.Clear();
            window.Close();
        }
    }

    [AvaloniaFact]
    public void ScreenshotStore_compare_detects_changes_and_produces_diff()
    {
        ScreenshotStore.Clear();
        var (window, view) = ShowSampleView();
        try
        {
            var before = ScreenshotStore.Add("before", ControlScreenshotService.CaptureTopLevel(window));

            // Identical re-capture ⇒ no meaningful change.
            var same = ScreenshotStore.Add("same", ControlScreenshotService.CaptureTopLevel(window));
            var unchanged = ScreenshotStore.Compare(before, same)!;
            Assert.False(unchanged.SizeMismatch);
            Assert.True(unchanged.ChangedFraction < 0.01, $"expected ~0 change, got {unchanged.ChangedFraction}");

            // Mutate the UI, capture again ⇒ pixels change and a diff PNG is produced.
            var go = (Button)ControlLocator.FindByName(view, "Go")!;
            go.Background = Brushes.Magenta;
            Dispatcher.UIThread.RunJobs();

            var after = ScreenshotStore.Add("after", ControlScreenshotService.CaptureTopLevel(window));
            var changed = ScreenshotStore.Compare(before, after)!;
            Assert.False(changed.SizeMismatch);
            Assert.True(changed.ChangedPixels > 0);
            Assert.NotNull(changed.DiffPng);
            AssertIsPng(changed.DiffPng!);
            Assert.NotNull(changed.ChangedBounds);
        }
        finally
        {
            ScreenshotStore.Clear();
            window.Close();
        }
    }

    [AvaloniaFact]
    public void PropertySourceInspector_reports_local_source()
    {
        var (window, view) = ShowSampleView();
        try
        {
            var go = (Button)ControlLocator.FindByName(view, "Go")!;
            go.Background = Brushes.Teal;

            var report = PropertySourceInspector.Describe(go, "Background");
            Assert.Contains("Background", report);
            Assert.Contains("LocalValue", report);
        }
        finally
        {
            window.Close();
        }
    }

    [AvaloniaFact]
    public void AgentSourceTagging_records_declaration_site_when_enabled()
    {
        AgentSourceTagging.Enabled = true;
        try
        {
            var view = new SampleView();
            view.Initialize();

            var go = ControlLocator.FindByName(view, "Go")!;
            var source = AgentSourceTagging.GetSource(go);

            Assert.NotNull(source);
            Assert.Contains("SampleViews.cs", source!);
            Assert.Contains("Declared at:", ComponentSourceLocator.Describe(go));
        }
        finally
        {
            AgentSourceTagging.Enabled = false;
        }
    }

    [AvaloniaFact]
    public void FindByName_resolves_named_control()
    {
        var view = new SampleView();
        view.Initialize();

        var go = ControlLocator.FindByName(view, "Go");
        var missing = ControlLocator.FindByName(view, "DoesNotExist");

        Assert.NotNull(go);
        Assert.IsType<Button>(go);
        Assert.Null(missing);
    }

    [AvaloniaFact]
    public void Build_exception_is_recorded_in_the_error_log()
    {
        DiagnosticsErrorLog.Clear();

        Assert.Throws<ViewBuildingException>(() => new FailingView().Initialize());

        var entries = DiagnosticsErrorLog.GetEntries();
        Assert.Contains(entries, e =>
            e.Category == DiagnosticCategory.Build &&
            e.Message.Contains("boom from build", StringComparison.Ordinal));
    }

    [AvaloniaFact]
    public void Binding_log_sink_captures_binding_errors_with_rendered_message()
    {
        DiagnosticsErrorLog.Clear();
        BindingErrorSink.Install();
        try
        {
            // Drive the sink the way Avalonia does for a binding error.
            Logger.Sink!.Log(
                LogEventLevel.Warning,
                LogArea.Binding,
                new TextBox { Name = "Field" },
                "Error in binding to {Target}: {Message}",
                "Field.Text",
                "no such property");

            var entries = DiagnosticsErrorLog.GetEntries();
            Assert.Contains(entries, e =>
                e.Category == DiagnosticCategory.Binding &&
                e.Message.Contains("Field.Text", StringComparison.Ordinal) &&
                e.Message.Contains("no such property", StringComparison.Ordinal));
        }
        finally
        {
            BindingErrorSink.Uninstall();
        }
    }

    [AvaloniaFact]
    public void Broken_binding_conversion_is_captured_by_the_buffer()
    {
        DiagnosticsErrorLog.Clear();
        BindingErrorSink.Install();
        try
        {
            var vm = new UnconvertibleViewModel();
            var textBox = new TextBox();

            // Bind a string property to an object value with no usable conversion: the auto-converter
            // throws during evaluation, which Avalonia reports through the binding pipeline.
            textBox._setCompiledBinding(TextBox.TextProperty, vm, (UnconvertibleViewModel x) => x.Payload);

            var window = new Window { Width = 100, Height = 100, Content = textBox };
            window.Show();
            Dispatcher.UIThread.RunJobs();

            try
            {
                var entries = DiagnosticsErrorLog.GetEntries();
                Assert.NotEmpty(entries);
            }
            finally
            {
                window.Close();
            }
        }
        finally
        {
            BindingErrorSink.Uninstall();
        }
    }
}
