#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using RotateTransform = Avalonia.Media.RotateTransform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RotateTransformExtensions
{
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, IBinding binding)
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, binding);
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, func, onChanged, expression);
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RotateTransform Angle<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, IBinding binding)
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, binding);
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, func, onChanged, expression);
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.CenterXProperty, ps, () => control.CenterX = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RotateTransform CenterX<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, IBinding binding)
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, binding);
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, func, onChanged, expression);
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.CenterYProperty, ps, () => control.CenterY = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RotateTransform CenterY<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RotateTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

