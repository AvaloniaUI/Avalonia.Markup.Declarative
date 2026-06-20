using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Headless.XUnit;
using Avalonia.Logging;
using Avalonia.Markup.Declarative;
using Avalonia.Markup.Declarative.Diagnostics;
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
