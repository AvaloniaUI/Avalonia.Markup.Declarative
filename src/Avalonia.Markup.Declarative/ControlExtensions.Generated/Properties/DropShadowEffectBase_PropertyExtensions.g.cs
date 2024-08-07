#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DropShadowEffectBaseExtensions
{
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, binding);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, func, onChanged, expression);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase BlurRadius<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.ColorProperty, binding);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowEffectBase.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.ColorProperty, func, onChanged, expression);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase Color<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.OpacityProperty, binding);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowEffectBase.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.OpacityProperty, func, onChanged, expression);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase Opacity<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

