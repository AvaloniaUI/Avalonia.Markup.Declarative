#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TimePicker = Avalonia.Controls.TimePicker;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerExtensions
{
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, func, onChanged, expression);
public static T MinuteIncrement<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static T MinuteIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, func, onChanged, expression);
public static T ClockIdentifier<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static T ClockIdentifier<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedTime<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);
public static T SelectedTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, func, onChanged, expression);
public static T SelectedTime<T>(this T control, System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value, bindingMode, converter, bindingSource);
public static T SelectedTime<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

