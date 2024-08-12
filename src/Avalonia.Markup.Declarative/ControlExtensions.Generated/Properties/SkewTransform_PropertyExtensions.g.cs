#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SkewTransformExtensions
{
public static SkewTransform AngleX(this SkewTransform control, IBinding binding)
   => control._set(SkewTransform.AngleXProperty, binding);
public static SkewTransform AngleX(this SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SkewTransform.AngleXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SkewTransform AngleX(this SkewTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SkewTransform.AngleXProperty, func, onChanged, expression);
public static SkewTransform AngleX(this SkewTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);
public static SkewTransform AngleX<TValue>(this SkewTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SkewTransform AngleY(this SkewTransform control, IBinding binding)
   => control._set(SkewTransform.AngleYProperty, binding);
public static SkewTransform AngleY(this SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SkewTransform.AngleYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SkewTransform AngleY(this SkewTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SkewTransform.AngleYProperty, func, onChanged, expression);
public static SkewTransform AngleY(this SkewTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);
public static SkewTransform AngleY<TValue>(this SkewTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

