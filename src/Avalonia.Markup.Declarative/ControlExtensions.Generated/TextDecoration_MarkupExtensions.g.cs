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
public static partial class TextDecoration_MarkupExtensions
{
//================= Properties ======================//
 // Location

/*BindFromExpressionSetterGenerator*/
public static T Location<T>(this T control, Func<Avalonia.Media.TextDecorationLocation> func, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Location<T>(this T control,Avalonia.Media.TextDecorationLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.LocationProperty, ps, () => control.Location = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Location<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Location<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Location<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.LocationProperty, ps, () => control.Location = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Stroke

/*BindFromExpressionSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Stroke<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Stroke<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeThicknessUnit

/*BindFromExpressionSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control,Avalonia.Media.TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeThicknessUnit<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeDashArray

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeDashArray<T>(this T control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeDashArray<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeDashOffset

/*BindFromExpressionSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeDashOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeDashOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeThickness

/*BindFromExpressionSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeThickness<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeLineCap

/*BindFromExpressionSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeLineCap<T>(this T control,Avalonia.Media.PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeLineCap<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeOffset

/*BindFromExpressionSetterGenerator*/
public static T StrokeOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StrokeOffsetUnit

/*BindFromExpressionSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control,Avalonia.Media.TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StrokeOffsetUnit<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration 
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
