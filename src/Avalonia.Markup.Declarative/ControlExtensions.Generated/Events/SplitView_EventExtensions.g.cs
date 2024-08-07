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
    public static SplitView OnPaneClosed(this SplitView control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosed += h);
    public static SplitView OnPaneClosing(this SplitView control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosing += h);
    public static SplitView OnPaneOpened(this SplitView control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpened += h);
    public static SplitView OnPaneOpening(this SplitView control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpening += h);
}

