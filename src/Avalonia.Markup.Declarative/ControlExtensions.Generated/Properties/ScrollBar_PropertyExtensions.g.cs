#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollBarExtensions
{
public static ScrollBar ViewportSize(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.ViewportSizeProperty, binding);
public static ScrollBar ViewportSize(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar ViewportSize(this ScrollBar control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.ViewportSizeProperty, func, onChanged, expression);
public static ScrollBar ViewportSize(this ScrollBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static ScrollBar ViewportSize<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar Visibility(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.VisibilityProperty, binding);
public static ScrollBar Visibility(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.VisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar Visibility(this ScrollBar control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.VisibilityProperty, func, onChanged, expression);
public static ScrollBar Visibility(this ScrollBar control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = value, bindingMode, converter, bindingSource);
public static ScrollBar Visibility<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar Orientation(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.OrientationProperty, binding);
public static ScrollBar Orientation(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar Orientation(this ScrollBar control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.OrientationProperty, func, onChanged, expression);
public static ScrollBar Orientation(this ScrollBar control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static ScrollBar Orientation<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar AllowAutoHide(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.AllowAutoHideProperty, binding);
public static ScrollBar AllowAutoHide(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar AllowAutoHide(this ScrollBar control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.AllowAutoHideProperty, func, onChanged, expression);
public static ScrollBar AllowAutoHide(this ScrollBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static ScrollBar AllowAutoHide<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar HideDelay(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.HideDelayProperty, binding);
public static ScrollBar HideDelay(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.HideDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar HideDelay(this ScrollBar control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.HideDelayProperty, func, onChanged, expression);
public static ScrollBar HideDelay(this ScrollBar control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value, bindingMode, converter, bindingSource);
public static ScrollBar HideDelay<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar ShowDelay(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.ShowDelayProperty, binding);
public static ScrollBar ShowDelay(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollBar.ShowDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollBar ShowDelay(this ScrollBar control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.ShowDelayProperty, func, onChanged, expression);
public static ScrollBar ShowDelay(this ScrollBar control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value, bindingMode, converter, bindingSource);
public static ScrollBar ShowDelay<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

