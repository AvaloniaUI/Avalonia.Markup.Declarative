#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Calendar = Avalonia.Controls.Calendar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarExtensions
{
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, func, onChanged, expression);
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static T FirstDayOfWeek<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, func, onChanged, expression);
public static T IsTodayHighlighted<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static T IsTodayHighlighted<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HeaderBackground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);
public static T HeaderBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HeaderBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, func, onChanged, expression);
public static T HeaderBackground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static T HeaderBackground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, binding);
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.CalendarMode> func, Action<Avalonia.Controls.CalendarMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, func, onChanged, expression);
public static T DisplayMode<T>(this T control, Avalonia.Controls.CalendarMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static T DisplayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, binding);
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.CalendarSelectionMode> func, Action<Avalonia.Controls.CalendarSelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, func, onChanged, expression);
public static T SelectionMode<T>(this T control, Avalonia.Controls.CalendarSelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarSelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, binding);
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, func, onChanged, expression);
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, binding);
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, func, onChanged, expression);
public static T DisplayDate<T>(this T control, System.DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static T DisplayDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, func, onChanged, expression);
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static T DisplayDateStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, func, onChanged, expression);
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static T DisplayDateEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

