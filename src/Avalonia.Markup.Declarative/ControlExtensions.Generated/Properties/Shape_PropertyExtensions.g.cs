#nullable enable
using Avalonia.Collections;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ShapeExtensions
{
public static Shape Fill(this Shape control, IBinding binding)
   => control._set(Shape.FillProperty, binding);
public static Shape Fill(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape Fill(this Shape control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.FillProperty, func, onChanged, expression);
public static Shape Fill(this Shape control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static Shape Fill<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape Stretch(this Shape control, IBinding binding)
   => control._set(Shape.StretchProperty, binding);
public static Shape Stretch(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape Stretch(this Shape control, Func<Stretch> func, Action<Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StretchProperty, func, onChanged, expression);
public static Shape Stretch(this Shape control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Shape Stretch<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape Stroke(this Shape control, IBinding binding)
   => control._set(Shape.StrokeProperty, binding);
public static Shape Stroke(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape Stroke(this Shape control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeProperty, func, onChanged, expression);
public static Shape Stroke(this Shape control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static Shape Stroke<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeDashArray(this Shape control, IBinding binding)
   => control._set(Shape.StrokeDashArrayProperty, binding);
public static Shape StrokeDashArray(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape StrokeDashArray(this Shape control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeDashArrayProperty, func, onChanged, expression);
public static Shape StrokeDashArray(this Shape control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static Shape StrokeDashArray<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeDashOffset(this Shape control, IBinding binding)
   => control._set(Shape.StrokeDashOffsetProperty, binding);
public static Shape StrokeDashOffset(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape StrokeDashOffset(this Shape control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeDashOffsetProperty, func, onChanged, expression);
public static Shape StrokeDashOffset(this Shape control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static Shape StrokeDashOffset<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeThickness(this Shape control, IBinding binding)
   => control._set(Shape.StrokeThicknessProperty, binding);
public static Shape StrokeThickness(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape StrokeThickness(this Shape control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeThicknessProperty, func, onChanged, expression);
public static Shape StrokeThickness(this Shape control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static Shape StrokeThickness<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeLineCap(this Shape control, IBinding binding)
   => control._set(Shape.StrokeLineCapProperty, binding);
public static Shape StrokeLineCap(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape StrokeLineCap(this Shape control, Func<PenLineCap> func, Action<PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeLineCapProperty, func, onChanged, expression);
public static Shape StrokeLineCap(this Shape control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static Shape StrokeLineCap<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeJoin(this Shape control, IBinding binding)
   => control._set(Shape.StrokeJoinProperty, binding);
public static Shape StrokeJoin(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Shape.StrokeJoinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Shape StrokeJoin(this Shape control, Func<PenLineJoin> func, Action<PenLineJoin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeJoinProperty, func, onChanged, expression);
public static Shape StrokeJoin(this Shape control, PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = value, bindingMode, converter, bindingSource);
public static Shape StrokeJoin<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

