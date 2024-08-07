using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarDatePickerEventsExtensions
{
    public static CalendarDatePicker OnCalendarClosed(this CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarClosed += h);
    public static CalendarDatePicker OnCalendarOpened(this CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarOpened += h);
    public static CalendarDatePicker OnDateValidationError(this CalendarDatePicker control, Action<CalendarDatePickerDateValidationErrorEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>) ((_, args) => action(args)), h => control.DateValidationError += h);
    public static CalendarDatePicker OnSelectedDateChanged(this CalendarDatePicker control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}

