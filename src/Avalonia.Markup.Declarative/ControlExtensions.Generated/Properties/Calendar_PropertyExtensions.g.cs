#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarExtensions
{
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.FirstDayOfWeekProperty, binding);
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FirstDayOfWeek<T>(this T control, Func<DayOfWeek> func, Action<DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.FirstDayOfWeekProperty, func, onChanged, expression);
public static T FirstDayOfWeek<T>(this T control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.IsTodayHighlightedProperty, binding);
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTodayHighlighted<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.IsTodayHighlightedProperty, func, onChanged, expression);
public static T IsTodayHighlighted<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HeaderBackground<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.HeaderBackgroundProperty, binding);
public static T HeaderBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HeaderBackground<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.HeaderBackgroundProperty, func, onChanged, expression);
public static T HeaderBackground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static T HeaderBackground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMode<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.DisplayModeProperty, binding);
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMode<T>(this T control, Func<CalendarMode> func, Action<CalendarMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.DisplayModeProperty, func, onChanged, expression);
public static T DisplayMode<T>(this T control, CalendarMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static T DisplayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CalendarMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionMode<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.SelectionModeProperty, binding);
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionMode<T>(this T control, Func<CalendarSelectionMode> func, Action<CalendarSelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.SelectionModeProperty, func, onChanged, expression);
public static T SelectionMode<T>(this T control, CalendarSelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CalendarSelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDate<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.DisplayDateProperty, binding);
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDate<T>(this T control, Func<DateTime> func, Action<DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.DisplayDateProperty, func, onChanged, expression);
public static T DisplayDate<T>(this T control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static T DisplayDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.DisplayDateStartProperty, binding);
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateStart<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.DisplayDateStartProperty, func, onChanged, expression);
public static T DisplayDateStart<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static T DisplayDateStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Calendar
   => control._set(Calendar.DisplayDateEndProperty, binding);
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Calendar
   => control._set(Calendar.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateEnd<T>(this T control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Calendar
   => control._set(Calendar.DisplayDateEndProperty, func, onChanged, expression);
public static T DisplayDateEnd<T>(this T control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Calendar
=> control._setEx(Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

