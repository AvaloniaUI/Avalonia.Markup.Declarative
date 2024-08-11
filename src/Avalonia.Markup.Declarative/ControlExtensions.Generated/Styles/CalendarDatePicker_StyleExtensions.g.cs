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
public static Style<T> DisplayDate<T>(this Style<T> style, DateTime value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateProperty, value);
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateProperty, binding);
public static Style<T> DisplayDateStart<T>(this Style<T> style, Nullable<DateTime> value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateStartProperty, value);
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateStartProperty, binding);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, Nullable<DateTime> value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateEndProperty, value);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.DisplayDateEndProperty, binding);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, DayOfWeek value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.FirstDayOfWeekProperty, value);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, Boolean value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.IsDropDownOpenProperty, binding);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, Boolean value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.IsTodayHighlightedProperty, value);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, Nullable<DateTime> value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.SelectedDateProperty, binding);
public static Style<T> SelectedDateFormat<T>(this Style<T> style, CalendarDatePickerFormat value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.SelectedDateFormatProperty, value);
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.SelectedDateFormatProperty, binding);
public static Style<T> CustomDateFormatString<T>(this Style<T> style, String value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.CustomDateFormatStringProperty, value);
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.TextProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, String value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.WatermarkProperty, binding);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, Boolean value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.UseFloatingWatermarkProperty, value);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : CalendarDatePicker
=> style._addSetter(CalendarDatePicker.VerticalContentAlignmentProperty, binding);
}

