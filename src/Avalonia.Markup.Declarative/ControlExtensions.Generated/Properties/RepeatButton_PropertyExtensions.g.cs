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
public static RepeatButton Interval(this RepeatButton control, IBinding binding)
   => control._set(RepeatButton.IntervalProperty, binding);
public static RepeatButton Interval(this RepeatButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RepeatButton Interval(this RepeatButton control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RepeatButton.IntervalProperty, func, onChanged, expression);
public static RepeatButton Interval(this RepeatButton control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = value, bindingMode, converter, bindingSource);
public static RepeatButton Interval<TValue>(this RepeatButton control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RepeatButton Delay(this RepeatButton control, IBinding binding)
   => control._set(RepeatButton.DelayProperty, binding);
public static RepeatButton Delay(this RepeatButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RepeatButton Delay(this RepeatButton control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RepeatButton.DelayProperty, func, onChanged, expression);
public static RepeatButton Delay(this RepeatButton control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static RepeatButton Delay<TValue>(this RepeatButton control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

