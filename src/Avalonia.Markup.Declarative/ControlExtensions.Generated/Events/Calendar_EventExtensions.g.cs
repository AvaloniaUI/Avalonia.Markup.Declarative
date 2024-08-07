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
    public static Calendar OnSelectedDatesChanged(this Calendar control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDatesChanged += h);
    public static Calendar OnDisplayDateChanged(this Calendar control, Action<CalendarDateChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDateChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayDateChanged += h);
    public static Calendar OnDisplayModeChanged(this Calendar control, Action<CalendarModeChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarModeChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayModeChanged += h);
}

