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
public static T Date<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DateProperty, binding);
public static T Date<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Date<T>(this T control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DateProperty, func, onChanged, expression);
public static T Date<T>(this T control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);
public static T Date<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayFormat<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayFormatProperty, binding);
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayFormatProperty, func, onChanged, expression);
public static T DayFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static T DayFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayVisible<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayVisibleProperty, binding);
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.DayVisibleProperty, func, onChanged, expression);
public static T DayVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static T DayVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxYear<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MaxYearProperty, binding);
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxYear<T>(this T control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MaxYearProperty, func, onChanged, expression);
public static T MaxYear<T>(this T control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static T MaxYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinYear<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MinYearProperty, binding);
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinYear<T>(this T control, Func<DateTimeOffset> func, Action<DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MinYearProperty, func, onChanged, expression);
public static T MinYear<T>(this T control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static T MinYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthFormat<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthFormatProperty, binding);
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthFormatProperty, func, onChanged, expression);
public static T MonthFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static T MonthFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthVisible<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthVisibleProperty, binding);
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.MonthVisibleProperty, func, onChanged, expression);
public static T MonthVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static T MonthVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearFormat<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearFormatProperty, binding);
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearFormatProperty, func, onChanged, expression);
public static T YearFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static T YearFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearVisible<T>(this T control, IBinding binding) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearVisibleProperty, binding);
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DatePickerPresenter
   => control._set(DatePickerPresenter.YearVisibleProperty, func, onChanged, expression);
public static T YearVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static T YearVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DatePickerPresenter
=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

