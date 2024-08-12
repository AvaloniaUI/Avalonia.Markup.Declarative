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
public static partial class ArcSegmentExtensions
{
public static ArcSegment IsLargeArc(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.IsLargeArcProperty, binding);
public static ArcSegment IsLargeArc(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ArcSegment.IsLargeArcProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ArcSegment IsLargeArc(this ArcSegment control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.IsLargeArcProperty, func, onChanged, expression);
public static ArcSegment IsLargeArc(this ArcSegment control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = value, bindingMode, converter, bindingSource);
public static ArcSegment IsLargeArc<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment Point(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.PointProperty, binding);
public static ArcSegment Point(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ArcSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ArcSegment Point(this ArcSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.PointProperty, func, onChanged, expression);
public static ArcSegment Point(this ArcSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);
public static ArcSegment Point<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment RotationAngle(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.RotationAngleProperty, binding);
public static ArcSegment RotationAngle(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ArcSegment.RotationAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ArcSegment RotationAngle(this ArcSegment control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.RotationAngleProperty, func, onChanged, expression);
public static ArcSegment RotationAngle(this ArcSegment control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = value, bindingMode, converter, bindingSource);
public static ArcSegment RotationAngle<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment Size(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.SizeProperty, binding);
public static ArcSegment Size(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ArcSegment.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ArcSegment Size(this ArcSegment control, Func<Size> func, Action<Size>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.SizeProperty, func, onChanged, expression);
public static ArcSegment Size(this ArcSegment control, Size value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SizeProperty, ps, () => control.Size = value, bindingMode, converter, bindingSource);
public static ArcSegment Size<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Size> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SizeProperty, ps, () => control.Size = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ArcSegment Size(this ArcSegment control, Double width = default, Double height = default)
   => control._set(() => control.Size = new Size(width, height));
public static ArcSegment Size(this ArcSegment control, Vector2 vector2 = default)
   => control._set(() => control.Size = new Size(vector2));
public static ArcSegment SweepDirection(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.SweepDirectionProperty, binding);
public static ArcSegment SweepDirection(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ArcSegment.SweepDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ArcSegment SweepDirection(this ArcSegment control, Func<SweepDirection> func, Action<SweepDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.SweepDirectionProperty, func, onChanged, expression);
public static ArcSegment SweepDirection(this ArcSegment control, SweepDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = value, bindingMode, converter, bindingSource);
public static ArcSegment SweepDirection<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, SweepDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

