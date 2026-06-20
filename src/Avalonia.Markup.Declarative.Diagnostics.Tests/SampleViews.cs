using System;
using Avalonia.Controls;
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
