#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WrapPanel = Avalonia.Controls.WrapPanel;

namespace Avalonia.Markup.Declarative;
public static partial class WrapPanelExtensions
{
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);
public static T ItemWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, func, onChanged, expression);
public static T ItemWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value, bindingMode, converter, bindingSource);
public static T ItemWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, func, onChanged, expression);
public static T ItemHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static T ItemHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

