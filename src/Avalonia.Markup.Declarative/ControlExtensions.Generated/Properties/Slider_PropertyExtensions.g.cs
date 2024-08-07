#nullable enable
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SliderExtensions
{
public static Slider Orientation(this Slider control, IBinding binding)
   => control._set(Slider.OrientationProperty, binding);
public static Slider Orientation(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider Orientation(this Slider control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.OrientationProperty, func, onChanged, expression);
public static Slider Orientation(this Slider control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static Slider Orientation<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider IsDirectionReversed(this Slider control, IBinding binding)
   => control._set(Slider.IsDirectionReversedProperty, binding);
public static Slider IsDirectionReversed(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider IsDirectionReversed(this Slider control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.IsDirectionReversedProperty, func, onChanged, expression);
public static Slider IsDirectionReversed(this Slider control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static Slider IsDirectionReversed<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider IsSnapToTickEnabled(this Slider control, IBinding binding)
   => control._set(Slider.IsSnapToTickEnabledProperty, binding);
public static Slider IsSnapToTickEnabled(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.IsSnapToTickEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider IsSnapToTickEnabled(this Slider control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.IsSnapToTickEnabledProperty, func, onChanged, expression);
public static Slider IsSnapToTickEnabled(this Slider control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = value, bindingMode, converter, bindingSource);
public static Slider IsSnapToTickEnabled<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider TickFrequency(this Slider control, IBinding binding)
   => control._set(Slider.TickFrequencyProperty, binding);
public static Slider TickFrequency(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider TickFrequency(this Slider control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TickFrequencyProperty, func, onChanged, expression);
public static Slider TickFrequency(this Slider control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static Slider TickFrequency<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider TickPlacement(this Slider control, IBinding binding)
   => control._set(Slider.TickPlacementProperty, binding);
public static Slider TickPlacement(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.TickPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider TickPlacement(this Slider control, Func<TickPlacement> func, Action<TickPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TickPlacementProperty, func, onChanged, expression);
public static Slider TickPlacement(this Slider control, TickPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickPlacementProperty, ps, () => control.TickPlacement = value, bindingMode, converter, bindingSource);
public static Slider TickPlacement<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, TickPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickPlacementProperty, ps, () => control.TickPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider Ticks(this Slider control, IBinding binding)
   => control._set(Slider.TicksProperty, binding);
public static Slider Ticks(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Slider.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Slider Ticks(this Slider control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TicksProperty, func, onChanged, expression);
public static Slider Ticks(this Slider control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static Slider Ticks<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

