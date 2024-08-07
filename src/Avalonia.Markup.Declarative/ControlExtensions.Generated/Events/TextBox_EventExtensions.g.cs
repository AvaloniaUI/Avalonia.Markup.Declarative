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
    public static TextBox OnCopyingToClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
    public static TextBox OnCuttingToClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CuttingToClipboard += h);
    public static TextBox OnPastingFromClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PastingFromClipboard += h);
    public static TextBox OnTextChanged(this TextBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static TextBox OnTextChanging(this TextBox control, Action<TextChangingEventArgs> action) => 
        control._setEvent((EventHandler<TextChangingEventArgs>) ((_, args) => action(args)), h => control.TextChanging += h);
}

