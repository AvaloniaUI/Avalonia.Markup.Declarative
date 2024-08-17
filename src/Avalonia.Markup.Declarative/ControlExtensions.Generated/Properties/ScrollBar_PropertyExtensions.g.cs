#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using ScrollBar = Avalonia.Controls.Primitives.ScrollBar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollBarExtensions
{
public static T ViewportSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, func, onChanged, expression);
public static T ViewportSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static T ViewportSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Visibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);
public static T Visibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Visibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, func, onChanged, expression);
public static T Visibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, ps, () => control.Visibility = value, bindingMode, converter, bindingSource);
public static T Visibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, ps, () => control.Visibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, func, onChanged, expression);
public static T AllowAutoHide<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static T AllowAutoHide<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HideDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);
public static T HideDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HideDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, func, onChanged, expression);
public static T HideDelay<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value, bindingMode, converter, bindingSource);
public static T HideDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, ps, () => control.HideDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);
public static T ShowDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, func, onChanged, expression);
public static T ShowDelay<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value, bindingMode, converter, bindingSource);
public static T ShowDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

