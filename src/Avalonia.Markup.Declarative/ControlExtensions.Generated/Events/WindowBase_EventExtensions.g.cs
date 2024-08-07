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
    public static WindowBase OnActivated(this WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Activated += h);
    public static WindowBase OnDeactivated(this WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Deactivated += h);
    public static WindowBase OnPositionChanged(this WindowBase control, Action<PixelPointEventArgs> action) => 
        control._setEvent((EventHandler<PixelPointEventArgs>) ((_, args) => action(args)), h => control.PositionChanged += h);
    public static WindowBase OnResized(this WindowBase control, Action<WindowResizedEventArgs> action) => 
        control._setEvent((EventHandler<WindowResizedEventArgs>) ((_, args) => action(args)), h => control.Resized += h);
}

