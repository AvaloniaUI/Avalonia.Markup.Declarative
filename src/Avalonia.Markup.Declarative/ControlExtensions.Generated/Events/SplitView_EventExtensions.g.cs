using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using SplitView = Avalonia.Controls.SplitView;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SplitViewEventsExtensions
{
    public static T OnPaneClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.SplitView => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PaneClosed += h);
    public static T OnPaneClosing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.SplitView => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PaneClosing += h);
    public static T OnPaneOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.SplitView => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PaneOpened += h);
    public static T OnPaneOpening<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.SplitView => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PaneOpening += h);
}

