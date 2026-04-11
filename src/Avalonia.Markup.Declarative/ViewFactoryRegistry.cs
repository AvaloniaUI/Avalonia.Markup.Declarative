using System;
using System.Collections.Concurrent;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Runtime registry used by source-generated control factories.
/// </summary>
public static class ViewFactoryRegistry
{
    private static readonly ConcurrentDictionary<Type, Func<Control>> Factories = new();

    /// <summary>
    /// Registers a factory delegate for a control type.
    /// Intended for source-generated code.
    /// </summary>
    public static void Register<TControl>(Func<TControl> factory)
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(factory);
        Factories[typeof(TControl)] = () => factory();
    }

    internal static bool TryCreate<TControl>(out TControl control)
        where TControl : Control
    {
        if (Factories.TryGetValue(typeof(TControl), out var factory) && factory() is TControl created)
        {
            control = created;
            return true;
        }

        control = null!;
        return false;
    }
}