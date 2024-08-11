using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarEventsExtensions
{
    public static T OnSelectedDatesChanged<T>(this T control, Action<SelectionChangedEventArgs> action) where T : Calendar => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDatesChanged += h);
    public static T OnDisplayDateChanged<T>(this T control, Action<CalendarDateChangedEventArgs> action) where T : Calendar => 
        control._setEvent((EventHandler<CalendarDateChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayDateChanged += h);
    public static T OnDisplayModeChanged<T>(this T control, Action<CalendarModeChangedEventArgs> action) where T : Calendar => 
        control._setEvent((EventHandler<CalendarModeChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayModeChanged += h);
}

