#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class QuadraticBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1Property

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, IBinding binding)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1<TValue>(this Avalonia.Media.QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Point2Property

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, IBinding binding)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2<TValue>(this Avalonia.Media.QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
