using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleButtonEventsExtensions
{
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnChecked(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Checked += h);
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnUnchecked(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unchecked += h);
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnIndeterminate(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Indeterminate += h);
    public static ToggleButton OnIsCheckedChanged(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.IsCheckedChanged += h);
}

