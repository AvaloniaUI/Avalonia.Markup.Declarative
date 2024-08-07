#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class BorderExtensions
{
public static Border Background(this Border control, IBinding binding)
   => control._set(Border.BackgroundProperty, binding);
public static Border Background(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border Background(this Border control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BackgroundProperty, func, onChanged, expression);
public static Border Background(this Border control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static Border Background<TValue>(this Border control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Border BackgroundSizing(this Border control, IBinding binding)
   => control._set(Border.BackgroundSizingProperty, binding);
public static Border BackgroundSizing(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border BackgroundSizing(this Border control, Func<BackgroundSizing> func, Action<BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BackgroundSizingProperty, func, onChanged, expression);
public static Border BackgroundSizing(this Border control, BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);
public static Border BackgroundSizing<TValue>(this Border control, TValue value, FuncValueConverter<TValue, BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Border BorderBrush(this Border control, IBinding binding)
   => control._set(Border.BorderBrushProperty, binding);
public static Border BorderBrush(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border BorderBrush(this Border control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BorderBrushProperty, func, onChanged, expression);
public static Border BorderBrush(this Border control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static Border BorderBrush<TValue>(this Border control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Border BorderThickness(this Border control, IBinding binding)
   => control._set(Border.BorderThicknessProperty, binding);
public static Border BorderThickness(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border BorderThickness(this Border control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BorderThicknessProperty, func, onChanged, expression);
public static Border BorderThickness(this Border control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static Border BorderThickness<TValue>(this Border control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border BorderThickness(this Border control, Double uniformLength = default)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static Border BorderThickness(this Border control, Double horizontal = default, Double vertical = default)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static Border BorderThickness(this Border control, Double left = default, Double top = default, Double right = default, Double bottom = default)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static Border CornerRadius(this Border control, IBinding binding)
   => control._set(Border.CornerRadiusProperty, binding);
public static Border CornerRadius(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border CornerRadius(this Border control, Func<CornerRadius> func, Action<CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.CornerRadiusProperty, func, onChanged, expression);
public static Border CornerRadius(this Border control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static Border CornerRadius<TValue>(this Border control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border CornerRadius(this Border control, Double uniformRadius = default)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static Border CornerRadius(this Border control, Double top = default, Double bottom = default)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static Border CornerRadius(this Border control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Border BoxShadow(this Border control, IBinding binding)
   => control._set(Border.BoxShadowProperty, binding);
public static Border BoxShadow(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Border.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Border BoxShadow(this Border control, Func<BoxShadows> func, Action<BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BoxShadowProperty, func, onChanged, expression);
public static Border BoxShadow(this Border control, BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static Border BoxShadow<TValue>(this Border control, TValue value, FuncValueConverter<TValue, BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border BoxShadow(this Border control, BoxShadow shadow = default)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static Border BoxShadow(this Border control, BoxShadow first = default, BoxShadow[] rest = default)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
}

