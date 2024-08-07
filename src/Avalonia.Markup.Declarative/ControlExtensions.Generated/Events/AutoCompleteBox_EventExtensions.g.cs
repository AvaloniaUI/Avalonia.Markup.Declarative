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
    public static AutoCompleteBox OnTextChanged(this AutoCompleteBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static AutoCompleteBox OnPopulating(this AutoCompleteBox control, Action<PopulatingEventArgs> action) => 
        control._setEvent((EventHandler<PopulatingEventArgs>) ((_, args) => action(args)), h => control.Populating += h);
    public static AutoCompleteBox OnPopulated(this AutoCompleteBox control, Action<PopulatedEventArgs> action) => 
        control._setEvent((EventHandler<PopulatedEventArgs>) ((_, args) => action(args)), h => control.Populated += h);
    public static AutoCompleteBox OnDropDownOpening(this AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownOpening += h);
    public static AutoCompleteBox OnDropDownOpened(this AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
    public static AutoCompleteBox OnDropDownClosing(this AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownClosing += h);
    public static AutoCompleteBox OnDropDownClosed(this AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static AutoCompleteBox OnSelectionChanged(this AutoCompleteBox control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}

