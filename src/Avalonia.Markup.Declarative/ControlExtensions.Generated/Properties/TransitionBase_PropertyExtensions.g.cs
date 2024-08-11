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
public static T Duration<T>(this T control, IBinding binding) where T : TransitionBase
   => control._set(TransitionBase.DurationProperty, binding);
public static T Duration<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TransitionBase
   => control._set(TransitionBase.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Duration<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TransitionBase
   => control._set(TransitionBase.DurationProperty, func, onChanged, expression);
public static T Duration<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.DurationProperty, ps, () => control.Duration = value, bindingMode, converter, bindingSource);
public static T Duration<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.DurationProperty, ps, () => control.Duration = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Delay<T>(this T control, IBinding binding) where T : TransitionBase
   => control._set(TransitionBase.DelayProperty, binding);
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TransitionBase
   => control._set(TransitionBase.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Delay<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TransitionBase
   => control._set(TransitionBase.DelayProperty, func, onChanged, expression);
public static T Delay<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static T Delay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Easing<T>(this T control, IBinding binding) where T : TransitionBase
   => control._set(TransitionBase.EasingProperty, binding);
public static T Easing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TransitionBase
   => control._set(TransitionBase.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Easing<T>(this T control, Func<Easing> func, Action<Easing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TransitionBase
   => control._set(TransitionBase.EasingProperty, func, onChanged, expression);
public static T Easing<T>(this T control, Easing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.EasingProperty, ps, () => control.Easing = value, bindingMode, converter, bindingSource);
public static T Easing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Easing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TransitionBase
=> control._setEx(TransitionBase.EasingProperty, ps, () => control.Easing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

