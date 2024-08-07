#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerPresenterExtensions
{
public static DatePickerPresenter Date(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DateProperty, binding);
public static DatePickerPresenter Date(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter Date(this DatePickerPresenter control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DateProperty, func, onChanged, expression);
public static DatePickerPresenter Date(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter Date<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DayFormatProperty, binding);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DayFormatProperty, func, onChanged, expression);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter DayFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DayVisibleProperty, binding);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DayVisibleProperty, func, onChanged, expression);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter DayVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MaxYearProperty, binding);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MaxYearProperty, func, onChanged, expression);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MaxYear<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MinYearProperty, binding);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MinYearProperty, func, onChanged, expression);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MinYear<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MonthFormatProperty, binding);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MonthFormatProperty, func, onChanged, expression);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MonthVisibleProperty, binding);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MonthVisibleProperty, func, onChanged, expression);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.YearFormatProperty, binding);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.YearFormatProperty, func, onChanged, expression);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter YearFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.YearVisibleProperty, binding);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.YearVisibleProperty, func, onChanged, expression);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter YearVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

