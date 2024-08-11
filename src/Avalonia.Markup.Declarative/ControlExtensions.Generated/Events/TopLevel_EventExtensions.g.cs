using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelEventsExtensions
{
    public static T OnOpened<T>(this T control, Action action) where T : TopLevel => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static T OnClosed<T>(this T control, Action action) where T : TopLevel => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
    public static T OnScalingChanged<T>(this T control, Action action) where T : TopLevel => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScalingChanged += h);
    public static T OnBackRequested<T>(this T control, Action<RoutedEventArgs> action) where T : TopLevel => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.BackRequested += h);
}

