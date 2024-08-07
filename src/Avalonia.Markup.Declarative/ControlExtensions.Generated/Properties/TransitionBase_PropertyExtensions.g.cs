#nullable enable
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TransitionBaseExtensions
{
public static TransitionBase Duration(this TransitionBase control, IBinding binding)
   => control._set(TransitionBase.DurationProperty, binding);
public static TransitionBase Duration(this TransitionBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransitionBase.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransitionBase Duration(this TransitionBase control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitionBase.DurationProperty, func, onChanged, expression);
public static TransitionBase Duration(this TransitionBase control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.DurationProperty, ps, () => control.Duration = value, bindingMode, converter, bindingSource);
public static TransitionBase Duration<TValue>(this TransitionBase control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.DurationProperty, ps, () => control.Duration = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TransitionBase Delay(this TransitionBase control, IBinding binding)
   => control._set(TransitionBase.DelayProperty, binding);
public static TransitionBase Delay(this TransitionBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransitionBase.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransitionBase Delay(this TransitionBase control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitionBase.DelayProperty, func, onChanged, expression);
public static TransitionBase Delay(this TransitionBase control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static TransitionBase Delay<TValue>(this TransitionBase control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TransitionBase Easing(this TransitionBase control, IBinding binding)
   => control._set(TransitionBase.EasingProperty, binding);
public static TransitionBase Easing(this TransitionBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransitionBase.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransitionBase Easing(this TransitionBase control, Func<Easing> func, Action<Easing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitionBase.EasingProperty, func, onChanged, expression);
public static TransitionBase Easing(this TransitionBase control, Easing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.EasingProperty, ps, () => control.Easing = value, bindingMode, converter, bindingSource);
public static TransitionBase Easing<TValue>(this TransitionBase control, TValue value, FuncValueConverter<TValue, Easing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitionBase.EasingProperty, ps, () => control.Easing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

