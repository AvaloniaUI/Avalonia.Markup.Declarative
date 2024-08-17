#nullable enable
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
public static T DisplayDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, func, onChanged, expression);
public static T DisplayDate<T>(this T control, System.DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static T DisplayDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, func, onChanged, expression);
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static T DisplayDateStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, func, onChanged, expression);
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, func, onChanged, expression);
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, func, onChanged, expression);
public static T IsDropDownOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, func, onChanged, expression);
public static T IsTodayHighlighted<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDateFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);
public static T SelectedDateFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDateFormat<T>(this T control, Func<Avalonia.Controls.CalendarDatePickerFormat> func, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, func, onChanged, expression);
public static T SelectedDateFormat<T>(this T control, Avalonia.Controls.CalendarDatePickerFormat value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value, bindingMode, converter, bindingSource);
public static T SelectedDateFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarDatePickerFormat> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CustomDateFormatString<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static T CustomDateFormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CustomDateFormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, func, onChanged, expression);
public static T CustomDateFormatString<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value, bindingMode, converter, bindingSource);
public static T CustomDateFormatString<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, func, onChanged, expression);
public static T UseFloatingWatermark<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker
=> control._setEx(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

