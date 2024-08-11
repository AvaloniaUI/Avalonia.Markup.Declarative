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
public static T BlurRadius<T>(this T control, IBinding binding) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.BlurRadiusProperty, binding);
public static T BlurRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.BlurRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BlurRadius<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.BlurRadiusProperty, func, onChanged, expression);
public static T BlurRadius<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = value, bindingMode, converter, bindingSource);
public static T BlurRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Color<T>(this T control, IBinding binding) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.ColorProperty, binding);
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Color<T>(this T control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.ColorProperty, func, onChanged, expression);
public static T Color<T>(this T control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static T Color<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Opacity<T>(this T control, IBinding binding) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Opacity<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DropShadowEffectBase
   => control._set(DropShadowEffectBase.OpacityProperty, func, onChanged, expression);
public static T Opacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DropShadowEffectBase
=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

