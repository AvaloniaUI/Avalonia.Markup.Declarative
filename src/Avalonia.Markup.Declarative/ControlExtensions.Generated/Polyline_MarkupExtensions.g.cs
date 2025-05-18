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
public static partial class Polyline_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*BindFromExpressionSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Points<T>(this T control,System.Collections.Generic.IList<Avalonia.Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Polyline 
=> control._setEx(Avalonia.Controls.Shapes.Polyline.PointsProperty, ps, () => control.Points = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Points<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Points<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Shapes.Polyline 
=> control._setEx(Avalonia.Controls.Shapes.Polyline.PointsProperty, ps, () => control.Points = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Points

/*ValueStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);



}
