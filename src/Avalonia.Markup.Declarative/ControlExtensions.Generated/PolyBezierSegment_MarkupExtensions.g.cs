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
public static partial class PolyBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, Func<Avalonia.Points> func, Action<Avalonia.Points>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control,Avalonia.Points value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.PolyBezierSegment.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, IBinding binding)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points<TValue>(this Avalonia.Media.PolyBezierSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Points> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.PolyBezierSegment.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
