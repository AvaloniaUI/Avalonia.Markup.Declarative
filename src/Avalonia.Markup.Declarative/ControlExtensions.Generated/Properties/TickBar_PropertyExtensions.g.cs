#nullable enable
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TickBarExtensions
{
public static TickBar Fill(this TickBar control, IBinding binding)
   => control._set(TickBar.FillProperty, binding);
public static TickBar Fill(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Fill(this TickBar control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.FillProperty, func, onChanged, expression);
public static TickBar Fill(this TickBar control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static TickBar Fill<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Minimum(this TickBar control, IBinding binding)
   => control._set(TickBar.MinimumProperty, binding);
public static TickBar Minimum(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Minimum(this TickBar control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.MinimumProperty, func, onChanged, expression);
public static TickBar Minimum(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static TickBar Minimum<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Maximum(this TickBar control, IBinding binding)
   => control._set(TickBar.MaximumProperty, binding);
public static TickBar Maximum(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Maximum(this TickBar control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.MaximumProperty, func, onChanged, expression);
public static TickBar Maximum(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static TickBar Maximum<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar TickFrequency(this TickBar control, IBinding binding)
   => control._set(TickBar.TickFrequencyProperty, binding);
public static TickBar TickFrequency(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar TickFrequency(this TickBar control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.TickFrequencyProperty, func, onChanged, expression);
public static TickBar TickFrequency(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static TickBar TickFrequency<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Orientation(this TickBar control, IBinding binding)
   => control._set(TickBar.OrientationProperty, binding);
public static TickBar Orientation(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Orientation(this TickBar control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.OrientationProperty, func, onChanged, expression);
public static TickBar Orientation(this TickBar control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static TickBar Orientation<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Ticks(this TickBar control, IBinding binding)
   => control._set(TickBar.TicksProperty, binding);
public static TickBar Ticks(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Ticks(this TickBar control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.TicksProperty, func, onChanged, expression);
public static TickBar Ticks(this TickBar control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static TickBar Ticks<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar IsDirectionReversed(this TickBar control, IBinding binding)
   => control._set(TickBar.IsDirectionReversedProperty, binding);
public static TickBar IsDirectionReversed(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar IsDirectionReversed(this TickBar control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.IsDirectionReversedProperty, func, onChanged, expression);
public static TickBar IsDirectionReversed(this TickBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static TickBar IsDirectionReversed<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Placement(this TickBar control, IBinding binding)
   => control._set(TickBar.PlacementProperty, binding);
public static TickBar Placement(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar Placement(this TickBar control, Func<TickBarPlacement> func, Action<TickBarPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.PlacementProperty, func, onChanged, expression);
public static TickBar Placement(this TickBar control, TickBarPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static TickBar Placement<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, TickBarPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar ReservedSpace(this TickBar control, IBinding binding)
   => control._set(TickBar.ReservedSpaceProperty, binding);
public static TickBar ReservedSpace(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TickBar.ReservedSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TickBar ReservedSpace(this TickBar control, Func<Rect> func, Action<Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.ReservedSpaceProperty, func, onChanged, expression);
public static TickBar ReservedSpace(this TickBar control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = value, bindingMode, converter, bindingSource);
public static TickBar ReservedSpace<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TickBar ReservedSpace(this TickBar control, Double x = default, Double y = default, Double width = default, Double height = default)
   => control._set(() => control.ReservedSpace = new Rect(x, y, width, height));
public static TickBar ReservedSpace(this TickBar control, Size size = default)
   => control._set(() => control.ReservedSpace = new Rect(size));
public static TickBar ReservedSpace(this TickBar control, Point position = default, Size size = default)
   => control._set(() => control.ReservedSpace = new Rect(position, size));
public static TickBar ReservedSpace(this TickBar control, Point topLeft = default, Point bottomRight = default)
   => control._set(() => control.ReservedSpace = new Rect(topLeft, bottomRight));
}

