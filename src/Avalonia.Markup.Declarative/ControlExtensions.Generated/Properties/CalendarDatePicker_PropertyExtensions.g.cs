#nullable enable
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
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateProperty, binding);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, Func<DateTime> func, Action<DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateProperty, func, onChanged, expression);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDate<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, binding);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, func, onChanged, expression);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateStart<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, binding);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, func, onChanged, expression);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateEnd<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, Func<DayOfWeek> func, Action<DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, func, onChanged, expression);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker FirstDayOfWeek<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, binding);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, func, onChanged, expression);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker IsDropDownOpen<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, func, onChanged, expression);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker IsTodayHighlighted<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.SelectedDateProperty, binding);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.SelectedDateProperty, func, onChanged, expression);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDate<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, binding);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, Func<CalendarDatePickerFormat> func, Action<CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, func, onChanged, expression);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, CalendarDatePickerFormat value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDateFormat<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, CalendarDatePickerFormat> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, func, onChanged, expression);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker CustomDateFormatString<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker Text(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.TextProperty, binding);
public static CalendarDatePicker Text(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker Text(this CalendarDatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.TextProperty, func, onChanged, expression);
public static CalendarDatePicker Text(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker Text<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.WatermarkProperty, binding);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.WatermarkProperty, func, onChanged, expression);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker Watermark<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, func, onChanged, expression);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker UseFloatingWatermark<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker HorizontalContentAlignment<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, binding);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, func, onChanged, expression);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker VerticalContentAlignment<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

