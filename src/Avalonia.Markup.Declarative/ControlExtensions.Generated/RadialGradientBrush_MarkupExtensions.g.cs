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
public static partial class RadialGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control,Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, System.Double x = default, System.Double y = default, Avalonia.RelativeUnit unit = default)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default, Avalonia.RelativeUnit unit = default)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // GradientOrigin

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control,Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, System.Double x = default, System.Double y = default, Avalonia.RelativeUnit unit = default)  
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default, Avalonia.RelativeUnit unit = default)  
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RadiusX

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control,Avalonia.RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RadiusY

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control,Avalonia.RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) => control._setEx(Avalonia.Media.RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
