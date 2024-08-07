#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DropShadowEffectExtensions
{
public static DropShadowEffect OffsetX(this DropShadowEffect control, IBinding binding)
   => control._set(DropShadowEffect.OffsetXProperty, binding);
public static DropShadowEffect OffsetX(this DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowEffect.OffsetXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowEffect OffsetX(this DropShadowEffect control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffect.OffsetXProperty, func, onChanged, expression);
public static DropShadowEffect OffsetX(this DropShadowEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = value, bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetX<TValue>(this DropShadowEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetY(this DropShadowEffect control, IBinding binding)
   => control._set(DropShadowEffect.OffsetYProperty, binding);
public static DropShadowEffect OffsetY(this DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowEffect.OffsetYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowEffect OffsetY(this DropShadowEffect control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffect.OffsetYProperty, func, onChanged, expression);
public static DropShadowEffect OffsetY(this DropShadowEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = value, bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetY<TValue>(this DropShadowEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

