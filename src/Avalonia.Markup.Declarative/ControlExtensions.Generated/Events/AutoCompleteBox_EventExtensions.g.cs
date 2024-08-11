using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AutoCompleteBoxEventsExtensions
{
    public static T OnTextChanged<T>(this T control, Action<TextChangedEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static T OnPopulating<T>(this T control, Action<PopulatingEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<PopulatingEventArgs>) ((_, args) => action(args)), h => control.Populating += h);
    public static T OnPopulated<T>(this T control, Action<PopulatedEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<PopulatedEventArgs>) ((_, args) => action(args)), h => control.Populated += h);
    public static T OnDropDownOpening<T>(this T control, Action<CancelEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownOpening += h);
    public static T OnDropDownOpened<T>(this T control, Action action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
    public static T OnDropDownClosing<T>(this T control, Action<CancelEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownClosing += h);
    public static T OnDropDownClosed<T>(this T control, Action action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static T OnSelectionChanged<T>(this T control, Action<SelectionChangedEventArgs> action) where T : AutoCompleteBox => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}

