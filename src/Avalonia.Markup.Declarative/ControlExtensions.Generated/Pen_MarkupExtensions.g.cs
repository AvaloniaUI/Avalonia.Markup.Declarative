#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Pen_MarkupExtensions
{
//================= Properties ======================//
 // Brush

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.BrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.BrushProperty, ps, () => control.Brush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.BrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.BrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen Brush<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.BrushProperty, ps, () => control.Brush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Thickness

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.ThicknessProperty, ps, () => control.Thickness = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen Thickness<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.ThicknessProperty, ps, () => control.Thickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DashStyle

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, Func<Avalonia.Media.IDashStyle> func, Action<Avalonia.Media.IDashStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control,Avalonia.Media.IDashStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.DashStyleProperty, ps, () => control.DashStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen DashStyle<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IDashStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.DashStyleProperty, ps, () => control.DashStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineCap

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.LineCapProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control,Avalonia.Media.PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.LineCapProperty, ps, () => control.LineCap = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.LineCapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.LineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen LineCap<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.LineCapProperty, ps, () => control.LineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineJoin

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control,Avalonia.Media.PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.LineJoinProperty, ps, () => control.LineJoin = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen LineJoin<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.LineJoinProperty, ps, () => control.LineJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MiterLimit

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.MiterLimitProperty, ps, () => control.MiterLimit = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, IBinding binding)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.Pen MiterLimit<TValue>(this Avalonia.Media.Pen control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.Pen.MiterLimitProperty, ps, () => control.MiterLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
