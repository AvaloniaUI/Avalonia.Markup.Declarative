using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ThumbEventsExtensions
{
    public static T OnDragStarted<T>(this T control, Action<VectorEventArgs> action) where T : Thumb => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragStarted += h);
    public static T OnDragDelta<T>(this T control, Action<VectorEventArgs> action) where T : Thumb => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragDelta += h);
    public static T OnDragCompleted<T>(this T control, Action<VectorEventArgs> action) where T : Thumb => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragCompleted += h);
}

