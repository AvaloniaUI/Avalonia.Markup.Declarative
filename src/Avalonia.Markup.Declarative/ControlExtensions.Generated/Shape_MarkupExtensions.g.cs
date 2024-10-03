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
public static partial class Shape_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*BindFromExpressionSetterGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Fill<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Fill<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Fill<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Stretch

/*BindFromExpressionSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Stretch<T>(this T control,Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Stretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Stroke

/*BindFromExpressionSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Stroke<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Stroke<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeDashArray

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeDashArray<T>(this T control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeDashArray<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeDashOffset

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeDashOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeDashOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeThickness

/*BindFromExpressionSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeThickness<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeLineCap

/*BindFromExpressionSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeLineCap<T>(this T control,Avalonia.Media.PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeLineCap<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeJoin

/*BindFromExpressionSetterGenerator*/
public static T StrokeJoin<T>(this T control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeJoin<T>(this T control,Avalonia.Media.PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeJoin<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeJoin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeJoin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape 
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);


 // Stroke

/*ValueStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);


 // StrokeDashArray

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);


 // StrokeDashOffset

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);


 // StrokeThickness

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);


 // StrokeLineCap

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);


 // StrokeJoin

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);



}
