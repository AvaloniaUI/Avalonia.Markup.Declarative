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
using Track = Avalonia.Controls.Primitives.Track;

namespace Avalonia.Markup.Declarative;
public static partial class TrackExtensions
{
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, func, onChanged, expression);
public static T Minimum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static T Minimum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, func, onChanged, expression);
public static T Maximum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static T Maximum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, binding);
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, func, onChanged, expression);
public static T Value<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static T Value<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ViewportSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, func, onChanged, expression);
public static T ViewportSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static T ViewportSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Thumb<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);
public static T Thumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Thumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb> func, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, func, onChanged, expression);
public static T Thumb<T>(this T control, Avalonia.Controls.Primitives.Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ThumbProperty, ps, () => control.Thumb = value, bindingMode, converter, bindingSource);
public static T Thumb<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.ThumbProperty, ps, () => control.Thumb = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IncreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);
public static T IncreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IncreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, func, onChanged, expression);
public static T IncreaseButton<T>(this T control, Avalonia.Controls.Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value, bindingMode, converter, bindingSource);
public static T IncreaseButton<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DecreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);
public static T DecreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DecreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, func, onChanged, expression);
public static T DecreaseButton<T>(this T control, Avalonia.Controls.Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value, bindingMode, converter, bindingSource);
public static T DecreaseButton<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, func, onChanged, expression);
public static T IsDirectionReversed<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IgnoreThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);
public static T IgnoreThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IgnoreThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, func, onChanged, expression);
public static T IgnoreThumbDrag<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = value, bindingMode, converter, bindingSource);
public static T IgnoreThumbDrag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DeferThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);
public static T DeferThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DeferThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, func, onChanged, expression);
public static T DeferThumbDrag<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = value, bindingMode, converter, bindingSource);
public static T DeferThumbDrag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track
=> control._setEx(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

