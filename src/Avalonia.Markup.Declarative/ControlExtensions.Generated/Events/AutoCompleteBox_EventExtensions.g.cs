using AutoCompleteBox = Avalonia.Controls.AutoCompleteBox;
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
    public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TextChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextChanged += h);
    public static T OnPopulating<T>(this T control, Action<Avalonia.Controls.PopulatingEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.PopulatingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populating += h);
    public static T OnPopulated<T>(this T control, Action<Avalonia.Controls.PopulatedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.PopulatedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populated += h);
    public static T OnDropDownOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownOpening += h);
    public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);
    public static T OnDropDownClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownClosing += h);
    public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);
    public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);
}

