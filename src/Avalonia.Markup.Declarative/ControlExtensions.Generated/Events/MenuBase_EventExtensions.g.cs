using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MenuBaseEventsExtensions
{
    public static T OnOpened<T>(this T control, Action<RoutedEventArgs> action) where T : MenuBase => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Opened += h);
    public static T OnClosed<T>(this T control, Action<RoutedEventArgs> action) where T : MenuBase => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}

