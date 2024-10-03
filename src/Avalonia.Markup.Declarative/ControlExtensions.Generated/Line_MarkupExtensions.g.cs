#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Line_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*BindFromExpressionSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StartPoint<T>(this T control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line 
=> control._setEx(Avalonia.Controls.Shapes.Line.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StartPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StartPoint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line 
=> control._setEx(Avalonia.Controls.Shapes.Line.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // EndPoint

/*BindFromExpressionSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T EndPoint<T>(this T control,Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line 
=> control._setEx(Avalonia.Controls.Shapes.Line.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EndPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T EndPoint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line 
=> control._setEx(Avalonia.Controls.Shapes.Line.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // StartPoint

/*ValueStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);


 // EndPoint

/*ValueStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);



}
