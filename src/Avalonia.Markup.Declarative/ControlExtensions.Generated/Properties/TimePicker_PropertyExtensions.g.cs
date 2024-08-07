#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerExtensions
{
public static TimePicker MinuteIncrement(this TimePicker control, IBinding binding)
   => control._set(TimePicker.MinuteIncrementProperty, binding);
public static TimePicker MinuteIncrement(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePicker MinuteIncrement(this TimePicker control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.MinuteIncrementProperty, func, onChanged, expression);
public static TimePicker MinuteIncrement(this TimePicker control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static TimePicker MinuteIncrement<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePicker ClockIdentifier(this TimePicker control, IBinding binding)
   => control._set(TimePicker.ClockIdentifierProperty, binding);
public static TimePicker ClockIdentifier(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePicker ClockIdentifier(this TimePicker control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.ClockIdentifierProperty, func, onChanged, expression);
public static TimePicker ClockIdentifier(this TimePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static TimePicker ClockIdentifier<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePicker SelectedTime(this TimePicker control, IBinding binding)
   => control._set(TimePicker.SelectedTimeProperty, binding);
public static TimePicker SelectedTime(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TimePicker SelectedTime(this TimePicker control, Func<Nullable<TimeSpan>> func, Action<Nullable<TimeSpan>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.SelectedTimeProperty, func, onChanged, expression);
public static TimePicker SelectedTime(this TimePicker control, Nullable<TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value, bindingMode, converter, bindingSource);
public static TimePicker SelectedTime<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, Nullable<TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

