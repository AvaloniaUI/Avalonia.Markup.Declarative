using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarExtensions
{
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, DayOfWeek value) where T : Calendar
=> style._addSetter(Calendar.FirstDayOfWeekProperty, value);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.FirstDayOfWeekProperty, binding);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, Boolean value) where T : Calendar
=> style._addSetter(Calendar.IsTodayHighlightedProperty, value);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.IsTodayHighlightedProperty, binding);
public static Style<T> HeaderBackground<T>(this Style<T> style, IBrush value) where T : Calendar
=> style._addSetter(Calendar.HeaderBackgroundProperty, value);
public static Style<T> HeaderBackground<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.HeaderBackgroundProperty, binding);
public static Style<T> DisplayMode<T>(this Style<T> style, CalendarMode value) where T : Calendar
=> style._addSetter(Calendar.DisplayModeProperty, value);
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.DisplayModeProperty, binding);
public static Style<T> SelectionMode<T>(this Style<T> style, CalendarSelectionMode value) where T : Calendar
=> style._addSetter(Calendar.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.SelectionModeProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, Nullable<DateTime> value) where T : Calendar
=> style._addSetter(Calendar.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.SelectedDateProperty, binding);
public static Style<T> DisplayDate<T>(this Style<T> style, DateTime value) where T : Calendar
=> style._addSetter(Calendar.DisplayDateProperty, value);
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.DisplayDateProperty, binding);
public static Style<T> DisplayDateStart<T>(this Style<T> style, Nullable<DateTime> value) where T : Calendar
=> style._addSetter(Calendar.DisplayDateStartProperty, value);
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.DisplayDateStartProperty, binding);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, Nullable<DateTime> value) where T : Calendar
=> style._addSetter(Calendar.DisplayDateEndProperty, value);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Calendar
=> style._addSetter(Calendar.DisplayDateEndProperty, binding);
}

