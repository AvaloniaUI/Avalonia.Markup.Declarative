using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using NativeMenu = Avalonia.Controls.NativeMenu;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuEventsExtensions
{
    public static T OnNeedsUpdate<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu => 
        control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.NeedsUpdate += h);
    public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu => 
        control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Opening += h);
    public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu => 
        control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);
}

