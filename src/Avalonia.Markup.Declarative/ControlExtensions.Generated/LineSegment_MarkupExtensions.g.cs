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
public static partial class LineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.LineSegment.PointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.LineSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, IBinding binding)  
   => control._set(Avalonia.Media.LineSegment.PointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.LineSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.LineSegment Point<TValue>(this Avalonia.Media.LineSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.LineSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
