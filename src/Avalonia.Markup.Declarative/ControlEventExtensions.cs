using System;

namespace Avalonia.Markup.Declarative;

public static partial class ControlEventExtensions
{
    public static TControl _setEvent<TControl, THandler>(this TControl control, THandler handler, Action<THandler> subscribe, Action<THandler> unsubscribe)
        where TControl : AvaloniaObject
    {
        subscribe?.Invoke(handler);
        return control;
    }
} 