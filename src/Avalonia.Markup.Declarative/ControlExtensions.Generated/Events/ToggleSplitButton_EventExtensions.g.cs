using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleSplitButton = Avalonia.Controls.ToggleSplitButton;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSplitButtonEventsExtensions
{
    public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.ToggleSplitButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.IsCheckedChanged += h);
}

