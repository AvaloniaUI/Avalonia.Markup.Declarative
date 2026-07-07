using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Captures unhandled runtime exceptions into <see cref="DiagnosticsErrorLog"/> so an agent can see
/// crashes that happen <em>after</em> a view is built — the common case being an exception thrown
/// inside an event handler (a button click, a command) which never surfaces through the build-error
/// or binding pipelines.
/// </summary>
/// <remarks>
/// <para>
/// This is a pure <em>observer</em>: it records the exception and does nothing else. It never marks
/// the dispatcher exception as <c>Handled</c> and never calls <c>SetObserved()</c> on a faulted task,
/// so the app's own error behavior is completely unchanged. It only augments visibility.
/// </para>
/// <para>
/// Mirrors <see cref="BindingErrorSink"/>'s install/uninstall conventions and keeps the core
/// diagnostics surface dependency-free (Avalonia only).
/// </para>
/// </remarks>
public static class RuntimeErrorSink
{
    private static readonly object Gate = new();
    private static DispatcherUnhandledExceptionEventHandler? _dispatcherHandler;
    private static EventHandler<UnobservedTaskExceptionEventArgs>? _taskHandler;

    /// <summary>Gets a value indicating whether the sink is currently installed.</summary>
    public static bool IsInstalled
    {
        get { lock (Gate) return _dispatcherHandler is not null; }
    }

    /// <summary>
    /// Starts observing unhandled UI-dispatcher exceptions and unobserved task exceptions (idempotent).
    /// </summary>
    public static void Install()
    {
        lock (Gate)
        {
            if (_dispatcherHandler is not null)
                return;

            _dispatcherHandler = OnDispatcherUnhandledException;
            _taskHandler = OnUnobservedTaskException;

            Dispatcher.UIThread.UnhandledException += _dispatcherHandler;
            TaskScheduler.UnobservedTaskException += _taskHandler;
        }
    }

    /// <summary>
    /// Stops observing (idempotent).
    /// </summary>
    public static void Uninstall()
    {
        lock (Gate)
        {
            if (_dispatcherHandler is null)
                return;

            Dispatcher.UIThread.UnhandledException -= _dispatcherHandler;
            if (_taskHandler is not null)
                TaskScheduler.UnobservedTaskException -= _taskHandler;

            _dispatcherHandler = null;
            _taskHandler = null;
        }
    }

    private static void OnDispatcherUnhandledException(object? sender, DispatcherUnhandledExceptionEventArgs e)
    {
        // Do NOT set e.Handled — we are only observing; the app keeps its own behavior.
        Record(e.Exception);
    }

    private static void OnUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
    {
        // Do NOT call e.SetObserved() — leave the task fault to the app's configured policy.
        Record(e.Exception);
    }

    private static void Record(Exception? exception)
    {
        if (exception is null)
            return;

        // Unwrap a single-inner AggregateException (typical for task faults) for a cleaner message.
        if (exception is AggregateException { InnerExceptions.Count: 1 } aggregate)
            exception = aggregate.InnerExceptions[0];

        DiagnosticsErrorLog.Record(
            DiagnosticSeverity.Error,
            DiagnosticCategory.Runtime,
            exception.GetType().Name,
            BuildMessage(exception));
    }

    private static string BuildMessage(Exception exception)
    {
        var builder = new StringBuilder(exception.Message);

        var location = FirstFrame(exception);
        if (location is not null)
            builder.Append("  @ ").Append(location);

        if (exception.InnerException is { } inner)
            builder.Append("  (inner: ").Append(inner.GetType().Name).Append(": ").Append(inner.Message).Append(')');

        return builder.ToString();
    }

    /// <summary>
    /// Returns a short description of the throw site (method + file:line when symbols are available),
    /// which is exactly the pointer an agent needs to find the offending code.
    /// </summary>
    private static string? FirstFrame(Exception exception)
    {
        try
        {
            var trace = new StackTrace(exception, fNeedFileInfo: true);
            foreach (var frame in trace.GetFrames())
            {
                var method = frame.GetMethod();
                if (method is null)
                    continue;

                var declaringType = method.DeclaringType?.FullName ?? "?";
                var file = frame.GetFileName();
                return file is not null
                    ? $"{declaringType}.{method.Name} ({System.IO.Path.GetFileName(file)}:{frame.GetFileLineNumber()})"
                    : $"{declaringType}.{method.Name}";
            }
        }
        catch (Exception)
        {
            // Best-effort only; never let diagnostics throw.
        }

        return null;
    }
}
