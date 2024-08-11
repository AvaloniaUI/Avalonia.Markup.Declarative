using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextBoxEventsExtensions
{
    public static T OnCopyingToClipboard<T>(this T control, Action<RoutedEventArgs> action) where T : TextBox => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
    public static T OnCuttingToClipboard<T>(this T control, Action<RoutedEventArgs> action) where T : TextBox => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CuttingToClipboard += h);
    public static T OnPastingFromClipboard<T>(this T control, Action<RoutedEventArgs> action) where T : TextBox => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PastingFromClipboard += h);
    public static T OnTextChanged<T>(this T control, Action<TextChangedEventArgs> action) where T : TextBox => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static T OnTextChanging<T>(this T control, Action<TextChangingEventArgs> action) where T : TextBox => 
        control._setEvent((EventHandler<TextChangingEventArgs>) ((_, args) => action(args)), h => control.TextChanging += h);
}

