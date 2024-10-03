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
public static partial class BezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.BezierSegment Point1<TValue>(this Avalonia.Media.BezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Point2

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.BezierSegment Point2<TValue>(this Avalonia.Media.BezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Point3

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point3Property, ps, () => control.Point3 = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.BezierSegment Point3<TValue>(this Avalonia.Media.BezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.BezierSegment.Point3Property, ps, () => control.Point3 = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
