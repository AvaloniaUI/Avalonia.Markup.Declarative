#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DropShadowDirectionEffectExtensions
{
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, IBinding binding)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, binding);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, func, onChanged, expression);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = value, bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect ShadowDepth<TValue>(this DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, IBinding binding)
   => control._set(DropShadowDirectionEffect.DirectionProperty, binding);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DropShadowDirectionEffect.DirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowDirectionEffect.DirectionProperty, func, onChanged, expression);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = value, bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect Direction<TValue>(this DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

