using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StackPanelEventsExtensions
{
    public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<RoutedEventArgs> action) where T : StackPanel => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.HorizontalSnapPointsChanged += h);
    public static T OnVerticalSnapPointsChanged<T>(this T control, Action<RoutedEventArgs> action) where T : StackPanel => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.VerticalSnapPointsChanged += h);
}

