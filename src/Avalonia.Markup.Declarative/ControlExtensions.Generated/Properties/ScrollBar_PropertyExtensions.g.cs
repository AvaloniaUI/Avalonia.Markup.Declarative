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
public static T ViewportSize<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.ViewportSizeProperty, binding);
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewportSize<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.ViewportSizeProperty, func, onChanged, expression);
public static T ViewportSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static T ViewportSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Visibility<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.VisibilityProperty, binding);
public static T Visibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.VisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Visibility<T>(this T control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.VisibilityProperty, func, onChanged, expression);
public static T Visibility<T>(this T control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = value, bindingMode, converter, bindingSource);
public static T Visibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.AllowAutoHideProperty, binding);
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowAutoHide<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.AllowAutoHideProperty, func, onChanged, expression);
public static T AllowAutoHide<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static T AllowAutoHide<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HideDelay<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.HideDelayProperty, binding);
public static T HideDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.HideDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HideDelay<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.HideDelayProperty, func, onChanged, expression);
public static T HideDelay<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value, bindingMode, converter, bindingSource);
public static T HideDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowDelay<T>(this T control, IBinding binding) where T : ScrollBar
   => control._set(ScrollBar.ShowDelayProperty, binding);
public static T ShowDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollBar
   => control._set(ScrollBar.ShowDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowDelay<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollBar
   => control._set(ScrollBar.ShowDelayProperty, func, onChanged, expression);
public static T ShowDelay<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value, bindingMode, converter, bindingSource);
public static T ShowDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollBar
=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

