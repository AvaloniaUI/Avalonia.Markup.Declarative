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
public static partial class PolylineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*BindFromExpressionSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Points<T>(this T control,System.Collections.Generic.IList<Avalonia.Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PolylineGeometry 
=> control._setEx(Avalonia.Media.PolylineGeometry.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Points<T>(this T control, IBinding binding) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Points<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PolylineGeometry 
=> control._setEx(Avalonia.Media.PolylineGeometry.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsFilled

/*BindFromExpressionSetterGenerator*/
public static T IsFilled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsFilled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PolylineGeometry 
=> control._setEx(Avalonia.Media.PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsFilled<T>(this T control, IBinding binding) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFilled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsFilled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PolylineGeometry 
=> control._setEx(Avalonia.Media.PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
