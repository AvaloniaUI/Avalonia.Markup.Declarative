using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Calendar = Avalonia.Controls.Calendar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarExtensions
{
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, value);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, value);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);
public static Style<T> HeaderBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, value);
public static Style<T> HeaderBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, value);
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, binding);
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, binding);
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, value);
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, binding);
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, value);
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, value);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);
}

