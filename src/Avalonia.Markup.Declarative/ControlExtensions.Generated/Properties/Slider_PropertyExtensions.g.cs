#nullable enable
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Slider = Avalonia.Controls.Slider;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SliderExtensions
{
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, func, onChanged, expression);
public static T IsDirectionReversed<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsSnapToTickEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);
public static T IsSnapToTickEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsSnapToTickEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, func, onChanged, expression);
public static T IsSnapToTickEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = value, bindingMode, converter, bindingSource);
public static T IsSnapToTickEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TickFrequency<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, binding);
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, func, onChanged, expression);
public static T TickFrequency<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static T TickFrequency<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TickPlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, binding);
public static T TickPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func, Action<Avalonia.Controls.TickPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, func, onChanged, expression);
public static T TickPlacement<T>(this T control, Avalonia.Controls.TickPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TickPlacementProperty, ps, () => control.TickPlacement = value, bindingMode, converter, bindingSource);
public static T TickPlacement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.TickPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TickPlacementProperty, ps, () => control.TickPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Ticks<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TicksProperty, binding);
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider
   => control._set(Avalonia.Controls.Slider.TicksProperty, func, onChanged, expression);
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static T Ticks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider
=> control._setEx(Avalonia.Controls.Slider.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

