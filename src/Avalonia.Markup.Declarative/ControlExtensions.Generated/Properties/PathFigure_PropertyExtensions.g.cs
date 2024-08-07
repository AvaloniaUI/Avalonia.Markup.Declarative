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
public static partial class PathFigureExtensions
{
public static PathFigure IsClosed(this PathFigure control, IBinding binding)
   => control._set(PathFigure.IsClosedProperty, binding);
public static PathFigure IsClosed(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathFigure.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathFigure IsClosed(this PathFigure control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.IsClosedProperty, func, onChanged, expression);
public static PathFigure IsClosed(this PathFigure control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static PathFigure IsClosed<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure IsFilled(this PathFigure control, IBinding binding)
   => control._set(PathFigure.IsFilledProperty, binding);
public static PathFigure IsFilled(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathFigure.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathFigure IsFilled(this PathFigure control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.IsFilledProperty, func, onChanged, expression);
public static PathFigure IsFilled(this PathFigure control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static PathFigure IsFilled<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure Segments(this PathFigure control, IBinding binding)
   => control._set(PathFigure.SegmentsProperty, binding);
public static PathFigure Segments(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathFigure.SegmentsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathFigure Segments(this PathFigure control, Func<PathSegments> func, Action<PathSegments>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.SegmentsProperty, func, onChanged, expression);
public static PathFigure Segments(this PathFigure control, PathSegments value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.SegmentsProperty, ps, () => control.Segments = value, bindingMode, converter, bindingSource);
public static PathFigure Segments<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, PathSegments> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.SegmentsProperty, ps, () => control.Segments = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure StartPoint(this PathFigure control, IBinding binding)
   => control._set(PathFigure.StartPointProperty, binding);
public static PathFigure StartPoint(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathFigure.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathFigure StartPoint(this PathFigure control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.StartPointProperty, func, onChanged, expression);
public static PathFigure StartPoint(this PathFigure control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static PathFigure StartPoint<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

