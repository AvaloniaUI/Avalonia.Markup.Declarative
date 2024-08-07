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
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, binding);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, func, onChanged, expression);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter MinuteIncrement<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, binding);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, func, onChanged, expression);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter ClockIdentifier<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePickerPresenter Time(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.TimeProperty, binding);
public static TimePickerPresenter Time(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePickerPresenter.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePickerPresenter Time(this TimePickerPresenter control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.TimeProperty, func, onChanged, expression);
public static TimePickerPresenter Time(this TimePickerPresenter control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter Time<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

