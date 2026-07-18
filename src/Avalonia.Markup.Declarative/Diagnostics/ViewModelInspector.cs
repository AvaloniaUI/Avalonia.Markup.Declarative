using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Writes to a view-model directly — the "escape hatch" for driving an app into a state that is awkward
/// to reach through the UI (flip a flag to show a banner, execute a command without hunting for its
/// button). Sets a property by dotted path or invokes an <see cref="ICommand"/> / public method, all via
/// reflection.
/// </summary>
/// <remarks>
/// Dependency-free (no Avalonia types): it operates on a plain object graph so it is reusable from tests.
/// Setting the real CLR property means an <see cref="INotifyPropertyChanged"/> view-model raises its
/// change notification, so bindings update exactly as they would from user input. Every operation returns
/// a human-readable result string (including a clear reason on failure) rather than throwing.
/// </remarks>
public static class ViewModelInspector
{
    /// <summary>
    /// Sets the property at <paramref name="path"/> (e.g. <c>IsBusy</c> or <c>CurrentUser.Name</c>) on
    /// <paramref name="viewModel"/> to <paramref name="rawValue"/>, converting the text to the property's
    /// type. Returns a result describing the old and new value, or the reason it could not be set.
    /// </summary>
    public static string SetValue(object? viewModel, string path, string? rawValue)
    {
        if (viewModel is null)
            return "DataContext is null; there is no view-model to set a property on. Pass 'name' to target " +
                   "a control whose DataContext is set, or use list_bindable to discover a settable target.";
        if (string.IsNullOrWhiteSpace(path))
            return "Provide a property path (e.g. 'IsBusy' or 'CurrentUser.Name').";

        if (!TryResolveOwner(viewModel, path, MemberKind.SettableProperty, out var owner, out var leaf, out var error))
            return error;

        var property = FindProperty(owner.GetType(), leaf);
        if (property is null)
            return ResolutionFailure(viewModel, path, owner, leaf, MemberKind.SettableProperty);
        if (!property.CanWrite)
            return $"path '{path}' resolved to property '{leaf}' on {FriendlyType(owner.GetType())}, but it is " +
                   $"read-only (no setter). Settable properties there: [{JoinMembers(SettablePropertyNames(owner.GetType()))}].";

        var oldValue = TryRead(property, owner);

        object? converted;
        try
        {
            converted = ConvertValue(rawValue, property.PropertyType);
        }
        catch (Exception ex)
        {
            return $"Cannot convert '{rawValue}' to {FriendlyType(property.PropertyType)}: {ex.Message}";
        }

        try
        {
            property.SetValue(owner, converted);
        }
        catch (Exception ex)
        {
            return $"Setting '{path}' threw {(ex as TargetInvocationException)?.InnerException?.GetType().Name ?? ex.GetType().Name}: " +
                   $"{(ex as TargetInvocationException)?.InnerException?.Message ?? ex.Message}";
        }

        return $"Set {path} = {Format(converted)} (was {Format(oldValue)}) on {viewModel.GetType().Name}.";
    }

    /// <summary>
    /// Invokes an <see cref="ICommand"/> property, or a public method, at <paramref name="path"/> on
    /// <paramref name="viewModel"/>. For a command, <see cref="ICommand.CanExecute"/> is checked first and
    /// <paramref name="parameter"/> is passed straight through; for a method, <paramref name="parameter"/>
    /// is converted to its single argument (if any).
    /// </summary>
    public static string InvokeCommand(object? viewModel, string path, string? parameter)
    {
        if (viewModel is null)
            return "DataContext is null; there is no view-model to invoke a command on. Pass 'name' to target " +
                   "a control whose DataContext is set, or use list_bindable to discover a command target.";
        if (string.IsNullOrWhiteSpace(path))
            return "Provide a command path (e.g. 'SaveCommand', 'Editor.RefreshCommand', or a method name).";

        if (!TryResolveOwner(viewModel, path, MemberKind.Command, out var owner, out var leaf, out var error))
            return error;

        // A property that returns an ICommand is the common case (the button binds to it).
        var property = FindProperty(owner.GetType(), leaf);
        if (property is { CanRead: true })
        {
            var value = TryRead(property, owner);
            switch (value)
            {
                case ICommand command:
                    return ExecuteCommand(command, parameter, path);
                case null:
                    return $"path '{path}' resolved to command property '{leaf}' on {FriendlyType(owner.GetType())}, " +
                           "but its value is null.";
            }
        }

        // Fallback: a plain public method (some view-models expose actions as methods, not commands).
        var method = FindInvokableMethod(owner.GetType(), leaf);
        if (method is not null)
            return InvokeMethod(owner, method, parameter, path);

        if (property is { CanRead: true })
            return $"path '{path}' resolved to member '{leaf}' on {FriendlyType(owner.GetType())}, which is a " +
                   $"{FriendlyType(property.PropertyType)}, not an ICommand, and no invokable method '{leaf}' exists. " +
                   $"Available ICommand properties: [{JoinMembers(CommandPropertyNames(owner.GetType()))}]. " +
                   $"Invokable methods: [{JoinMembers(InvokableMethodNames(owner.GetType()))}].";

        return ResolutionFailure(viewModel, path, owner, leaf, MemberKind.Command);
    }

