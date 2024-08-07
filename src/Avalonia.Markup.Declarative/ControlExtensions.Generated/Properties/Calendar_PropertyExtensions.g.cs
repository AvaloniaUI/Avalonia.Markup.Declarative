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
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, Func<DayOfWeek> func, Action<DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar FirstDayOfWeek<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar IsTodayHighlighted<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar HeaderBackground<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, binding);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, Func<CalendarMode> func, Action<CalendarMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, CalendarMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayMode<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, CalendarMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, binding);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, Func<CalendarSelectionMode> func, Action<CalendarSelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, CalendarSelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectionMode<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, CalendarSelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, binding);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectedDate<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, binding);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, Func<DateTime> func, Action<DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDate<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateStart<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, Action<Nullable<DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, func, onChanged, expression);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateEnd<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

