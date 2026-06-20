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
    /// Enables the tier-2 <c>invoke</c> tool (click / set value / focus). This is a remote-control
    /// surface, so it is <see langword="false"/> by default and must be opted into explicitly.
    /// </summary>
    public bool EnableInteraction { get; set; }

    /// <summary>
    /// The MCP endpoint URL the server listens on, derived from <see cref="LoopbackAddress"/> and
    /// <see cref="Port"/>.
    /// </summary>
    public string EndpointUrl => $"http://{LoopbackAddress}:{Port}";
}
