using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlEventsExtensions
{
    public static T OnContextRequested<T>(this T control, Action<ContextRequestedEventArgs> action) where T : Control => 
        control._setEvent((EventHandler<ContextRequestedEventArgs>) ((_, args) => action(args)), h => control.ContextRequested += h);
    public static T OnLoaded<T>(this T control, Action<RoutedEventArgs> action) where T : Control => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Loaded += h);
    public static T OnUnloaded<T>(this T control, Action<RoutedEventArgs> action) where T : Control => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unloaded += h);
    public static T OnSizeChanged<T>(this T control, Action<SizeChangedEventArgs> action) where T : Control => 
        control._setEvent((EventHandler<SizeChangedEventArgs>) ((_, args) => action(args)), h => control.SizeChanged += h);
}

