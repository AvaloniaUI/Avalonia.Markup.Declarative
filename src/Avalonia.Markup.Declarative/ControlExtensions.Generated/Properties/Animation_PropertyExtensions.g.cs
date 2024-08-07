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
public static partial class AnimationExtensions
{
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DurationProperty, binding);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DurationProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DurationProperty, ps, () => control.Duration = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Duration<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DurationProperty, ps, () => control.Duration = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, binding);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<IterationCount> func, Action<IterationCount>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IterationCount value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.IterationCountProperty, ps, () => control.IterationCount = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation IterationCount<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, IterationCount> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.IterationCountProperty, ps, () => control.IterationCount = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, UInt64 value = default)
   => control._set(() => control.IterationCount = new IterationCount(value));
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, UInt64 value = default, IterationType type = default)
   => control._set(() => control.IterationCount = new IterationCount(value, type));
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, binding);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<PlaybackDirection> func, Action<PlaybackDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, PlaybackDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.PlaybackDirectionProperty, ps, () => control.PlaybackDirection = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation PlaybackDirection<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, PlaybackDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.PlaybackDirectionProperty, ps, () => control.PlaybackDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, binding);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<FillMode> func, Action<FillMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, FillMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.FillModeProperty, ps, () => control.FillMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation FillMode<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, FillMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.FillModeProperty, ps, () => control.FillMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.EasingProperty, binding);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<Easing> func, Action<Easing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.EasingProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Easing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.EasingProperty, ps, () => control.Easing = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Easing<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, Easing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.EasingProperty, ps, () => control.Easing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DelayProperty, binding);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DelayProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Delay<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, binding);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, ps, () => control.DelayBetweenIterations = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation DelayBetweenIterations<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, ps, () => control.DelayBetweenIterations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, binding);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, func, onChanged, expression);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.SpeedRatioProperty, ps, () => control.SpeedRatio = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation SpeedRatio<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.SpeedRatioProperty, ps, () => control.SpeedRatio = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

