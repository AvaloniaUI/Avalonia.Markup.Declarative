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
public static T DisplayDate<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateProperty, binding);
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDate<T>(this T control, Func<DateTime> func, Action<DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateProperty, func, onChanged, expression);
public static T DisplayDate<T>(this T control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static T DisplayDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateStartProperty, binding);
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateStart<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateStartProperty, func, onChanged, expression);
public static T DisplayDateStart<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static T DisplayDateStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateEndProperty, binding);
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateEnd<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.DisplayDateEndProperty, func, onChanged, expression);
public static T DisplayDateEnd<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FirstDayOfWeek<T>(this T control, Func<DayOfWeek> func, Action<DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, func, onChanged, expression);
public static T FirstDayOfWeek<T>(this T control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, binding);
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDropDownOpen<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, func, onChanged, expression);
public static T IsDropDownOpen<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTodayHighlighted<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, func, onChanged, expression);
public static T IsTodayHighlighted<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDateFormat<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, binding);
public static T SelectedDateFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDateFormat<T>(this T control, Func<CalendarDatePickerFormat> func, Action<CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, func, onChanged, expression);
public static T SelectedDateFormat<T>(this T control, CalendarDatePickerFormat value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value, bindingMode, converter, bindingSource);
public static T SelectedDateFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CalendarDatePickerFormat> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CustomDateFormatString<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static T CustomDateFormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CustomDateFormatString<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, func, onChanged, expression);
public static T CustomDateFormatString<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value, bindingMode, converter, bindingSource);
public static T CustomDateFormatString<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseFloatingWatermark<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, func, onChanged, expression);
public static T UseFloatingWatermark<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CalendarDatePicker
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CalendarDatePicker
=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

