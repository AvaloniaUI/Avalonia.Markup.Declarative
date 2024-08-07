#nullable enable
using Avalonia.Collections;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextDecorationExtensions
{
public static TextDecoration Location(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.LocationProperty, binding);
public static TextDecoration Location(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration Location(this TextDecoration control, Func<TextDecorationLocation> func, Action<TextDecorationLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.LocationProperty, func, onChanged, expression);
public static TextDecoration Location(this TextDecoration control, TextDecorationLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = value, bindingMode, converter, bindingSource);
public static TextDecoration Location<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration Stroke(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeProperty, binding);
public static TextDecoration Stroke(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration Stroke(this TextDecoration control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeProperty, func, onChanged, expression);
public static TextDecoration Stroke(this TextDecoration control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static TextDecoration Stroke<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, binding);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, Func<TextDecorationUnit> func, Action<TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, func, onChanged, expression);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeThicknessUnit<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashArray(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeDashArrayProperty, binding);
public static TextDecoration StrokeDashArray(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeDashArray(this TextDecoration control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeDashArrayProperty, func, onChanged, expression);
public static TextDecoration StrokeDashArray(this TextDecoration control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashArray<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashOffset(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeDashOffsetProperty, binding);
public static TextDecoration StrokeDashOffset(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeDashOffset(this TextDecoration control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeDashOffsetProperty, func, onChanged, expression);
public static TextDecoration StrokeDashOffset(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashOffset<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeThickness(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeThicknessProperty, binding);
public static TextDecoration StrokeThickness(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeThickness(this TextDecoration control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeThicknessProperty, func, onChanged, expression);
public static TextDecoration StrokeThickness(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeThickness<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeLineCap(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeLineCapProperty, binding);
public static TextDecoration StrokeLineCap(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeLineCap(this TextDecoration control, Func<PenLineCap> func, Action<PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeLineCapProperty, func, onChanged, expression);
public static TextDecoration StrokeLineCap(this TextDecoration control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeLineCap<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffset(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeOffsetProperty, binding);
public static TextDecoration StrokeOffset(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeOffset(this TextDecoration control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeOffsetProperty, func, onChanged, expression);
public static TextDecoration StrokeOffset(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffset<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, binding);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, Func<TextDecorationUnit> func, Action<TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, func, onChanged, expression);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffsetUnit<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

