using System;

namespace Avalonia.Markup.Declarative;

public static class ControlEventExtensions
{
    public static TControl _setEvent<TControl, THandler>(this TControl control, THandler handler, Action<THandler> subscribe)
        where TControl : AvaloniaObject
    {
        subscribe?.Invoke(handler);
        return control;
    }
}

internal static class WeakEventHandler<TArgs>
{
    public static EventHandler<TArgs> Create<THandler>(
        THandler handler, Action<THandler, object?, TArgs> invoker)
        where THandler : class
    {
        var weakEventHandler = new WeakReference<THandler>(handler);

        return (sender, args) =>
        {
            if (weakEventHandler.TryGetTarget(out THandler? thandler))
            {
                invoker(thandler, sender, args);
            }
        };
    }
}