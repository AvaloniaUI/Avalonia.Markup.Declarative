using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MenuItemEventsExtensions
{
    public static T OnClick<T>(this T control, Action<RoutedEventArgs> action) where T : MenuItem => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
    public static T OnPointerEnteredItem<T>(this T control, Action<RoutedEventArgs> action) where T : MenuItem => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PointerEnteredItem += h);
    public static T OnPointerExitedItem<T>(this T control, Action<RoutedEventArgs> action) where T : MenuItem => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PointerExitedItem += h);
    public static T OnSubmenuOpened<T>(this T control, Action<RoutedEventArgs> action) where T : MenuItem => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.SubmenuOpened += h);
}

