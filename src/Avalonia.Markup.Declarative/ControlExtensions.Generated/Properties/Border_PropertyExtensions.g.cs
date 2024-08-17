#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Border = Avalonia.Controls.Border;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class BorderExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, binding);
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, func, onChanged, expression);
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);
public static T BackgroundSizing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, binding);
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, func, onChanged, expression);
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static T BorderBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, binding);
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, func, onChanged, expression);
public static T BorderThickness<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static T BorderThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BorderThickness<T>(this T control, Double uniformLength = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal = default, Double vertical = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, binding);
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, func, onChanged, expression);
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T CornerRadius<T>(this T control, Double uniformRadius = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top = default, Double bottom = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T BoxShadow<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, binding);
public static T BoxShadow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, func, onChanged, expression);
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static T BoxShadow<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BoxShadow<T>(this T control, BoxShadow shadow = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, BoxShadow first = default, BoxShadow[] rest = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));
}

