namespace Declarative.Avalonia.AgentTools;

/// <summary>
/// Configuration for the in-process agent inspector MCP server.
/// </summary>
public sealed class AgentInspectorOptions
{
    /// <summary>
    /// The only address the server ever binds to. The inspector is loopback-only by design: it can
    /// return screenshots that may contain sensitive data, and it is meant for local development.
    /// </summary>
    public const string LoopbackAddress = "127.0.0.1";

    /// <summary>
    /// The loopback TCP port the MCP HTTP/SSE endpoint listens on. Default: 5599.
    /// </summary>
    public int Port { get; set; } = 5599;

    /// <summary>
    /// Enables the tier-2 remote-control tools (<c>invoke</c>, <c>set_window_size</c>, <c>set_theme</c>,
    /// <c>click_at</c>, <c>set_view_model</c>, <c>invoke_command</c>) — click / select / set value / focus /
    /// resize / switch theme, plus writing view-model state and running commands directly. This is a
    /// remote-control surface, so it is <see langword="false"/> by default and must be opted into explicitly.
    /// </summary>
    public bool EnableInteraction { get; set; }

    /// <summary>
    /// Records the <c>file:line</c> where each named control is declared (via <c>.Name(...)</c>) so
    /// <c>get_source</c> can point at the exact line. Off by default because it touches a hot construction
    /// path; enable it only while iterating with an agent.
    /// </summary>
    public bool EnableSourceTagging { get; set; }

    /// <summary>
    /// The MCP endpoint URL the server listens on, derived from <see cref="LoopbackAddress"/> and
    /// <see cref="Port"/>.
    /// </summary>
    public string EndpointUrl => $"http://{LoopbackAddress}:{Port}";
}
