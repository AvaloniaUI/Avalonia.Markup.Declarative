#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Rotate3DTransformExtensions
{
public static Rotate3DTransform AngleX(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleXProperty, binding);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.AngleXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleXProperty, func, onChanged, expression);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleX<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleYProperty, binding);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.AngleYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleYProperty, func, onChanged, expression);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleY<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleZProperty, binding);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.AngleZProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleZProperty, func, onChanged, expression);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleZProperty, ps, () => control.AngleZ = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleZ<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleZProperty, ps, () => control.AngleZ = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterXProperty, binding);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.CenterXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterXProperty, func, onChanged, expression);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterXProperty, ps, () => control.CenterX = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterX<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterYProperty, binding);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.CenterYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterYProperty, func, onChanged, expression);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterYProperty, ps, () => control.CenterY = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterY<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterZProperty, binding);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.CenterZProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterZProperty, func, onChanged, expression);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterZProperty, ps, () => control.CenterZ = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterZ<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterZProperty, ps, () => control.CenterZ = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform Depth(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.DepthProperty, binding);
public static Rotate3DTransform Depth(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rotate3DTransform.DepthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rotate3DTransform Depth(this Rotate3DTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.DepthProperty, func, onChanged, expression);
public static Rotate3DTransform Depth(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.DepthProperty, ps, () => control.Depth = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform Depth<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.DepthProperty, ps, () => control.Depth = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

