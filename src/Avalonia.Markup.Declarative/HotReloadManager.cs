using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(Avalonia.Markup.Declarative.HotReloadManager))]

namespace Avalonia.Markup.Declarative;

public static class HotReloadManager
{
    private static readonly Dictionary<Type, HashSet<IReloadable>> Instances = new();

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
        Console.WriteLine("ClearCache for types: " + PrintTypes(types));
    }

    public static void UpdateApplication(Type[]? types)
    {
        if (IsRiderSupportEnabled)
        {
            Console.WriteLine("Native hot reload is working disabling Rider Workaround");
            DeactivateRiderHotReload();
        }

        if (IsEnabled)
            ReloadInstances(types);
    
        OnHotReloaded(types);
    }

    private static void ReloadInstances(Type[]? types)
    {
        Console.WriteLine("UpdateApplication for types: " + PrintTypes(types));
        if (types == null)
            return;

        foreach (var type in types)
        {
            if (!Instances.TryGetValue(type, out var instances))
                continue;

            foreach (var instance in instances)
                instance.Reload();
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
        if (!IsEnabled) return;

        var type = instance.GetType();
        if (!Instances.TryGetValue(type, out var instances))
        {
            instances = new HashSet<IReloadable>();
            Instances[type] = instances;
        }

        instances.Add(instance);

        if (IsRiderSupportEnabled)
            RegisterMethodWatchers(type);
    }

    internal static void UnregisterInstance(IReloadable instance)
    {
        if (!IsEnabled) return;

        var type = instance.GetType();
        if (!Instances.TryGetValue(type, out var instances)) return;

        if (instances.Contains(instance))
            instances.Remove(instance);
    }


    #region Rider hotreload workaround support

    private static readonly ConcurrentDictionary<Type, WatchMethodInfo[]> WatchMethods = new();
    private static int _interval = 2000;
    private static Timer? _watchMethodsTimer;
    public static bool IsRiderSupportEnabled { get; private set; }

    private class WatchMethodInfo(MethodInfo method, int token)
    {
        public MethodInfo Method { get; } = method;
        public int Token { get; set; } = token;
    }

    public static void RegisterMethodWatchers(Type type)
    {
        var methods = type
            .GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
            .Select(m => new WatchMethodInfo(m, m.GetMethodBody()?.LocalSignatureMetadataToken ?? -1))
            .Where(x => x.Token > -1)
            .ToArray();

        WatchMethods.TryAdd(type, methods);
    }
    public static void UnregisterMethodWatchers(Type type)
    {
        WatchMethods.TryRemove(type, out _);
    }

    public static void CheckMethodWereChanged()
    {
        HashSet<Type> changedInstances = [];

        foreach (var (type, methods) in WatchMethods)
            foreach (var watchMethodInfo in methods)
            {
                var currentToken = watchMethodInfo.Method.GetMethodBody()?.LocalSignatureMetadataToken ?? -1;
                if (currentToken != watchMethodInfo.Token)
                {
                    watchMethodInfo.Token = currentToken;
                    changedInstances.Add(type);
                }
            }

        if(changedInstances.Count > 0)
            ReloadInstances(changedInstances.ToArray());
    }


    public static void ActivateRiderHotReload()
    {
        IsRiderSupportEnabled = true;
        StartWatchMethods();
    }

    public static void DeactivateRiderHotReload()
    {
        IsRiderSupportEnabled = false;
        StopWatchMethods();
    }

    private static void StartWatchMethods()
    {
        _watchMethodsTimer = new Timer(_ => CheckMethodWereChanged(), null, _interval, _interval);
    }

    private static void StopWatchMethods()
    {
        _watchMethodsTimer?.Change(-1, -1);
    }

    public static void SetRiderRiderCheckInterval(int milliseconds) =>
        _interval = milliseconds;


    #endregion
}