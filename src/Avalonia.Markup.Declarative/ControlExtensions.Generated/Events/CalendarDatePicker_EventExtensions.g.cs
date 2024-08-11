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
    public static T OnCalendarClosed<T>(this T control, Action action) where T : CalendarDatePicker => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarClosed += h);
    public static T OnCalendarOpened<T>(this T control, Action action) where T : CalendarDatePicker => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarOpened += h);
    public static T OnDateValidationError<T>(this T control, Action<CalendarDatePickerDateValidationErrorEventArgs> action) where T : CalendarDatePicker => 
        control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>) ((_, args) => action(args)), h => control.DateValidationError += h);
    public static T OnSelectedDateChanged<T>(this T control, Action<SelectionChangedEventArgs> action) where T : CalendarDatePicker => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}

