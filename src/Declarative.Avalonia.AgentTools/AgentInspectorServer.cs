using System;
using System.Diagnostics;
using System.Threading;
using Declarative.Avalonia.AgentTools.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Declarative.Avalonia.AgentTools;

/// <summary>
/// Hosts the in-process MCP server (loopback HTTP/SSE via Kestrel) on a dedicated background thread.
/// </summary>
internal sealed class AgentInspectorServer
{
    private readonly AgentInspectorOptions _options;
    private readonly CancellationTokenSource _cts = new();
    private Thread? _thread;

    public AgentInspectorServer(AgentInspectorOptions options) => _options = options;

    public void Start()
    {
        _thread = new Thread(Run)
        {
            IsBackground = true,
            Name = "AgentInspectorServer"
        };
        _thread.Start();
    }

    public void Stop()
    {
        try
        {
            _cts.Cancel();
        }
        catch (ObjectDisposedException)
        {
        }
    }

    private void Run()
    {
        try
        {
            var builder = WebApplication.CreateBuilder();

            // Keep the GUI app's console quiet; the inspector is plumbing, not the app.
            builder.Logging.ClearProviders();
            builder.Logging.SetMinimumLevel(LogLevel.Warning);

            // Bind strictly to loopback.
            builder.WebHost.UseUrls(_options.EndpointUrl);

            var mcp = builder.Services
                .AddMcpServer()
                .WithHttpTransport(transport => transport.Stateless = true)
                .WithTools<InspectionTools>();

            // Tier-2 remote-control surface is registered only behind the explicit opt-in flag.
            if (_options.EnableInteraction)
                mcp.WithTools<InteractionTools>();

            var app = builder.Build();

            // Observe agent activity so the app can show a live "agent connected" status. Runs for every
            // request to the loopback endpoint; it only records a timestamp, so it adds no meaningful cost.
            app.Use(async (context, next) =>
            {
                AgentConnectionMonitor.NotifyActivity(context.Request.Path.Value);
                await next(context);
            });

            app.MapMcp();

            // Printed to both the debug output and stdout so it is visible under `dotnet watch`/`dotnet run`.
            var banner =
                $"[AgentInspector] MCP server listening on {_options.EndpointUrl} " +
                $"(add it to your agent's MCP client as a streamable-HTTP server).";
            Debug.WriteLine(banner);
            Console.WriteLine(banner);
            if (_options.EnableInteraction)
            {
                const string warning = "[AgentInspector] WARNING: interaction tools (invoke) are ENABLED.";
                Debug.WriteLine(warning);
                Console.WriteLine(warning);
            }

            // Observe the cancellation token so Stop() can shut the host down gracefully.
            // The IHost extension takes the token; WebApplication.RunAsync(string?) would shadow it.
            ((IHost)app).RunAsync(_cts.Token).GetAwaiter().GetResult();
        }
        catch (OperationCanceledException)
        {
            // Normal shutdown.
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[AgentInspector] failed to start on {_options.EndpointUrl}: {ex.Message}");
        }
    }
}
