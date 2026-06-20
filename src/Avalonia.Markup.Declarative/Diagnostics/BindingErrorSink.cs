using System;
using System.Text;
using Avalonia.Controls;
using Avalonia.Logging;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Captures Avalonia data-binding errors into <see cref="DiagnosticsErrorLog"/>.
/// </summary>
/// <remarks>
/// <para>
/// Avalonia 11.1+ shipped a public <c>BindingDiagnostics</c> type, but it is not part of the public
/// surface in the Avalonia version this library targets, so we use the documented fallback: a thin
/// <see cref="ILogSink"/> decorator over the current <see cref="Logger.Sink"/> that forwards every
/// message to the original sink and additionally records entries for <see cref="LogArea.Binding"/>
/// and <see cref="LogArea.Property"/>. This keeps the core diagnostics surface dependency-free.
/// </para>
/// <para>
/// Automatic binding conversion failures thrown by <c>DeclarativeBindingAutoConverter</c> surface
/// through Avalonia's binding pipeline and are therefore captured here as well; they are tagged
/// <see cref="DiagnosticCategory.Converter"/> when recognizable.
/// </para>
/// </remarks>
public static class BindingErrorSink
{
    private static readonly object Gate = new();
    private static CapturingLogSink? _installed;

    /// <summary>
    /// Gets a value indicating whether the capturing sink is currently installed.
    /// </summary>
    public static bool IsInstalled
    {
        get { lock (Gate) return _installed is not null; }
    }

    /// <summary>
    /// Installs the capturing sink (idempotent). The previously configured sink continues to receive
    /// all messages.
    /// </summary>
    public static void Install()
    {
        lock (Gate)
        {
            if (_installed is not null)
                return;

            var inner = Logger.Sink;
            _installed = new CapturingLogSink(inner);
            Logger.Sink = _installed;
        }
    }

    /// <summary>
    /// Removes the capturing sink and restores the original sink (idempotent).
    /// </summary>
    public static void Uninstall()
    {
        lock (Gate)
        {
            if (_installed is null)
                return;

            // Only restore if we are still the active sink; otherwise leave the current sink in place.
            if (ReferenceEquals(Logger.Sink, _installed))
                Logger.Sink = _installed.Inner;

            _installed = null;
        }
    }

    private sealed class CapturingLogSink : ILogSink
    {
        public CapturingLogSink(ILogSink? inner) => Inner = inner;

        public ILogSink? Inner { get; }

        public bool IsEnabled(LogEventLevel level, string area)
        {
            if (IsCaptured(level, area))
                return true;

            return Inner?.IsEnabled(level, area) ?? false;
        }

        public void Log(LogEventLevel level, string area, object? source, string messageTemplate)
        {
            Capture(level, area, source, messageTemplate, null);
            Inner?.Log(level, area, source!, messageTemplate);
        }

        public void Log(LogEventLevel level, string area, object? source, string messageTemplate, params object?[] propertyValues)
        {
            Capture(level, area, source, messageTemplate, propertyValues);
            Inner?.Log(level, area, source!, messageTemplate, propertyValues!);
        }

        private static bool IsCaptured(LogEventLevel level, string area) =>
            level >= LogEventLevel.Warning && (area == LogArea.Binding || area == LogArea.Property);

        private static void Capture(LogEventLevel level, string area, object? source, string messageTemplate, object?[]? propertyValues)
        {
            if (!IsCaptured(level, area))
                return;

            var message = Render(messageTemplate, propertyValues);
            var category = message.IndexOf("conversion", StringComparison.OrdinalIgnoreCase) >= 0
                ? DiagnosticCategory.Converter
                : DiagnosticCategory.Binding;

            DiagnosticsErrorLog.Record(
                level >= LogEventLevel.Error ? DiagnosticSeverity.Error : DiagnosticSeverity.Warning,
                category,
                DescribeSource(source),
                message);
        }

        private static string DescribeSource(object? source)
        {
            if (source is null)
                return "Binding";

            if (source is Control { Name: { Length: > 0 } name } control)
                return $"{control.GetType().Name} (Name: '{name}')";

            return source.GetType().Name;
        }

        // Avalonia uses positional "{Name}" tokens. We substitute them in order, which is good enough
        // for an agent-readable message without taking a structured-logging dependency.
        private static string Render(string template, object?[]? values)
        {
            if (string.IsNullOrEmpty(template) || values is null || values.Length == 0)
                return template ?? string.Empty;

            var builder = new StringBuilder(template.Length + 32);
            var valueIndex = 0;
            for (var i = 0; i < template.Length; i++)
            {
                var c = template[i];
                if (c == '{' && i + 1 < template.Length && template[i + 1] != '{')
                {
                    var end = template.IndexOf('}', i);
                    if (end > i)
                    {
                        builder.Append(valueIndex < values.Length ? values[valueIndex]?.ToString() ?? "null" : string.Empty);
                        valueIndex++;
                        i = end;
                        continue;
                    }
                }

                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
