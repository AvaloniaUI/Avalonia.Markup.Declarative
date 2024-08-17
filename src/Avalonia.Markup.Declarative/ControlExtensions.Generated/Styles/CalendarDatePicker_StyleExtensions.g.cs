using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using CalendarDatePicker = Avalonia.Controls.CalendarDatePicker;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarDatePickerExtensions
{
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, value);
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, value);
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, value);
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, value);
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, value);
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);
public static Style<T> SelectedDateFormat<T>(this Style<T> style, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, value);
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);
public static Style<T> CustomDateFormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, value);
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, value);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);
}

