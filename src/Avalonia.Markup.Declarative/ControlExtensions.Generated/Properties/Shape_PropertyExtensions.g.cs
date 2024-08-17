#nullable enable
using Avalonia.Collections;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Shape = Avalonia.Controls.Shapes.Shape;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ShapeExtensions
{
public static T Fill<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, binding);
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty, func, onChanged, expression);
public static T Fill<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static T Fill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty, func, onChanged, expression);
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static T Stretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty, func, onChanged, expression);
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static T Stroke<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, func, onChanged, expression);
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static T StrokeDashArray<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, func, onChanged, expression);
public static T StrokeDashOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, func, onChanged, expression);
public static T StrokeThickness<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static T StrokeThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, func, onChanged, expression);
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static T StrokeLineCap<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeJoin<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);
public static T StrokeJoin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeJoin<T>(this T control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Shape
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, func, onChanged, expression);
public static T StrokeJoin<T>(this T control, Avalonia.Media.PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = value, bindingMode, converter, bindingSource);
public static T StrokeJoin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Shape
=> control._setEx(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

