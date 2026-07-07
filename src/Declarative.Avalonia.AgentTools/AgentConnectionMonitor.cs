using System;
using System.Threading;
using Avalonia.Threading;

namespace Declarative.Avalonia.AgentTools;

/// <summary>
/// Details of an agent connection status change.
/// </summary>
public sealed class AgentConnectionEventArgs : EventArgs
{
    internal AgentConnectionEventArgs(bool isConnected, long requestCount, string? lastActivity, DateTimeOffset timestampUtc)
    {
        IsConnected = isConnected;
        RequestCount = requestCount;
        LastActivity = lastActivity;
        TimestampUtc = timestampUtc;
    }

    /// <summary>Whether an agent is currently considered connected (active).</summary>
    public bool IsConnected { get; }

    /// <summary>Total number of agent requests observed since the app started.</summary>
    public long RequestCount { get; }

    /// <summary>The most recent activity (e.g. the request path), if known.</summary>
    public string? LastActivity { get; }

    /// <summary>When this status change occurred (UTC).</summary>
    public DateTimeOffset TimestampUtc { get; }
}

/// <summary>
/// Reports when an agent is talking to the inspector so an app can surface a live status (e.g. in the
/// window title, the way Chrome shows a "DevTools is connected" indicator).
/// </summary>
/// <remarks>
/// <para>
/// The MCP endpoint is stateless HTTP, so there is no long-lived socket to treat as the connection.
/// Instead this tracks <em>activity</em>: it becomes <see cref="IsConnected"/> on the first request and
/// returns to disconnected after <see cref="IdleTimeout"/> elapses with no further requests. That is the
/// useful signal for a status indicator — "an agent is actively driving the app".
/// </para>
/// <para>
/// Events are raised on the UI thread (marshaled via the Avalonia dispatcher), so handlers may touch the
/// UI directly. Subscribing does not require the inspector to be running; you can wire handlers before
/// <c>UseAgentInspector()</c>.
/// </para>
/// </remarks>
public static class AgentConnectionMonitor
{
    private static readonly object Gate = new();
    private static readonly TimeSpan PollInterval = TimeSpan.FromSeconds(1);

    private static Timer? _timer;
    private static bool _connected;
    private static long _requestCount;
    private static string? _lastActivity;
    private static DateTimeOffset _lastActivityUtc;
    private static TimeSpan _idleTimeout = TimeSpan.FromSeconds(10);

    /// <summary>
    /// How long without any request before the agent is considered disconnected. Default 10s; clamped to
    /// at least 1s.
    /// </summary>
    public static TimeSpan IdleTimeout
    {
        get { lock (Gate) return _idleTimeout; }
        set { lock (Gate) _idleTimeout = value < TimeSpan.FromSeconds(1) ? TimeSpan.FromSeconds(1) : value; }
    }

    /// <summary>Whether an agent is currently considered connected (active within <see cref="IdleTimeout"/>).</summary>
    public static bool IsConnected
    {
        get { lock (Gate) return _connected; }
    }

    /// <summary>Total number of agent requests observed since the app started.</summary>
    public static long RequestCount
    {
        get { lock (Gate) return _requestCount; }
    }

    /// <summary>Raised (on the UI thread) when an agent becomes active after being idle.</summary>
    public static event EventHandler<AgentConnectionEventArgs>? Connected;

    /// <summary>Raised (on the UI thread) when an agent goes idle past <see cref="IdleTimeout"/>.</summary>
    public static event EventHandler<AgentConnectionEventArgs>? Disconnected;

    /// <summary>Raised (on the UI thread) on any connection status transition.</summary>
    public static event EventHandler<AgentConnectionEventArgs>? StatusChanged;

    /// <summary>
    /// Records that an agent request was observed. Called by the inspector's request pipeline.
    /// </summary>
    internal static void NotifyActivity(string? activity)
    {
        var justConnected = false;
        lock (Gate)
        {
            _lastActivityUtc = DateTimeOffset.UtcNow;
            _requestCount++;
            _lastActivity = activity;

            if (!_connected)
            {
                _connected = true;
                justConnected = true;
            }

            _timer ??= new Timer(_ => CheckIdle(), null, PollInterval, PollInterval);
        }

        if (justConnected)
        {
            var args = Snapshot();
            Raise(Connected, args);
            Raise(StatusChanged, args);
        }
    }

    private static void CheckIdle()
    {
        var justDisconnected = false;
        lock (Gate)
        {
            if (_connected && DateTimeOffset.UtcNow - _lastActivityUtc >= _idleTimeout)
            {
                _connected = false;
                justDisconnected = true;
            }
        }

        if (justDisconnected)
        {
            var args = Snapshot();
            Raise(Disconnected, args);
            Raise(StatusChanged, args);
        }
    }

    private static AgentConnectionEventArgs Snapshot()
    {
        lock (Gate)
            return new AgentConnectionEventArgs(_connected, _requestCount, _lastActivity, DateTimeOffset.UtcNow);
    }

    private static void Raise(EventHandler<AgentConnectionEventArgs>? handler, AgentConnectionEventArgs args)
    {
        if (handler is null)
            return;

        try
        {
            if (Dispatcher.UIThread.CheckAccess())
                handler(null, args);
            else
                Dispatcher.UIThread.Post(() => handler(null, args));
        }
        catch (Exception)
        {
            // No dispatcher available (e.g. non-UI host) — fall back to a direct call.
            handler(null, args);
        }
    }
}
