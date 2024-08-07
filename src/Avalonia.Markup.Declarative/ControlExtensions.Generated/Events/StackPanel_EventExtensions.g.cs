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
    public static StackPanel OnHorizontalSnapPointsChanged(this StackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.HorizontalSnapPointsChanged += h);
    public static StackPanel OnVerticalSnapPointsChanged(this StackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.VerticalSnapPointsChanged += h);
}

