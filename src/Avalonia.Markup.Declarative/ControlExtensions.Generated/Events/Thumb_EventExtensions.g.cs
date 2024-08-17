using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Thumb = Avalonia.Controls.Primitives.Thumb;

namespace Avalonia.Markup.Declarative;
public static partial class ThumbEventsExtensions
{
    public static T OnDragStarted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragStarted += h);
    public static T OnDragDelta<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragDelta += h);
    public static T OnDragCompleted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragCompleted += h);
}

