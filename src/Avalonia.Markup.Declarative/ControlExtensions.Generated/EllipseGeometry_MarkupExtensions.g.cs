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
public static partial class EllipseGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Rect

/*BindFromExpressionSetterGenerator*/
public static T Rect<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Rect<T>(this T control,Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Rect<T>(this T control, System.Double x = default, System.Double y = default, System.Double width = default, System.Double height = default) where T : Avalonia.Media.EllipseGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static T Rect<T>(this T control, Avalonia.Size size = default) where T : Avalonia.Media.EllipseGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static T Rect<T>(this T control, Avalonia.Point position = default, Avalonia.Size size = default) where T : Avalonia.Media.EllipseGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static T Rect<T>(this T control, Avalonia.Point topLeft = default, Avalonia.Point bottomRight = default) where T : Avalonia.Media.EllipseGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static T Rect<T>(this T control, IBinding binding) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Rect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Rect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RadiusX

/*BindFromExpressionSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusXProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RadiusX<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RadiusX<T>(this T control, IBinding binding) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RadiusX<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RadiusY

/*BindFromExpressionSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusYProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RadiusY<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RadiusY<T>(this T control, IBinding binding) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RadiusY<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Center

/*BindFromExpressionSetterGenerator*/
public static T Center<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.CenterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Center<T>(this T control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Center<T>(this T control, IBinding binding) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.CenterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Center<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.EllipseGeometry 
   => control._set(Avalonia.Media.EllipseGeometry.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Center<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.EllipseGeometry 
=> control._setEx(Avalonia.Media.EllipseGeometry.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
