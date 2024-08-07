#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PenExtensions
{
public static Pen Brush(this Pen control, IBinding binding)
   => control._set(Pen.BrushProperty, binding);
public static Pen Brush(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.BrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen Brush(this Pen control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.BrushProperty, func, onChanged, expression);
public static Pen Brush(this Pen control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.BrushProperty, ps, () => control.Brush = value, bindingMode, converter, bindingSource);
public static Pen Brush<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.BrushProperty, ps, () => control.Brush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen Thickness(this Pen control, IBinding binding)
   => control._set(Pen.ThicknessProperty, binding);
public static Pen Thickness(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.ThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen Thickness(this Pen control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.ThicknessProperty, func, onChanged, expression);
public static Pen Thickness(this Pen control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.ThicknessProperty, ps, () => control.Thickness = value, bindingMode, converter, bindingSource);
public static Pen Thickness<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.ThicknessProperty, ps, () => control.Thickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen DashStyle(this Pen control, IBinding binding)
   => control._set(Pen.DashStyleProperty, binding);
public static Pen DashStyle(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.DashStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen DashStyle(this Pen control, Func<IDashStyle> func, Action<IDashStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.DashStyleProperty, func, onChanged, expression);
public static Pen DashStyle(this Pen control, IDashStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.DashStyleProperty, ps, () => control.DashStyle = value, bindingMode, converter, bindingSource);
public static Pen DashStyle<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, IDashStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.DashStyleProperty, ps, () => control.DashStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen LineCap(this Pen control, IBinding binding)
   => control._set(Pen.LineCapProperty, binding);
public static Pen LineCap(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.LineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen LineCap(this Pen control, Func<PenLineCap> func, Action<PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.LineCapProperty, func, onChanged, expression);
public static Pen LineCap(this Pen control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineCapProperty, ps, () => control.LineCap = value, bindingMode, converter, bindingSource);
public static Pen LineCap<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineCapProperty, ps, () => control.LineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen LineJoin(this Pen control, IBinding binding)
   => control._set(Pen.LineJoinProperty, binding);
public static Pen LineJoin(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.LineJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen LineJoin(this Pen control, Func<PenLineJoin> func, Action<PenLineJoin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.LineJoinProperty, func, onChanged, expression);
public static Pen LineJoin(this Pen control, PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineJoinProperty, ps, () => control.LineJoin = value, bindingMode, converter, bindingSource);
public static Pen LineJoin<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineJoinProperty, ps, () => control.LineJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen MiterLimit(this Pen control, IBinding binding)
   => control._set(Pen.MiterLimitProperty, binding);
public static Pen MiterLimit(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Pen.MiterLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Pen MiterLimit(this Pen control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.MiterLimitProperty, func, onChanged, expression);
public static Pen MiterLimit(this Pen control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.MiterLimitProperty, ps, () => control.MiterLimit = value, bindingMode, converter, bindingSource);
public static Pen MiterLimit<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.MiterLimitProperty, ps, () => control.MiterLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

