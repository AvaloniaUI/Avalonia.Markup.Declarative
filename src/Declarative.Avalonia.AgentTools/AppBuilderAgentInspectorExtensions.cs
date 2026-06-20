using System;
using Avalonia;

namespace Declarative.Avalonia.AgentTools;

/// <summary>
/// <see cref="AppBuilder"/> extensions for enabling the in-process agent inspector.
/// </summary>
public static class AppBuilderAgentInspectorExtensions
{
    private static AgentInspectorServer? _server;

    /// <summary>
    /// Starts the in-process MCP agent inspector on a background thread, bound to loopback.
    /// </summary>
    /// <remarks>
    /// This method is an explicit opt-in and is the security gate: call it only in development, and
    /// wrap the call in <c>#if DEBUG</c> in your app so the AgentTools package never reaches a Release
    /// build. Calling it more than once is a no-op.
    /// </remarks>
    /// <param name="builder">The application builder.</param>
    /// <param name="configure">Optional configuration callback for <see cref="AgentInspectorOptions"/>.</param>
    /// <returns>The same <see cref="AppBuilder"/> for chaining.</returns>
    public static AppBuilder UseAgentInspector(this AppBuilder builder, Action<AgentInspectorOptions>? configure = null)
    {
        if (_server is not null)
            return builder;

        var options = new AgentInspectorOptions();
        configure?.Invoke(options);

        AgentToolContext.Options = options;

        // Capturing binding/converter errors is part of the inspector's job; install the log sink now.
        global::Avalonia.Markup.Declarative.Diagnostics.BindingErrorSink.Install();

        _server = new AgentInspectorServer(options);
        _server.Start();

        return builder;
    }
}
