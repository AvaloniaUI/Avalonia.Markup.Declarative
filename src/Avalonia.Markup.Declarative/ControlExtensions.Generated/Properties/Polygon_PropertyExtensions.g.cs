#nullable enable
using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolygonExtensions
{
public static Polygon Points(this Polygon control, IBinding binding)
   => control._set(Polygon.PointsProperty, binding);
public static Polygon Points(this Polygon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Polygon.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Polygon Points(this Polygon control, Func<IList<Point>> func, Action<IList<Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Polygon.PointsProperty, func, onChanged, expression);
public static Polygon Points(this Polygon control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polygon.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static Polygon Points<TValue>(this Polygon control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polygon.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

