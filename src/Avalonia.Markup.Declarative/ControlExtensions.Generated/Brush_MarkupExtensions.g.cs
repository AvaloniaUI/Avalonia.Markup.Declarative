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
public static partial class Brush_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*BindFromExpressionSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Opacity<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Opacity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Transform

/*BindFromExpressionSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Transform<T>(this T control,Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Transform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TransformOrigin

/*BindFromExpressionSetterGenerator*/
public static T TransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TransformOrigin<T>(this T control,Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.TransformOriginProperty, ps, () => control.TransformOrigin = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T TransformOrigin<T>(this T control, System.Double x = default, System.Double y = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.Brush 
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T TransformOrigin<T>(this T control, Avalonia.Point point = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.Brush 
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static T TransformOrigin<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TransformOrigin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.Brush 
=> control._setEx(Avalonia.Media.Brush.TransformOriginProperty, ps, () => control.TransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
