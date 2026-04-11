using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Declarative;

[assembly: GenerateMarkupExtensionsForAssembly(typeof(Avalonia.Markup.Declarative.Tests.ControlsTests.GeneratedDiagnosticsControl))]

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class GeneratedDiagnosticsControl : Control
{
    public static readonly StyledProperty<int> ExplosiveProperty =
        AvaloniaProperty.Register<GeneratedDiagnosticsControl, int>(nameof(Explosive));

    public int Explosive
    {
        get => GetValue(ExplosiveProperty);
        set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Negative values are not allowed.");
            }

            SetValue(ExplosiveProperty, value);
        }
    }
}

public class BrokenBindingDiagnosticsControl : Control
{
    public static readonly StyledProperty<int> BrokenBindingProperty = null!;

    public int BrokenBinding { get; set; }
}

public class GeneratedDiagnosticsViewModel
{
    public int Explosive { get; set; }
}

public sealed class DirectSetterFailureView : ViewBase
{
    protected override object Build() =>
        new GeneratedDiagnosticsControl()
            .Explosive(-1);
}

public sealed class RawBuildFailureView : ViewBase
{
    protected override object Build() => throw new InvalidOperationException("Build exploded.");
}

public class BuildDiagnosticsTests : AvaloniaTestBase
{
    [Fact]
    public void Generated_property_setter_reports_caller_file_and_line()
    {
        var view = new DirectSetterFailureView();

        var exception = Assert.Throws<ViewBuildingException>(() => view.Initialize());

        Assert.Contains("UI Build Error on GeneratedDiagnosticsControl.", exception.Message);
        Assert.Contains("BuildDiagnosticsTests.cs", exception.Message);
        Assert.Matches(@"Line: [1-9]\d*", exception.Message);
        Assert.Contains("Negative values are not allowed.", exception.Message);
    }

    [Fact]
    public void Generated_binding_setter_reports_caller_file_and_line()
    {
        var source = new GeneratedDiagnosticsViewModel { Explosive = 1 };

        var exception = Assert.Throws<ViewBuildingException>(() =>
            new BrokenBindingDiagnosticsControl()
                .BrokenBinding(source, state => state.Explosive));

        Assert.Contains("UI Build Error on BrokenBindingDiagnosticsControl.", exception.Message);
        Assert.Contains("BuildDiagnosticsTests.cs", exception.Message);
        Assert.Matches(@"Line: [1-9]\d*", exception.Message);
        Assert.NotNull(exception.InnerException);
    }

    [Fact]
    public void ViewBase_wraps_unhandled_build_exceptions()
    {
        var view = new RawBuildFailureView();

        var exception = Assert.Throws<ViewBuildingException>(() => view.Initialize());

        Assert.Contains("Build error in RawBuildFailureView", exception.Message);
        Assert.NotNull(exception.InnerException);
        Assert.IsType<InvalidOperationException>(exception.InnerException);
        Assert.Equal("Build exploded.", exception.InnerException!.Message);
    }
}