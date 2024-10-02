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
public static partial class ArcSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsLargeArc

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc<TValue>(this Avalonia.Media.ArcSegment control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Point

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ArcSegment Point<TValue>(this Avalonia.Media.ArcSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RotationAngle

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle<TValue>(this Avalonia.Media.ArcSegment control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Size

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Func<Avalonia.Size> func, Action<Avalonia.Size>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control,Avalonia.Size value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.SizeProperty, ps, () => control.Size = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Double width = default, System.Double height = default)  
   => control._set(() => control.Size = new Avalonia.Size(width, height));
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Numerics.Vector2 vector2 = default)  
   => control._set(() => control.Size = new Avalonia.Size(vector2));

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ArcSegment Size<TValue>(this Avalonia.Media.ArcSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Size> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.SizeProperty, ps, () => control.Size = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SweepDirection

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Func<Avalonia.Media.SweepDirection> func, Action<Avalonia.Media.SweepDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control,Avalonia.Media.SweepDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, IBinding binding)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection<TValue>(this Avalonia.Media.ArcSegment control, TValue value, FuncValueConverter<TValue, Avalonia.Media.SweepDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
