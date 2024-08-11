#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TrackExtensions
{
public static T Minimum<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.MinimumProperty, binding);
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Minimum<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.MinimumProperty, func, onChanged, expression);
public static T Minimum<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static T Minimum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Maximum<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.MaximumProperty, binding);
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Maximum<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.MaximumProperty, func, onChanged, expression);
public static T Maximum<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static T Maximum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Value<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.ValueProperty, binding);
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Value<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.ValueProperty, func, onChanged, expression);
public static T Value<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static T Value<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ViewportSize<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.ViewportSizeProperty, binding);
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewportSize<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.ViewportSizeProperty, func, onChanged, expression);
public static T ViewportSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static T ViewportSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Thumb<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.ThumbProperty, binding);
public static T Thumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.ThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Thumb<T>(this T control, Func<Thumb> func, Action<Thumb>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.ThumbProperty, func, onChanged, expression);
public static T Thumb<T>(this T control, Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = value, bindingMode, converter, bindingSource);
public static T Thumb<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IncreaseButton<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.IncreaseButtonProperty, binding);
public static T IncreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IncreaseButton<T>(this T control, Func<Button> func, Action<Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.IncreaseButtonProperty, func, onChanged, expression);
public static T IncreaseButton<T>(this T control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value, bindingMode, converter, bindingSource);
public static T IncreaseButton<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DecreaseButton<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.DecreaseButtonProperty, binding);
public static T DecreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DecreaseButton<T>(this T control, Func<Button> func, Action<Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.DecreaseButtonProperty, func, onChanged, expression);
public static T DecreaseButton<T>(this T control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value, bindingMode, converter, bindingSource);
public static T DecreaseButton<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.IsDirectionReversedProperty, binding);
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDirectionReversed<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.IsDirectionReversedProperty, func, onChanged, expression);
public static T IsDirectionReversed<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IgnoreThumbDrag<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.IgnoreThumbDragProperty, binding);
public static T IgnoreThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IgnoreThumbDrag<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.IgnoreThumbDragProperty, func, onChanged, expression);
public static T IgnoreThumbDrag<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = value, bindingMode, converter, bindingSource);
public static T IgnoreThumbDrag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DeferThumbDrag<T>(this T control, IBinding binding) where T : Track
   => control._set(Track.DeferThumbDragProperty, binding);
public static T DeferThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Track
   => control._set(Track.DeferThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DeferThumbDrag<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Track
   => control._set(Track.DeferThumbDragProperty, func, onChanged, expression);
public static T DeferThumbDrag<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = value, bindingMode, converter, bindingSource);
public static T DeferThumbDrag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Track
=> control._setEx(Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

