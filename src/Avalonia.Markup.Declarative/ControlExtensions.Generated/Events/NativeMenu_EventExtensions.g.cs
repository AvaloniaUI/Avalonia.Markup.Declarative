using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuEventsExtensions
{
    public static T OnNeedsUpdate<T>(this T control, Action<EventArgs> action) where T : NativeMenu => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.NeedsUpdate += h);
    public static T OnOpening<T>(this T control, Action<EventArgs> action) where T : NativeMenu => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Opening += h);
    public static T OnClosed<T>(this T control, Action<EventArgs> action) where T : NativeMenu => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}

