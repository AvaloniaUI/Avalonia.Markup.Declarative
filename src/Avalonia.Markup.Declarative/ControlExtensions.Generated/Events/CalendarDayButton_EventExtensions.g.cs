using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarDayButtonEventsExtensions
{
    public static CalendarDayButton OnCalendarDayButtonMouseDown(this CalendarDayButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseDown += h);
    public static CalendarDayButton OnCalendarDayButtonMouseUp(this CalendarDayButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseUp += h);
}

