#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RepeatButton = Avalonia.Controls.RepeatButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RepeatButtonExtensions
{
public static T Interval<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, binding);
public static T Interval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Interval<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, func, onChanged, expression);
public static T Interval<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton
=> control._setEx(Avalonia.Controls.RepeatButton.IntervalProperty, ps, () => control.Interval = value, bindingMode, converter, bindingSource);
public static T Interval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton
=> control._setEx(Avalonia.Controls.RepeatButton.IntervalProperty, ps, () => control.Interval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Delay<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, binding);
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Delay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RepeatButton
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, func, onChanged, expression);
public static T Delay<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton
=> control._setEx(Avalonia.Controls.RepeatButton.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static T Delay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton
=> control._setEx(Avalonia.Controls.RepeatButton.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

