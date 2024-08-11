#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WrapPanelExtensions
{
public static T Orientation<T>(this T control, IBinding binding) where T : WrapPanel
   => control._set(WrapPanel.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : WrapPanel
   => control._set(WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : WrapPanel
   => control._set(WrapPanel.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemWidth<T>(this T control, IBinding binding) where T : WrapPanel
   => control._set(WrapPanel.ItemWidthProperty, binding);
public static T ItemWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : WrapPanel
   => control._set(WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemWidth<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : WrapPanel
   => control._set(WrapPanel.ItemWidthProperty, func, onChanged, expression);
public static T ItemWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value, bindingMode, converter, bindingSource);
public static T ItemWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemHeight<T>(this T control, IBinding binding) where T : WrapPanel
   => control._set(WrapPanel.ItemHeightProperty, binding);
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : WrapPanel
   => control._set(WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : WrapPanel
   => control._set(WrapPanel.ItemHeightProperty, func, onChanged, expression);
public static T ItemHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static T ItemHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WrapPanel
=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

