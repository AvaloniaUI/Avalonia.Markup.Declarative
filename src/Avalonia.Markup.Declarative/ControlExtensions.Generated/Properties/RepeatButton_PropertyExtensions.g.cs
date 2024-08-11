#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RepeatButtonExtensions
{
public static T Interval<T>(this T control, IBinding binding) where T : RepeatButton
   => control._set(RepeatButton.IntervalProperty, binding);
public static T Interval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RepeatButton
   => control._set(RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Interval<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RepeatButton
   => control._set(RepeatButton.IntervalProperty, func, onChanged, expression);
public static T Interval<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RepeatButton
=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = value, bindingMode, converter, bindingSource);
public static T Interval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RepeatButton
=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Delay<T>(this T control, IBinding binding) where T : RepeatButton
   => control._set(RepeatButton.DelayProperty, binding);
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RepeatButton
   => control._set(RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Delay<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RepeatButton
   => control._set(RepeatButton.DelayProperty, func, onChanged, expression);
public static T Delay<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RepeatButton
=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static T Delay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RepeatButton
=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

