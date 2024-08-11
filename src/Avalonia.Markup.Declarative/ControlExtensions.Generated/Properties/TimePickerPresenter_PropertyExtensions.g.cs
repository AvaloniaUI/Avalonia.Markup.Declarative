#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerPresenterExtensions
{
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.MinuteIncrementProperty, binding);
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinuteIncrement<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.MinuteIncrementProperty, func, onChanged, expression);
public static T MinuteIncrement<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static T MinuteIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.ClockIdentifierProperty, binding);
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClockIdentifier<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.ClockIdentifierProperty, func, onChanged, expression);
public static T ClockIdentifier<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static T ClockIdentifier<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Time<T>(this T control, IBinding binding) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.TimeProperty, binding);
public static T Time<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Time<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TimePickerPresenter
   => control._set(TimePickerPresenter.TimeProperty, func, onChanged, expression);
public static T Time<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = value, bindingMode, converter, bindingSource);
public static T Time<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TimePickerPresenter
=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

