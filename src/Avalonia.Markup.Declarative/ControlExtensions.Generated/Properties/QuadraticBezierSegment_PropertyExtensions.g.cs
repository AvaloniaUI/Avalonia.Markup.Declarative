#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class QuadraticBezierSegmentExtensions
{
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, IBinding binding)
   => control._set(QuadraticBezierSegment.Point1Property, binding);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(QuadraticBezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(QuadraticBezierSegment.Point1Property, func, onChanged, expression);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point1<TValue>(this QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, IBinding binding)
   => control._set(QuadraticBezierSegment.Point2Property, binding);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(QuadraticBezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(QuadraticBezierSegment.Point2Property, func, onChanged, expression);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point2<TValue>(this QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

