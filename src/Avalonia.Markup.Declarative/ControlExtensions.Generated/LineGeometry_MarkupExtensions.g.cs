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
public static partial class LineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*BindFromExpressionSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StartPoint<T>(this T control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.LineGeometry 
=> control._setEx(Avalonia.Media.LineGeometry.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StartPoint<T>(this T control, IBinding binding) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StartPoint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.LineGeometry 
=> control._setEx(Avalonia.Media.LineGeometry.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // EndPoint

/*BindFromExpressionSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T EndPoint<T>(this T control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.LineGeometry 
=> control._setEx(Avalonia.Media.LineGeometry.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EndPoint<T>(this T control, IBinding binding) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T EndPoint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.LineGeometry 
=> control._setEx(Avalonia.Media.LineGeometry.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
