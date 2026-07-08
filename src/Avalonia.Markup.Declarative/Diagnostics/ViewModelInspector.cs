using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            return "DataContext is null; there is no view-model to set a property on.";
        if (string.IsNullOrWhiteSpace(path))
            return "Provide a property path (e.g. 'IsBusy' or 'CurrentUser.Name').";

        if (!TryResolveOwner(viewModel, path, out var owner, out var leaf, out var error))
            return error;

        var property = FindProperty(owner.GetType(), leaf);
        if (property is null)
            return $"No property '{leaf}' on {owner.GetType().Name}.";
        if (!property.CanWrite)
            return $"Property '{leaf}' on {owner.GetType().Name} is read-only.";

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
            return "DataContext is null; there is no view-model to invoke a command on.";
        if (string.IsNullOrWhiteSpace(path))
            return "Provide a command path (e.g. 'SaveCommand', 'Editor.RefreshCommand', or a method name).";

        if (!TryResolveOwner(viewModel, path, out var owner, out var leaf, out var error))
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
                    return $"Command property '{path}' is null.";
            }
        }

        // Fallback: a plain public method (some view-models expose actions as methods, not commands).
        var method = FindInvokableMethod(owner.GetType(), leaf);
        if (method is not null)
            return InvokeMethod(owner, method, parameter, path);

        if (property is { CanRead: true })
            return $"'{path}' is a {FriendlyType(property.PropertyType)}, not an ICommand, and no method '{leaf}' exists.";

        return $"No command property or invokable method '{leaf}' on {owner.GetType().Name}.";
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

    /// <summary>
    /// Walks all but the last segment of <paramref name="path"/>, returning the object that owns the leaf
    /// member and the leaf name. A null or missing intermediate is reported as an error.
    /// </summary>
    private static bool TryResolveOwner(object root, string path, out object owner, out string leaf, out string error)
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
                error = $"No readable property '{segments[i]}' on {current.GetType().Name} while resolving '{path}'.";
                return false;
            }

            var next = TryRead(property, current);
            if (next is null)
            {
                error = $"'{segments[i]}' is null while resolving '{path}'.";
                return false;
            }

            current = next;
        }

        owner = current;
        leaf = segments[^1];
        return true;
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
