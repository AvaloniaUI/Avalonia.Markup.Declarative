#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerExtensions
{
public static T DayFormat<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.DayFormatProperty, binding);
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.DayFormatProperty, func, onChanged, expression);
public static T DayFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static T DayFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayVisible<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.DayVisibleProperty, binding);
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.DayVisibleProperty, func, onChanged, expression);
public static T DayVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static T DayVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxYear<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.MaxYearProperty, binding);
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxYear<T>(this T control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.MaxYearProperty, func, onChanged, expression);
public static T MaxYear<T>(this T control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static T MaxYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinYear<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.MinYearProperty, binding);
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinYear<T>(this T control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.MinYearProperty, func, onChanged, expression);
public static T MinYear<T>(this T control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static T MinYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthFormat<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.MonthFormatProperty, binding);
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.MonthFormatProperty, func, onChanged, expression);
public static T MonthFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static T MonthFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthVisible<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.MonthVisibleProperty, binding);
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.MonthVisibleProperty, func, onChanged, expression);
public static T MonthVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static T MonthVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearFormat<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.YearFormatProperty, binding);
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.YearFormatProperty, func, onChanged, expression);
public static T YearFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static T YearFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearVisible<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.YearVisibleProperty, binding);
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.YearVisibleProperty, func, onChanged, expression);
public static T YearVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static T YearVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : DatePicker
   => control._set(DatePicker.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePicker
   => control._set(DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<Nullable<DateTimeOffset>> func, Action<Nullable<DateTimeOffset>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePicker
   => control._set(DatePicker.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, Nullable<DateTimeOffset> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTimeOffset>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePicker
=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

