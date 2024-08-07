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
public static DatePicker DayFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.DayFormatProperty, binding);
public static DatePicker DayFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker DayFormat(this DatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.DayFormatProperty, func, onChanged, expression);
public static DatePicker DayFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static DatePicker DayFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker DayVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.DayVisibleProperty, binding);
public static DatePicker DayVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker DayVisible(this DatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.DayVisibleProperty, func, onChanged, expression);
public static DatePicker DayVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static DatePicker DayVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MaxYear(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MaxYearProperty, binding);
public static DatePicker MaxYear(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker MaxYear(this DatePicker control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MaxYearProperty, func, onChanged, expression);
public static DatePicker MaxYear(this DatePicker control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static DatePicker MaxYear<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MinYear(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MinYearProperty, binding);
public static DatePicker MinYear(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker MinYear(this DatePicker control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MinYearProperty, func, onChanged, expression);
public static DatePicker MinYear(this DatePicker control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static DatePicker MinYear<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MonthFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MonthFormatProperty, binding);
public static DatePicker MonthFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker MonthFormat(this DatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MonthFormatProperty, func, onChanged, expression);
public static DatePicker MonthFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static DatePicker MonthFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MonthVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MonthVisibleProperty, binding);
public static DatePicker MonthVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker MonthVisible(this DatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MonthVisibleProperty, func, onChanged, expression);
public static DatePicker MonthVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static DatePicker MonthVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker YearFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.YearFormatProperty, binding);
public static DatePicker YearFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker YearFormat(this DatePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.YearFormatProperty, func, onChanged, expression);
public static DatePicker YearFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static DatePicker YearFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker YearVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.YearVisibleProperty, binding);
public static DatePicker YearVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker YearVisible(this DatePicker control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.YearVisibleProperty, func, onChanged, expression);
public static DatePicker YearVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static DatePicker YearVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker SelectedDate(this DatePicker control, IBinding binding)
   => control._set(DatePicker.SelectedDateProperty, binding);
public static DatePicker SelectedDate(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePicker SelectedDate(this DatePicker control, Func<Nullable<DateTimeOffset>> func, Action<Nullable<DateTimeOffset>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.SelectedDateProperty, func, onChanged, expression);
public static DatePicker SelectedDate(this DatePicker control, Nullable<DateTimeOffset> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static DatePicker SelectedDate<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTimeOffset>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

