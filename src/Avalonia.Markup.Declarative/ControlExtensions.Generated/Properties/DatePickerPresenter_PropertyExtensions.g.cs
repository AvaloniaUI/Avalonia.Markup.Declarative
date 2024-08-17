#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DatePickerPresenter = Avalonia.Controls.DatePickerPresenter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerPresenterExtensions
{
public static T Date<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);
public static T Date<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Date<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, func, onChanged, expression);
public static T Date<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);
public static T Date<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, func, onChanged, expression);
public static T DayFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static T DayFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, func, onChanged, expression);
public static T DayVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static T DayVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, func, onChanged, expression);
public static T MaxYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static T MaxYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, func, onChanged, expression);
public static T MinYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static T MinYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, func, onChanged, expression);
public static T MonthFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static T MonthFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, func, onChanged, expression);
public static T MonthVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static T MonthVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, func, onChanged, expression);
public static T YearFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static T YearFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, func, onChanged, expression);
public static T YearVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static T YearVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