    private static string ExecuteCommand(ICommand command, string? parameter, string path)
    {
        if (!command.CanExecute(parameter))
            return $"Command '{path}' is disabled right now (CanExecute returned false); not executed.";

        try
        {
            command.Execute(parameter);
        }
        catch (Exception ex)
        {
            return $"Command '{path}' threw {ex.GetType().Name}: {ex.Message}";
        }

        return parameter is null
            ? $"Executed command '{path}'."
            : $"Executed command '{path}' with parameter '{parameter}'.";
    }

    private static string InvokeMethod(object owner, MethodInfo method, string? parameter, string path)
    {
        var parameters = method.GetParameters();
        object?[] args;
        if (parameters.Length == 0)
        {
            args = Array.Empty<object?>();
        }
        else
        {
            object? arg;
            try
            {
                arg = ConvertValue(parameter, parameters[0].ParameterType);
            }
            catch (Exception ex)
            {
                return $"Cannot convert '{parameter}' to {FriendlyType(parameters[0].ParameterType)} for '{path}': {ex.Message}";
            }

            args = new[] { arg };
        }

        try
        {
            method.Invoke(owner, args);
        }
        catch (TargetInvocationException ex)
        {
            return $"Method '{path}' threw {ex.InnerException?.GetType().Name ?? ex.GetType().Name}: {ex.InnerException?.Message ?? ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Invoking '{path}' threw {ex.GetType().Name}: {ex.Message}";
        }

        return parameter is null
            ? $"Invoked method '{path}'."
            : $"Invoked method '{path}' with '{parameter}'.";
    }

    /// <summary>What kind of leaf member the caller is trying to reach, so failure diagnostics can list
    /// the relevant candidates.</summary>
    private enum MemberKind
    {
        SettableProperty,
        Command
    }

    /// <summary>
    /// Walks all but the last segment of <paramref name="path"/>, returning the object that owns the leaf
    /// member and the leaf name. A null or missing intermediate produces a structured, actionable error
    /// naming the failing segment, the runtime type there, and what is actually available.
    /// </summary>
    private static bool TryResolveOwner(object root, string path, MemberKind kind, out object owner, out string leaf, out string error)
    {
        owner = root;
        leaf = string.Empty;
        error = string.Empty;

        var segments = path.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (segments.Length == 0)
        {
            error = "Provide a property path (e.g. 'IsBusy' or 'CurrentUser.Name').";
            return false;
        }

        var current = root;
        for (var i = 0; i < segments.Length - 1; i++)
        {
            var property = FindProperty(current.GetType(), segments[i]);
            if (property is null || !property.CanRead)
            {
                // An intermediate segment didn't resolve. List readable sub-objects to navigate through,
                // plus the kind-specific leaf candidates, plus a "did you mean" on the whole member set.
                error = ResolutionFailure(root, path, current, segments[i], kind, isIntermediate: true);
                return false;
            }

            var next = TryRead(property, current);
            if (next is null)
            {
                error = $"path '{path}' failed: segment '{segments[i]}' on {FriendlyType(current.GetType())} " +
                        "is null, so the rest of the path cannot be resolved. Use get_data_context to inspect " +
                        "its state, or set/populate it first.";
                return false;
            }

            current = next;
        }

        owner = current;
        leaf = segments[^1];
        return true;
    }

