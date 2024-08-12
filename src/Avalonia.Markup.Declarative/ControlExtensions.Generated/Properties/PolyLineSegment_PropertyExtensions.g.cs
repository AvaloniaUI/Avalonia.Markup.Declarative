#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolyLineSegmentExtensions
{
public static PolyLineSegment Points(this PolyLineSegment control, IBinding binding)
   => control._set(PolyLineSegment.PointsProperty, binding);
public static PolyLineSegment Points(this PolyLineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolyLineSegment.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolyLineSegment Points(this PolyLineSegment control, Func<IList<Point>> func, Action<IList<Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolyLineSegment.PointsProperty, func, onChanged, expression);
public static PolyLineSegment Points(this PolyLineSegment control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolyLineSegment.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static PolyLineSegment Points<TValue>(this PolyLineSegment control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolyLineSegment.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

