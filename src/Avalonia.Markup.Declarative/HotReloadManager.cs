using System;
using System.Collections.Generic;
using System.Linq;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(Avalonia.Markup.Declarative.HotReloadManager))]

#nullable enable

namespace Avalonia.Markup.Declarative;

public static class HotReloadManager
{
    private static readonly Dictionary<Type, HashSet<IReloadable>> Instances = new();

    public static event Action<Type[]?>? HotReloaded;

    private static void OnHotReloaded(Type[]? types) => HotReloaded?.Invoke(types);

    public static void ClearCache(Type[]? types)
    {
        Console.WriteLine("ClearCache for types: " + PrintTypes(types));
    }

    public static void UpdateApplication(Type[]? types)
    {
        Console.WriteLine("UpdateApplication for types: " + PrintTypes(types));
        if (types != null)
        {
            foreach (var type in types)
            {
                if (!Instances.TryGetValue(type, out var instances)) continue;

                foreach (var instance in instances)
                    instance.Reload();
            }

            OnHotReloaded(types);
        }
    }

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
        var type = instance.GetType();
        if (!Instances.TryGetValue(type, out var instances))
        {
            instances = new HashSet<IReloadable>();
            Instances[type] = instances;
        }

        instances.Add(instance);
    }

    internal static void UnregisterInstance(IReloadable instance)
    {
        var type = instance.GetType();
        if (!Instances.TryGetValue(type, out var instances)) return;

        if (instances.Contains(instance))
            instances.Remove(instance);
    }
}