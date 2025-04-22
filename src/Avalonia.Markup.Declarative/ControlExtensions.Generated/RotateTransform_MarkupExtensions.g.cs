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
public static partial class RotateTransform_MarkupExtensions
{
//================= Properties ======================//
 // Angle

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.AngleProperty, ps, () => control.Angle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform Angle<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.AngleProperty, ps, () => control.Angle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CenterX

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.CenterXProperty, ps, () => control.CenterX = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform CenterX<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CenterY

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.CenterYProperty, ps, () => control.CenterY = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, IBinding binding)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.RotateTransform CenterY<TValue>(this Avalonia.Media.RotateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.RotateTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
