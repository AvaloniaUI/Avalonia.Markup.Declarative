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
public static T Location<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.LocationProperty, binding);
public static T Location<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Location<T>(this T control, Func<TextDecorationLocation> func, Action<TextDecorationLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.LocationProperty, func, onChanged, expression);
public static T Location<T>(this T control, TextDecorationLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = value, bindingMode, converter, bindingSource);
public static T Location<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextDecorationLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stroke<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeProperty, binding);
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stroke<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeProperty, func, onChanged, expression);
public static T Stroke<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static T Stroke<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeThicknessUnit<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessUnitProperty, binding);
public static T StrokeThicknessUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeThicknessUnit<T>(this T control, Func<TextDecorationUnit> func, Action<TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessUnitProperty, func, onChanged, expression);
public static T StrokeThicknessUnit<T>(this T control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = value, bindingMode, converter, bindingSource);
public static T StrokeThicknessUnit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashArrayProperty, binding);
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashArray<T>(this T control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashArrayProperty, func, onChanged, expression);
public static T StrokeDashArray<T>(this T control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static T StrokeDashArray<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashOffsetProperty, binding);
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeDashOffsetProperty, func, onChanged, expression);
public static T StrokeDashOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeThickness<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessProperty, binding);
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeThickness<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeThicknessProperty, func, onChanged, expression);
public static T StrokeThickness<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static T StrokeThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeLineCapProperty, binding);
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeLineCap<T>(this T control, Func<PenLineCap> func, Action<PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeLineCapProperty, func, onChanged, expression);
public static T StrokeLineCap<T>(this T control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static T StrokeLineCap<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeOffset<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetProperty, binding);
public static T StrokeOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetProperty, func, onChanged, expression);
public static T StrokeOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = value, bindingMode, converter, bindingSource);
public static T StrokeOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeOffsetUnit<T>(this T control, IBinding binding) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetUnitProperty, binding);
public static T StrokeOffsetUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeOffsetUnit<T>(this T control, Func<TextDecorationUnit> func, Action<TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextDecoration
   => control._set(TextDecoration.StrokeOffsetUnitProperty, func, onChanged, expression);
public static T StrokeOffsetUnit<T>(this T control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = value, bindingMode, converter, bindingSource);
public static T StrokeOffsetUnit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextDecoration
=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

