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
public static partial class Rectangle_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*BindFromExpressionSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RadiusX<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, ps, () => control.RadiusX = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RadiusX<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RadiusX<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RadiusY

/*BindFromExpressionSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RadiusY<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, ps, () => control.RadiusY = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RadiusY<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RadiusY<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // RadiusX

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);


 // RadiusY

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);



}
