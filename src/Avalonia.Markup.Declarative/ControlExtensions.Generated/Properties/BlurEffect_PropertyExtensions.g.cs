#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class BlurEffectExtensions
{
public static BlurEffect Radius(this BlurEffect control, IBinding binding)
   => control._set(BlurEffect.RadiusProperty, binding);
public static BlurEffect Radius(this BlurEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(BlurEffect.RadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static BlurEffect Radius(this BlurEffect control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BlurEffect.RadiusProperty, func, onChanged, expression);
public static BlurEffect Radius(this BlurEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BlurEffect.RadiusProperty, ps, () => control.Radius = value, bindingMode, converter, bindingSource);
public static BlurEffect Radius<TValue>(this BlurEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BlurEffect.RadiusProperty, ps, () => control.Radius = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

