using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Expander = Avalonia.Controls.Expander;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderEventsExtensions
{
    public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Collapsed += h);
    public static T OnCollapsing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Collapsing += h);
    public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Expanded += h);
    public static T OnExpanding<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Expanding += h);
}

