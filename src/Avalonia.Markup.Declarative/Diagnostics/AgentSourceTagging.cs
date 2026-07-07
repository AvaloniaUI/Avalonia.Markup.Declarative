using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Opt-in tagging that records the source location (<c>file:line</c>) where a control was named, so an
/// agent can jump straight to the exact line that declares a control — not just the component class.
/// </summary>
/// <remarks>
/// <para>
/// Off by default. When <see cref="Enabled"/> is set (via <c>UseAgentInspector(o =&gt; o.EnableSourceTagging
/// = true)</c>), the <c>.Name(name, scope)</c> extension stamps the caller's file/line onto the control
/// via <see cref="SourceProperty"/>. It only affects controls you name, and only stores a short string,
/// so the cost is minimal — but it is opt-in because it touches a hot construction path.
/// </para>
/// <para>Enable the flag before any views are built (i.e. at app startup).</para>
/// </remarks>
public static class AgentSourceTagging
{
    /// <summary>Whether <c>.Name(...)</c> records the caller's source location. Off by default.</summary>
    public static bool Enabled { get; set; }

    // A non-static owner type is required for attached-property registration (a static class can't be a
    // type argument); this marker only names the property's owner.
    private sealed class Owner;

    /// <summary>Attached property holding a control's <c>file:line</c> declaration site, when tagged.</summary>
    public static readonly AttachedProperty<string?> SourceProperty =
        AvaloniaProperty.RegisterAttached<Owner, Control, string?>("Source");

    /// <summary>Gets the recorded source location of <paramref name="control"/>, or null.</summary>
    public static string? GetSource(Control control) => control.GetValue(SourceProperty);

    /// <summary>Records the source location of <paramref name="control"/>.</summary>
    public static void SetSource(Control control, string? value) => control.SetValue(SourceProperty, value);
}