    /// <summary>
    /// Builds the actionable message shown when a path segment cannot be resolved: what object failed
    /// and its runtime type, the missing member, the relevant candidate list, the sub-objects to drill
    /// into, and a best "did you mean".
    /// </summary>
    private static string ResolutionFailure(object dataContext, string path, object where, string segment, MemberKind kind, bool isIntermediate = false)
    {
        var whereLabel = ReferenceEquals(where, dataContext)
            ? $"DataContext is {FriendlyType(dataContext.GetType())}"
            : $"'{segment}' is looked up on {FriendlyType(where.GetType())}";

        var type = where.GetType();

        var candidateLabel = kind == MemberKind.Command ? "ICommand properties" : "settable properties";
        var candidates = kind == MemberKind.Command ? CommandPropertyNames(type) : SettablePropertyNames(type);

        var builder = new StringBuilder();
        builder.Append("path '").Append(path).Append("' failed: ").Append(whereLabel)
            .Append(", no member '").Append(segment).Append("'. ");
        builder.Append("Available ").Append(candidateLabel).Append(": [").Append(JoinMembers(candidates)).Append("].");

        if (kind == MemberKind.Command)
        {
            var methods = InvokableMethodNames(type);
            if (methods.Count > 0)
                builder.Append(" Invokable methods: [").Append(JoinMembers(methods)).Append("].");
        }

        var subObjects = SubObjectNames(type);
        if (subObjects.Count > 0)
            builder.Append(" Sub-objects to drill into (dotted path): [").Append(JoinMembers(subObjects)).Append("].");

        if (Suggest(segment, AllMemberNames(type)) is { } suggestion)
            builder.Append(" Did you mean '").Append(suggestion).Append("'?");

        builder.Append(" Tip: call list_bindable to enumerate everything the target exposes.");
        return builder.ToString();
    }

    /// <summary>
    /// Enumerates what an agent can drive on <paramref name="dataContext"/>: settable properties,
    /// <see cref="ICommand"/> properties, invokable public methods, and readable sub-objects (state
    /// roots) to drill into with a dotted path. Backs the <c>list_bindable</c> tool (P3).
    /// </summary>
    public static string ListBindable(object? dataContext)
    {
        if (dataContext is null)
            return "DataContext is null; nothing to enumerate. Pass 'name' to target a control whose " +
                   "DataContext is set.";

        var type = dataContext.GetType();
        var builder = new StringBuilder();
        builder.Append("Bindable surface of ").Append(FriendlyType(type)).Append(":\n");

        builder.Append("  Settable properties:\n");
        AppendMemberLines(builder, SettablePropertyDetails(type));

        builder.Append("  ICommand properties:\n");
        AppendMemberLines(builder, CommandPropertyDetails(dataContext, type));

        builder.Append("  Invokable methods:\n");
        AppendMemberLines(builder, InvokableMethodDetails(type));

        builder.Append("  Sub-objects (drill in with a dotted path, e.g. 'Foo.Bar'):\n");
        AppendMemberLines(builder, SubObjectDetails(dataContext, type));

        return builder.ToString();
    }

    private static void AppendMemberLines(StringBuilder builder, System.Collections.Generic.IReadOnlyList<string> lines)
    {
        if (lines.Count == 0)
        {
            builder.Append("    (none)\n");
            return;
        }

        foreach (var line in lines)
            builder.Append("    ").Append(line).Append('\n');
    }

