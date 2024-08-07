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
public static Track Minimum(this Track control, IBinding binding)
   => control._set(Track.MinimumProperty, binding);
public static Track Minimum(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track Minimum(this Track control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.MinimumProperty, func, onChanged, expression);
public static Track Minimum(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static Track Minimum<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Maximum(this Track control, IBinding binding)
   => control._set(Track.MaximumProperty, binding);
public static Track Maximum(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track Maximum(this Track control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.MaximumProperty, func, onChanged, expression);
public static Track Maximum(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static Track Maximum<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Value(this Track control, IBinding binding)
   => control._set(Track.ValueProperty, binding);
public static Track Value(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track Value(this Track control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ValueProperty, func, onChanged, expression);
public static Track Value(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static Track Value<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track ViewportSize(this Track control, IBinding binding)
   => control._set(Track.ViewportSizeProperty, binding);
public static Track ViewportSize(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track ViewportSize(this Track control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ViewportSizeProperty, func, onChanged, expression);
public static Track ViewportSize(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static Track ViewportSize<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Orientation(this Track control, IBinding binding)
   => control._set(Track.OrientationProperty, binding);
public static Track Orientation(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track Orientation(this Track control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.OrientationProperty, func, onChanged, expression);
public static Track Orientation(this Track control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static Track Orientation<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Thumb(this Track control, IBinding binding)
   => control._set(Track.ThumbProperty, binding);
public static Track Thumb(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.ThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track Thumb(this Track control, Func<Thumb> func, Action<Thumb>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ThumbProperty, func, onChanged, expression);
public static Track Thumb(this Track control, Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = value, bindingMode, converter, bindingSource);
public static Track Thumb<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IncreaseButton(this Track control, IBinding binding)
   => control._set(Track.IncreaseButtonProperty, binding);
public static Track IncreaseButton(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track IncreaseButton(this Track control, Func<Button> func, Action<Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IncreaseButtonProperty, func, onChanged, expression);
public static Track IncreaseButton(this Track control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value, bindingMode, converter, bindingSource);
public static Track IncreaseButton<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track DecreaseButton(this Track control, IBinding binding)
   => control._set(Track.DecreaseButtonProperty, binding);
public static Track DecreaseButton(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track DecreaseButton(this Track control, Func<Button> func, Action<Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.DecreaseButtonProperty, func, onChanged, expression);
public static Track DecreaseButton(this Track control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value, bindingMode, converter, bindingSource);
public static Track DecreaseButton<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IsDirectionReversed(this Track control, IBinding binding)
   => control._set(Track.IsDirectionReversedProperty, binding);
public static Track IsDirectionReversed(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track IsDirectionReversed(this Track control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IsDirectionReversedProperty, func, onChanged, expression);
public static Track IsDirectionReversed(this Track control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static Track IsDirectionReversed<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IgnoreThumbDrag(this Track control, IBinding binding)
   => control._set(Track.IgnoreThumbDragProperty, binding);
public static Track IgnoreThumbDrag(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track IgnoreThumbDrag(this Track control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IgnoreThumbDragProperty, func, onChanged, expression);
public static Track IgnoreThumbDrag(this Track control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = value, bindingMode, converter, bindingSource);
public static Track IgnoreThumbDrag<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track DeferThumbDrag(this Track control, IBinding binding)
   => control._set(Track.DeferThumbDragProperty, binding);
public static Track DeferThumbDrag(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Track.DeferThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Track DeferThumbDrag(this Track control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.DeferThumbDragProperty, func, onChanged, expression);
public static Track DeferThumbDrag(this Track control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = value, bindingMode, converter, bindingSource);
public static Track DeferThumbDrag<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

