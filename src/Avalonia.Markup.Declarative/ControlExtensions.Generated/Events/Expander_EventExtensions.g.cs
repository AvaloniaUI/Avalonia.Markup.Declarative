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
    public static Expander OnCollapsed(this Expander control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsed += h);
    public static Expander OnCollapsing(this Expander control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsing += h);
    public static Expander OnExpanded(this Expander control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Expanded += h);
    public static Expander OnExpanding(this Expander control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Expanding += h);
}