    private static IEnumerable<PropertyInfo> PublicProperties(Type type) =>
        type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetIndexParameters().Length == 0);

    private static IReadOnlyList<string> SettablePropertyNames(Type type) =>
        PublicProperties(type).Where(p => p.CanWrite).Select(p => p.Name).OrderBy(n => n).ToList();

    private static IReadOnlyList<string> CommandPropertyNames(Type type) =>
        PublicProperties(type).Where(p => p.CanRead && typeof(ICommand).IsAssignableFrom(p.PropertyType))
            .Select(p => p.Name).OrderBy(n => n).ToList();

    private static IReadOnlyList<string> InvokableMethodNames(Type type) =>
        type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName && m.GetParameters().Length <= 1 && m.ReturnType == typeof(void))
            .Select(m => m.Name).Distinct().OrderBy(n => n).ToList();

    // Readable properties whose type is a "container" worth navigating into (a nested view-model / app
    // state root), so an agent can build a dotted path such as AppState.UiState.ShowBrushSettings.
    private static IReadOnlyList<string> SubObjectNames(Type type) =>
        PublicProperties(type).Where(p => p.CanRead && IsNavigable(p.PropertyType))
            .Select(p => p.Name).OrderBy(n => n).ToList();

    private static IReadOnlyList<string> AllMemberNames(Type type) =>
        PublicProperties(type).Select(p => p.Name)
            .Concat(type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(m => !m.IsSpecialName).Select(m => m.Name))
            .Distinct().ToList();

    private static IReadOnlyList<string> SettablePropertyDetails(Type type) =>
        PublicProperties(type).Where(p => p.CanWrite)
            .OrderBy(p => p.Name)
            .Select(p => $"{p.Name} : {FriendlyType(p.PropertyType)}")
            .ToList();

    private static IReadOnlyList<string> CommandPropertyDetails(object owner, Type type) =>
        PublicProperties(type).Where(p => p.CanRead && typeof(ICommand).IsAssignableFrom(p.PropertyType))
            .OrderBy(p => p.Name)
            .Select(p =>
            {
                var canExecute = TryRead(p, owner) is ICommand c ? SafeCanExecute(c) : (bool?)null;
                var suffix = canExecute is null ? string.Empty : canExecute.Value ? " (CanExecute=true)" : " (CanExecute=false)";
                return $"{p.Name}{suffix}";
            })
            .ToList();

    private static IReadOnlyList<string> InvokableMethodDetails(Type type) =>
        type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName && m.GetParameters().Length <= 1 && m.ReturnType == typeof(void))
            .OrderBy(m => m.Name)
            .Select(m =>
            {
                var ps = m.GetParameters();
                return ps.Length == 0 ? $"{m.Name}()" : $"{m.Name}({FriendlyType(ps[0].ParameterType)})";
            })
            .Distinct()
            .ToList();

    private static IReadOnlyList<string> SubObjectDetails(object owner, Type type) =>
        PublicProperties(type).Where(p => p.CanRead && IsNavigable(p.PropertyType))
            .OrderBy(p => p.Name)
            .Select(p =>
            {
                var value = TryRead(p, owner);
                var state = value is null ? " = null" : string.Empty;
                return $"{p.Name} : {FriendlyType(p.PropertyType)}{state}";
            })
            .ToList();

    private static bool SafeCanExecute(ICommand command)
    {
        try
        {
            return command.CanExecute(null);
        }
        catch
        {
            return false;
        }
    }

    // A navigable sub-object: a reference type that is not a string/command/collection primitive — i.e.
    // a plausible nested view-model / state holder.
    private static bool IsNavigable(Type type)
    {
        if (type.IsPrimitive || type.IsEnum)
            return false;
        if (type == typeof(string) || type == typeof(decimal) || type == typeof(DateTime) ||
            type == typeof(DateTimeOffset) || type == typeof(TimeSpan) || type == typeof(Guid) || type == typeof(Uri))
            return false;
        if (typeof(ICommand).IsAssignableFrom(type))
            return false;
        if (Nullable.GetUnderlyingType(type) is not null)
            return false;
        // A namespace under System.* is almost always framework plumbing, not app state.
        return type.Namespace is not { } ns || !ns.StartsWith("System", StringComparison.Ordinal);
    }

    private static string JoinMembers(IReadOnlyList<string> names)
    {
        const int cap = 25;
        if (names.Count == 0)
            return "none";
        if (names.Count <= cap)
            return string.Join(", ", names);
        return string.Join(", ", names.Take(cap)) + $", … (+{names.Count - cap} more)";
    }

    // A lightweight "did you mean": exact-ci, then substring, then closest by edit distance (<= 3).
    private static string? Suggest(string target, IReadOnlyList<string> candidates)
    {
        if (candidates.Count == 0)
            return null;

        var ci = candidates.FirstOrDefault(c => string.Equals(c, target, StringComparison.OrdinalIgnoreCase));
        if (ci is not null)
            return ci;

        var contains = candidates.FirstOrDefault(c =>
            c.Contains(target, StringComparison.OrdinalIgnoreCase) || target.Contains(c, StringComparison.OrdinalIgnoreCase));
        if (contains is not null)
            return contains;

        string? best = null;
        var bestDistance = int.MaxValue;
        foreach (var c in candidates)
        {
            var d = Distance(target, c);
            if (d < bestDistance)
            {
                bestDistance = d;
                best = c;
            }
        }

        return bestDistance <= 3 ? best : null;
    }

    private static int Distance(string a, string b)
    {
        a = a.ToLowerInvariant();
        b = b.ToLowerInvariant();
        var d = new int[a.Length + 1, b.Length + 1];
        for (var i = 0; i <= a.Length; i++) d[i, 0] = i;
        for (var j = 0; j <= b.Length; j++) d[0, j] = j;
        for (var i = 1; i <= a.Length; i++)
        for (var j = 1; j <= b.Length; j++)
        {
            var cost = a[i - 1] == b[j - 1] ? 0 : 1;
            d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
        }

        return d[a.Length, b.Length];
    }

    private static PropertyInfo? FindProperty(Type type, string name) =>
        type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance)
        ?? type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
               .FirstOrDefault(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

    private static MethodInfo? FindInvokableMethod(Type type, string name) =>
        type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
            .Where(m => !m.IsSpecialName && string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase))
            .Where(m => m.GetParameters().Length <= 1)
            .OrderBy(m => m.GetParameters().Length) // prefer the parameterless overload
            .FirstOrDefault();

    private static object? TryRead(PropertyInfo property, object owner)
    {
        try
        {
            return property.GetValue(owner);
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Converts the text <paramref name="raw"/> to <paramref name="target"/>, handling nullable, string,
    /// bool, enum, the common value types and anything with a <see cref="TypeConverter"/>.
    /// </summary>
    private static object? ConvertValue(string? raw, Type target)
    {
        var underlying = Nullable.GetUnderlyingType(target) ?? target;
        var isNullable = !target.IsValueType || Nullable.GetUnderlyingType(target) is not null;

        // string / object (and any base a string satisfies) take the text as-is — e.g. an ICommand or a
        // method parameter typed 'object?'.
        if (underlying == typeof(string) || underlying == typeof(object))
            return raw;

        if (string.IsNullOrEmpty(raw))
        {
            if (isNullable)
                return null;
            throw new FormatException($"a value is required for non-nullable {FriendlyType(underlying)}");
        }

        if (underlying == typeof(bool))
            return ParseBool(raw);
        if (underlying.IsEnum)
            return Enum.Parse(underlying, raw, ignoreCase: true);
        if (underlying == typeof(Guid))
            return Guid.Parse(raw);
        if (underlying == typeof(TimeSpan))
            return TimeSpan.Parse(raw, CultureInfo.InvariantCulture);
        if (underlying == typeof(DateTime))
            return DateTime.Parse(raw, CultureInfo.InvariantCulture);
        if (underlying == typeof(DateTimeOffset))
            return DateTimeOffset.Parse(raw, CultureInfo.InvariantCulture);
        if (underlying == typeof(Uri))
            return new Uri(raw, UriKind.RelativeOrAbsolute);

        if (typeof(IConvertible).IsAssignableFrom(underlying))
            return Convert.ChangeType(raw, underlying, CultureInfo.InvariantCulture);

        var converter = TypeDescriptor.GetConverter(underlying);
        if (converter.CanConvertFrom(typeof(string)))
            return converter.ConvertFromInvariantString(raw);

        throw new NotSupportedException($"no conversion from text to {FriendlyType(underlying)}");
    }

    private static bool ParseBool(string raw) =>
        raw.Trim().ToLowerInvariant() switch
        {
            "true" or "1" or "yes" or "on" => true,
            "false" or "0" or "no" or "off" => false,
            _ => bool.Parse(raw)
        };

    private static string Format(object? value) =>
        value switch
        {
            null => "null",
            string s => $"'{Shorten(s)}'",
            IFormattable f => f.ToString(null, CultureInfo.InvariantCulture),
            _ => Shorten(value.ToString()) ?? value.GetType().Name
        };

    private static string? Shorten(string? value, int max = 80) =>
        string.IsNullOrEmpty(value) || value.Length <= max ? value : value.Substring(0, max) + "…";

    private static string FriendlyType(Type type)
    {
        if (Nullable.GetUnderlyingType(type) is { } underlying)
            return underlying.Name + "?";
        return type.Name;
    }
}
