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
using TickBar = Avalonia.Controls.TickBar;

namespace Avalonia.Markup.Declarative;
public static partial class TickBarExtensions
{
public static T Fill<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.FillProperty, binding);
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.FillProperty, func, onChanged, expression);
public static T Fill<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static T Fill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, binding);
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, func, onChanged, expression);
public static T Minimum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static T Minimum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, binding);
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, func, onChanged, expression);
public static T Maximum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static T Maximum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TickFrequency<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, func, onChanged, expression);
public static T TickFrequency<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static T TickFrequency<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Ticks<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TicksProperty, binding);
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.TicksProperty, func, onChanged, expression);
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static T Ticks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, func, onChanged, expression);
public static T IsDirectionReversed<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static T IsDirectionReversed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Placement<T>(this T control, Func<Avalonia.Controls.TickBarPlacement> func, Action<Avalonia.Controls.TickBarPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, func, onChanged, expression);
public static T Placement<T>(this T control, Avalonia.Controls.TickBarPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.TickBarPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ReservedSpace<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);
public static T ReservedSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ReservedSpace<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, func, onChanged, expression);
public static T ReservedSpace<T>(this T control, Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = value, bindingMode, converter, bindingSource);
public static T ReservedSpace<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar
=> control._setEx(Avalonia.Controls.TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T ReservedSpace<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default) where T : Avalonia.Controls.TickBar
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(x, y, width, height));
public static T ReservedSpace<T>(this T control, Size size = default) where T : Avalonia.Controls.TickBar
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(size));
public static T ReservedSpace<T>(this T control, Point position = default, Size size = default) where T : Avalonia.Controls.TickBar
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(position, size));
public static T ReservedSpace<T>(this T control, Point topLeft = default, Point bottomRight = default) where T : Avalonia.Controls.TickBar
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(topLeft, bottomRight));
}

