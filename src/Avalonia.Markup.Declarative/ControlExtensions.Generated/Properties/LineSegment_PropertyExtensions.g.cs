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
public static partial class LineSegmentExtensions
{
public static LineSegment Point(this LineSegment control, IBinding binding)
   => control._set(LineSegment.PointProperty, binding);
public static LineSegment Point(this LineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(LineSegment.PointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static LineSegment Point(this LineSegment control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineSegment.PointProperty, func, onChanged, expression);
public static LineSegment Point(this LineSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);
public static LineSegment Point<TValue>(this LineSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

