#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RotateTransformExtensions
{
public static RotateTransform Angle(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.AngleProperty, binding);
public static RotateTransform Angle(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RotateTransform.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RotateTransform Angle(this RotateTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.AngleProperty, func, onChanged, expression);
public static RotateTransform Angle(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static RotateTransform Angle<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RotateTransform CenterX(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.CenterXProperty, binding);
public static RotateTransform CenterX(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RotateTransform.CenterXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RotateTransform CenterX(this RotateTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.CenterXProperty, func, onChanged, expression);
public static RotateTransform CenterX(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterXProperty, ps, () => control.CenterX = value, bindingMode, converter, bindingSource);
public static RotateTransform CenterX<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RotateTransform CenterY(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.CenterYProperty, binding);
public static RotateTransform CenterY(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RotateTransform.CenterYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RotateTransform CenterY(this RotateTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.CenterYProperty, func, onChanged, expression);
public static RotateTransform CenterY(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterYProperty, ps, () => control.CenterY = value, bindingMode, converter, bindingSource);
public static RotateTransform CenterY<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

