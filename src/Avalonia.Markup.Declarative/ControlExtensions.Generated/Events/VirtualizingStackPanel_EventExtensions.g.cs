using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using VirtualizingStackPanel = Avalonia.Controls.VirtualizingStackPanel;

namespace Avalonia.Markup.Declarative;
public static partial class VirtualizingStackPanelEventsExtensions
{
    public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.VirtualizingStackPanel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.HorizontalSnapPointsChanged += h);
    public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.VirtualizingStackPanel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.VerticalSnapPointsChanged += h);
}

