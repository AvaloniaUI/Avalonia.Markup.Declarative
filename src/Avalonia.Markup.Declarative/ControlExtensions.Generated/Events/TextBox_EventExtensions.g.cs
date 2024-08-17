using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextBox = Avalonia.Controls.TextBox;

namespace Avalonia.Markup.Declarative;
public static partial class TextBoxEventsExtensions
{
    public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CopyingToClipboard += h);
    public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CuttingToClipboard += h);
    public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PastingFromClipboard += h);
    public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TextChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextChanged += h);
    public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TextChangingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextChanging += h);
}

