using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(Avalonia.Markup.Declarative.HotReloadManager))]

namespace Avalonia.Markup.Declarative;

public static class HotReloadManager
{
    private static readonly ConcurrentDictionary<Type, ConditionalWeakTable<IReloadable, object?>> Instances = new();

    public static event Action<Type[]?>? HotReloaded;

    public static bool IsEnabled { get; private set; } = true;

    public static void Activate() =>
        IsEnabled = true;

    public static void Deactivate() =>
        IsEnabled = false;

    private static void OnHotReloaded(Type[]? types) =>
        HotReloaded?.Invoke(types);

    public static void ClearCache(Type[]? types)
    {
        Log("ClearCache for types: " + PrintTypes(types));
    }

    public static void UpdateApplication(Type[]? types)
    {
        if (IsEnabled)
            ReloadInstances(types);

        OnHotReloaded(types);
    }

    private static void ReloadInstances(Type[]? types)
    {
        Log("UpdateApplication for types: " + PrintTypes(types));
        if (types == null)
            return;

        foreach (var type in types)
        {
            if (!Instances.TryGetValue(type, out var table))
                continue;

            foreach (var instance in table)
            {
                instance.Key.Reload();
            }
        }
    }

    [Conditional("DEBUG")]
    private static void Log(string message) => Debug.WriteLine($"[Markup.HotReload] {message}");

    public static string PrintTypes(Type[]? types)
    {
        if (types != null)
        {
            return string.Join(", ", types.Select(t => t.Name));
        }

        return "";
    }

    internal static void RegisterInstance(IReloadable instance)
    {
        if (!IsEnabled) return;
        var type = instance.GetType();
        if (type.IsGenericType) type = type.GetGenericTypeDefinition();

        var table = Instances.GetOrAdd(type, _ => []);
        table.AddOrUpdate(instance, null);
    }

    internal static void UnregisterInstance(IReloadable instance)
    {
        if (!IsEnabled) return;

        var type = instance.GetType();

        if (type.IsGenericType)
        {
            type = type.GetGenericTypeDefinition();
        }

        if (!Instances.TryGetValue(type, out var table)) return;

        table.Remove(instance);
    }
}