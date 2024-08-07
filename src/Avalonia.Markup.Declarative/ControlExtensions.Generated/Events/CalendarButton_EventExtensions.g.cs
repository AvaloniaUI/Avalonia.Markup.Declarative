using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarButtonEventsExtensions
{
    public static CalendarButton OnCalendarLeftMouseButtonDown(this CalendarButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonDown += h);
    public static CalendarButton OnCalendarLeftMouseButtonUp(this CalendarButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonUp += h);
}

