using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Control = Avalonia.Controls.Control;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlEventsExtensions
{
    public static T OnContextRequested<T>(this T control, Action<Avalonia.Controls.ContextRequestedEventArgs> action) where T : Avalonia.Controls.Control => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ContextRequestedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContextRequested += h);
    public static T OnLoaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Control => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Loaded += h);
    public static T OnUnloaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Control => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Unloaded += h);
    public static T OnSizeChanged<T>(this T control, Action<Avalonia.Controls.SizeChangedEventArgs> action) where T : Avalonia.Controls.Control => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SizeChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SizeChanged += h);
}

