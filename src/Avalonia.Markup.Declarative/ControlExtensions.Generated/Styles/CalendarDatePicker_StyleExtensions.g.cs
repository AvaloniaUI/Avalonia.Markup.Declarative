using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarDatePickerExtensions
{
public static Style<CalendarDatePicker> DisplayDate(this Style<CalendarDatePicker> style, DateTime value)
=> style._addSetter(CalendarDatePicker.DisplayDateProperty, value);
public static Style<CalendarDatePicker> DisplayDate(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.DisplayDateProperty, binding);
public static Style<CalendarDatePicker> DisplayDateStart(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
=> style._addSetter(CalendarDatePicker.DisplayDateStartProperty, value);
public static Style<CalendarDatePicker> DisplayDateStart(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.DisplayDateStartProperty, binding);
public static Style<CalendarDatePicker> DisplayDateEnd(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
=> style._addSetter(CalendarDatePicker.DisplayDateEndProperty, value);
public static Style<CalendarDatePicker> DisplayDateEnd(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.DisplayDateEndProperty, binding);
public static Style<CalendarDatePicker> FirstDayOfWeek(this Style<CalendarDatePicker> style, DayOfWeek value)
=> style._addSetter(CalendarDatePicker.FirstDayOfWeekProperty, value);
public static Style<CalendarDatePicker> FirstDayOfWeek(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static Style<CalendarDatePicker> IsDropDownOpen(this Style<CalendarDatePicker> style, Boolean value)
=> style._addSetter(CalendarDatePicker.IsDropDownOpenProperty, value);
public static Style<CalendarDatePicker> IsDropDownOpen(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.IsDropDownOpenProperty, binding);
public static Style<CalendarDatePicker> IsTodayHighlighted(this Style<CalendarDatePicker> style, Boolean value)
=> style._addSetter(CalendarDatePicker.IsTodayHighlightedProperty, value);
public static Style<CalendarDatePicker> IsTodayHighlighted(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static Style<CalendarDatePicker> SelectedDate(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
=> style._addSetter(CalendarDatePicker.SelectedDateProperty, value);
public static Style<CalendarDatePicker> SelectedDate(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.SelectedDateProperty, binding);
public static Style<CalendarDatePicker> SelectedDateFormat(this Style<CalendarDatePicker> style, CalendarDatePickerFormat value)
=> style._addSetter(CalendarDatePicker.SelectedDateFormatProperty, value);
public static Style<CalendarDatePicker> SelectedDateFormat(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.SelectedDateFormatProperty, binding);
public static Style<CalendarDatePicker> CustomDateFormatString(this Style<CalendarDatePicker> style, String value)
=> style._addSetter(CalendarDatePicker.CustomDateFormatStringProperty, value);
public static Style<CalendarDatePicker> CustomDateFormatString(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static Style<CalendarDatePicker> Text(this Style<CalendarDatePicker> style, String value)
=> style._addSetter(CalendarDatePicker.TextProperty, value);
public static Style<CalendarDatePicker> Text(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.TextProperty, binding);
public static Style<CalendarDatePicker> Watermark(this Style<CalendarDatePicker> style, String value)
=> style._addSetter(CalendarDatePicker.WatermarkProperty, value);
public static Style<CalendarDatePicker> Watermark(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.WatermarkProperty, binding);
public static Style<CalendarDatePicker> UseFloatingWatermark(this Style<CalendarDatePicker> style, Boolean value)
=> style._addSetter(CalendarDatePicker.UseFloatingWatermarkProperty, value);
public static Style<CalendarDatePicker> UseFloatingWatermark(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static Style<CalendarDatePicker> HorizontalContentAlignment(this Style<CalendarDatePicker> style, HorizontalAlignment value)
=> style._addSetter(CalendarDatePicker.HorizontalContentAlignmentProperty, value);
public static Style<CalendarDatePicker> HorizontalContentAlignment(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static Style<CalendarDatePicker> VerticalContentAlignment(this Style<CalendarDatePicker> style, VerticalAlignment value)
=> style._addSetter(CalendarDatePicker.VerticalContentAlignmentProperty, value);
public static Style<CalendarDatePicker> VerticalContentAlignment(this Style<CalendarDatePicker> style, IBinding binding)
=> style._addSetter(CalendarDatePicker.VerticalContentAlignmentProperty, binding);
}

