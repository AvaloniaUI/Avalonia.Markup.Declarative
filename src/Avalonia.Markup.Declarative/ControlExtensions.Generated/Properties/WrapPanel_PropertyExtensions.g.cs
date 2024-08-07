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
public static WrapPanel Orientation(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.OrientationProperty, binding);
public static WrapPanel Orientation(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WrapPanel Orientation(this WrapPanel control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.OrientationProperty, func, onChanged, expression);
public static WrapPanel Orientation(this WrapPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static WrapPanel Orientation<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WrapPanel ItemWidth(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.ItemWidthProperty, binding);
public static WrapPanel ItemWidth(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WrapPanel ItemWidth(this WrapPanel control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.ItemWidthProperty, func, onChanged, expression);
public static WrapPanel ItemWidth(this WrapPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value, bindingMode, converter, bindingSource);
public static WrapPanel ItemWidth<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WrapPanel ItemHeight(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.ItemHeightProperty, binding);
public static WrapPanel ItemHeight(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WrapPanel ItemHeight(this WrapPanel control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.ItemHeightProperty, func, onChanged, expression);
public static WrapPanel ItemHeight(this WrapPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static WrapPanel ItemHeight<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

