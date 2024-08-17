#nullable enable
using Avalonia.Collections;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextDecoration = Avalonia.Media.TextDecoration;

namespace Avalonia.Markup.Declarative;
public static partial class TextDecorationExtensions
{
public static T Location<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, binding);
public static T Location<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Location<T>(this T control, Func<Avalonia.Media.TextDecorationLocation> func, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.LocationProperty, func, onChanged, expression);
public static T Location<T>(this T control, Avalonia.Media.TextDecorationLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.LocationProperty, ps, () => control.Location = value, bindingMode, converter, bindingSource);
public static T Location<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.LocationProperty, ps, () => control.Location = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stroke<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, binding);
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty, func, onChanged, expression);
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static T Stroke<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeThicknessUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, binding);
public static T StrokeThicknessUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeThicknessUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, func, onChanged, expression);
public static T StrokeThicknessUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = value, bindingMode, converter, bindingSource);
public static T StrokeThicknessUnit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashArray<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, binding);
public static T StrokeDashArray<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, func, onChanged, expression);
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static T StrokeDashArray<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, binding);
public static T StrokeDashOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, func, onChanged, expression);
public static T StrokeDashOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static T StrokeDashOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, binding);
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty, func, onChanged, expression);
public static T StrokeThickness<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static T StrokeThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeLineCap<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, binding);
public static T StrokeLineCap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty, func, onChanged, expression);
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static T StrokeLineCap<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeOffset<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, binding);
public static T StrokeOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty, func, onChanged, expression);
public static T StrokeOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = value, bindingMode, converter, bindingSource);
public static T StrokeOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StrokeOffsetUnit<T>(this T control, IBinding binding) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, binding);
public static T StrokeOffsetUnit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StrokeOffsetUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TextDecoration
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, func, onChanged, expression);
public static T StrokeOffsetUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = value, bindingMode, converter, bindingSource);
public static T StrokeOffsetUnit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TextDecoration
=> control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

