using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SplitViewEventsExtensions
{
    public static T OnPaneClosed<T>(this T control, Action<RoutedEventArgs> action) where T : SplitView => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosed += h);
    public static T OnPaneClosing<T>(this T control, Action<CancelRoutedEventArgs> action) where T : SplitView => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosing += h);
    public static T OnPaneOpened<T>(this T control, Action<RoutedEventArgs> action) where T : SplitView => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpened += h);
    public static T OnPaneOpening<T>(this T control, Action<CancelRoutedEventArgs> action) where T : SplitView => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpening += h);
}

