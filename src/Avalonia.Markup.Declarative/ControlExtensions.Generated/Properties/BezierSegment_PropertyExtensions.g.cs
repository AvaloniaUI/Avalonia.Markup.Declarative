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
public static partial class BezierSegmentExtensions
{
public static BezierSegment Point1(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point1Property, binding);
public static BezierSegment Point1(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(BezierSegment.Point1Property, avaloniaProperty, bindingMode, converter, overrideView);
public static BezierSegment Point1(this BezierSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point1Property, func, onChanged, expression);
public static BezierSegment Point1(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point1<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static BezierSegment Point2(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point2Property, binding);
public static BezierSegment Point2(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(BezierSegment.Point2Property, avaloniaProperty, bindingMode, converter, overrideView);
public static BezierSegment Point2(this BezierSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point2Property, func, onChanged, expression);
public static BezierSegment Point2(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point2<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static BezierSegment Point3(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point3Property, binding);
public static BezierSegment Point3(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(BezierSegment.Point3Property, avaloniaProperty, bindingMode, converter, overrideView);
public static BezierSegment Point3(this BezierSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point3Property, func, onChanged, expression);
public static BezierSegment Point3(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point3Property, ps, () => control.Point3 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point3<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point3Property, ps, () => control.Point3 = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

