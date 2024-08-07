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
    public static TopLevel OnOpened(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static TopLevel OnClosed(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
    public static TopLevel OnScalingChanged(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScalingChanged += h);
    public static TopLevel OnBackRequested(this TopLevel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.BackRequested += h);
}

