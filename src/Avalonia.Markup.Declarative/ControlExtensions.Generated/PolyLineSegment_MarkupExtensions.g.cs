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
public static partial class PolyLineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control,System.Collections.Generic.IList<Avalonia.Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.PolyLineSegment.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, IBinding binding)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.PolyLineSegment Points<TValue>(this Avalonia.Media.PolyLineSegment control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.PolyLineSegment.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
