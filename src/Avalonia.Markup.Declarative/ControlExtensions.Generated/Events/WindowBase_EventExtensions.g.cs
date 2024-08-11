using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseEventsExtensions
{
    public static T OnActivated<T>(this T control, Action action) where T : WindowBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Activated += h);
    public static T OnDeactivated<T>(this T control, Action action) where T : WindowBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Deactivated += h);
    public static T OnPositionChanged<T>(this T control, Action<PixelPointEventArgs> action) where T : WindowBase => 
        control._setEvent((EventHandler<PixelPointEventArgs>) ((_, args) => action(args)), h => control.PositionChanged += h);
    public static T OnResized<T>(this T control, Action<WindowResizedEventArgs> action) where T : WindowBase => 
        control._setEvent((EventHandler<WindowResizedEventArgs>) ((_, args) => action(args)), h => control.Resized += h);
}

