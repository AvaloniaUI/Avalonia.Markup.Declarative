using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Layoutable = Avalonia.Layout.Layoutable;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableEventsExtensions
{
    public static T OnEffectiveViewportChanged<T>(this T control, Action<Avalonia.Layout.EffectiveViewportChangedEventArgs> action) where T : Avalonia.Layout.Layoutable => 
        control._setEvent((System.EventHandler<Avalonia.Layout.EffectiveViewportChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.EffectiveViewportChanged += h);
    public static T OnLayoutUpdated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Layout.Layoutable => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.LayoutUpdated += h);
}

