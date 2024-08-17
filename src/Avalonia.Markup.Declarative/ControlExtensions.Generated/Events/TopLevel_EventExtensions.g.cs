using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TopLevel = Avalonia.Controls.TopLevel;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelEventsExtensions
{
    public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);
    public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);
    public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);
    public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.BackRequested += h);
}

