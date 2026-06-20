using System;
using System.Collections.Generic;
using System.Linq;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// A process-wide, thread-safe ring buffer of recent <see cref="DiagnosticEntry"/> records.
/// </summary>
/// <remarks>
/// This lives in the core (deps-free) diagnostics surface so it can be populated from anywhere
/// inside <c>Avalonia.Markup.Declarative</c> (build errors, the binding log sink, etc.) and read
/// by external tooling such as <c>Declarative.Avalonia.AgentTools</c>. Recording only happens on
/// exceptional paths, so the always-on buffer adds no cost to the success path.
/// </remarks>
public static class DiagnosticsErrorLog
{
    private const int DefaultCapacity = 200;

    private static readonly object Gate = new();
    private static readonly Queue<DiagnosticEntry> Entries = new();
    private static int _capacity = DefaultCapacity;

    /// <summary>
    /// Maximum number of entries kept. Oldest entries are dropped once the limit is exceeded.
    /// </summary>
    public static int Capacity
    {
        get { lock (Gate) return _capacity; }
        set
        {
            lock (Gate)
            {
                _capacity = Math.Max(1, value);
                Trim();
            }
        }
    }

    /// <summary>
    /// Records an already-built entry.
    /// </summary>
    public static void Record(DiagnosticEntry entry)
    {
        if (entry is null)
            return;

        lock (Gate)
        {
            Entries.Enqueue(entry);
            Trim();
        }
    }

    /// <summary>
    /// Records an entry, stamping it with the current time.
    /// </summary>
    public static void Record(DiagnosticSeverity severity, DiagnosticCategory category, string source, string message) =>
        Record(new DiagnosticEntry(DateTimeOffset.Now, severity, category, source ?? "Unknown", message ?? string.Empty));

    /// <summary>
    /// Records an exception as an error entry.
    /// </summary>
    public static void RecordException(Exception exception, DiagnosticCategory category, string? source = null)
    {
        if (exception is null)
            return;

        Record(DiagnosticSeverity.Error, category, source ?? exception.GetType().Name, exception.Message);
    }

    /// <summary>
    /// Returns a snapshot of recorded entries, optionally filtered to those at or after
    /// <paramref name="since"/>.
    /// </summary>
    public static IReadOnlyList<DiagnosticEntry> GetEntries(DateTimeOffset? since = null)
    {
        lock (Gate)
        {
            IEnumerable<DiagnosticEntry> query = Entries;
            if (since is { } from)
                query = query.Where(e => e.Timestamp >= from);

            return query.ToArray();
        }
    }

    /// <summary>
    /// Removes all recorded entries.
    /// </summary>
    public static void Clear()
    {
        lock (Gate)
            Entries.Clear();
    }

    private static void Trim()
    {
        while (Entries.Count > _capacity)
            Entries.Dequeue();
    }
}
