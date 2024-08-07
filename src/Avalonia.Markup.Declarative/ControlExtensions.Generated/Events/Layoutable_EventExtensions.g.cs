using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableEventsExtensions
{
    public static T OnEffectiveViewportChanged<T>(this T control, Action<EffectiveViewportChangedEventArgs> action) where T : Layoutable => 
        control._setEvent((EventHandler<EffectiveViewportChangedEventArgs>) ((_, args) => action(args)), h => control.EffectiveViewportChanged += h);
    public static T OnLayoutUpdated<T>(this T control, Action action) where T : Layoutable => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.LayoutUpdated += h);
}

