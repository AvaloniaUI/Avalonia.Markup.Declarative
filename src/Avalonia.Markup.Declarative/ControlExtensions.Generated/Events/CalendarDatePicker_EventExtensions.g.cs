using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using CalendarDatePicker = Avalonia.Controls.CalendarDatePicker;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarDatePickerEventsExtensions
{
    public static T OnCalendarClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarClosed += h);
    public static T OnCalendarOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarOpened += h);
    public static T OnDateValidationError<T>(this T control, Action<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DateValidationError += h);
    public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);
}

