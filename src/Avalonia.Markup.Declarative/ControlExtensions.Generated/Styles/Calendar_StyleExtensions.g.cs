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
public static Style<Avalonia.Controls.Calendar> FirstDayOfWeek(this Style<Avalonia.Controls.Calendar> style, DayOfWeek value)
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, value);
public static Style<Avalonia.Controls.Calendar> FirstDayOfWeek(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);
public static Style<Avalonia.Controls.Calendar> IsTodayHighlighted(this Style<Avalonia.Controls.Calendar> style, Boolean value)
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, value);
public static Style<Avalonia.Controls.Calendar> IsTodayHighlighted(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);
public static Style<Avalonia.Controls.Calendar> HeaderBackground(this Style<Avalonia.Controls.Calendar> style, IBrush value)
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, value);
public static Style<Avalonia.Controls.Calendar> HeaderBackground(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);
public static Style<Avalonia.Controls.Calendar> DisplayMode(this Style<Avalonia.Controls.Calendar> style, CalendarMode value)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, value);
public static Style<Avalonia.Controls.Calendar> DisplayMode(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, binding);
public static Style<Avalonia.Controls.Calendar> SelectionMode(this Style<Avalonia.Controls.Calendar> style, CalendarSelectionMode value)
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, value);
public static Style<Avalonia.Controls.Calendar> SelectionMode(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, binding);
public static Style<Avalonia.Controls.Calendar> SelectedDate(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, value);
public static Style<Avalonia.Controls.Calendar> SelectedDate(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, binding);
public static Style<Avalonia.Controls.Calendar> DisplayDate(this Style<Avalonia.Controls.Calendar> style, DateTime value)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, value);
public static Style<Avalonia.Controls.Calendar> DisplayDate(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, binding);
public static Style<Avalonia.Controls.Calendar> DisplayDateStart(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, value);
public static Style<Avalonia.Controls.Calendar> DisplayDateStart(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);
public static Style<Avalonia.Controls.Calendar> DisplayDateEnd(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, value);
public static Style<Avalonia.Controls.Calendar> DisplayDateEnd(this Style<Avalonia.Controls.Calendar> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);
}

