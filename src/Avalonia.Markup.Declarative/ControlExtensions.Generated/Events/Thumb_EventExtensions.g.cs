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
    public static Thumb OnDragStarted(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragStarted += h);
    public static Thumb OnDragDelta(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragDelta += h);
    public static Thumb OnDragCompleted(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragCompleted += h);
}

