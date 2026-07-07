using System;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;

namespace Avalonia.Markup.Declarative.Diagnostics.Tests;

/// <summary>
/// A simple named view used by the diagnostics tests. Built with hand-written core extensions only
/// (no generated extensions), so the tests do not depend on the source generator.
/// </summary>
public sealed class SampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel().Children(
            new TextBlock { Text = "Hello, agent" }.Name("Title", Scope),
            new Button { Content = "Go" }.Name("Go", Scope));
}

/// <summary>
/// A view with a control carrying explicit layout properties (fixed size, alignment, margin), used to
/// exercise the layout inspector's reporting of requested size / alignment / margin.
/// </summary>
public sealed class LayoutSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel().Children(
            new Button
            {
                Content = "Sized",
                Width = 120,
                Height = 40,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(5, 6, 7, 8),
            }.Name("Sized", Scope));
}

/// <summary>
/// A view with a control positioned far outside the window, to exercise the layout auditor's
/// off-screen detection.
/// </summary>
public sealed class BrokenLayoutView : ViewBase
{
    protected override object Build()
    {
        var off = new Button { Content = "Off" }.Name("Off", Scope);
        Canvas.SetLeft(off, 5000);
        Canvas.SetTop(off, 5);
        return new Canvas().Children(off);
    }
}

/// <summary>A view whose build always throws, to exercise build-error capture.</summary>
public sealed class FailingView : ViewBase
{
    protected override object Build() => throw new InvalidOperationException("boom from build");
}

/// <summary>View model whose property cannot be converted to a string, to force a converter failure.</summary>
public sealed class UnconvertibleViewModel
{
    public object Payload { get; set; } = new();
}

/// <summary>A plain view model for exercising the data-context inspector.</summary>
public sealed class SampleViewModel
{
    public string Title { get; set; } = "hello";
    public int Count { get; set; } = 3;
    public string[] Items { get; set; } = { "a", "b" };
    public SampleViewModel? Child { get; set; }
}

/// <summary>A component that nests another component, to exercise the source locator's nesting report.</summary>
public sealed class OuterView : ViewBase
{
    protected override object Build() =>
        new StackPanel().Children(new SampleView());
}
