#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DatePicker = Avalonia.Controls.DatePicker;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerExtensions
{
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, binding);
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, func, onChanged, expression);
public static T DayFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static T DayFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, func, onChanged, expression);
public static T DayVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static T DayVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, binding);
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, func, onChanged, expression);
public static T MaxYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static T MaxYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, binding);
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, func, onChanged, expression);
public static T MinYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static T MinYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, func, onChanged, expression);
public static T MonthFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static T MonthFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, func, onChanged, expression);
public static T MonthVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static T MonthVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, binding);
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, func, onChanged, expression);
public static T YearFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static T YearFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, func, onChanged, expression);
public static T YearVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static T YearVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTimeOffset>> func, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTimeOffset> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTimeOffset>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker
=> control._setEx(Avalonia.Controls.DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

