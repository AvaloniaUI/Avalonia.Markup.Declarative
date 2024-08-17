using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WindowBase = Avalonia.Controls.WindowBase;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseEventsExtensions
{
    public static T OnActivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Activated += h);
    public static T OnDeactivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Deactivated += h);
    public static T OnPositionChanged<T>(this T control, Action<Avalonia.Controls.PixelPointEventArgs> action) where T : Avalonia.Controls.WindowBase => 
        control._setEvent((System.EventHandler<Avalonia.Controls.PixelPointEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PositionChanged += h);
    public static T OnResized<T>(this T control, Action<Avalonia.Controls.WindowResizedEventArgs> action) where T : Avalonia.Controls.WindowBase => 
        control._setEvent((System.EventHandler<Avalonia.Controls.WindowResizedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Resized += h);
}

