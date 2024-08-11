using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderEventsExtensions
{
    public static T OnCollapsed<T>(this T control, Action<RoutedEventArgs> action) where T : Expander => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsed += h);
    public static T OnCollapsing<T>(this T control, Action<CancelRoutedEventArgs> action) where T : Expander => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsing += h);
    public static T OnExpanded<T>(this T control, Action<RoutedEventArgs> action) where T : Expander => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Expanded += h);
    public static T OnExpanding<T>(this T control, Action<CancelRoutedEventArgs> action) where T : Expander => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Expanding += h);
}

