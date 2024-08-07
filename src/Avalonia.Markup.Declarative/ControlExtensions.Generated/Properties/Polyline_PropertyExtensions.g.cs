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
public static partial class PolylineExtensions
{
public static Polyline Points(this Polyline control, IBinding binding)
   => control._set(Polyline.PointsProperty, binding);
public static Polyline Points(this Polyline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Polyline.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Polyline Points(this Polyline control, Func<IList<Point>> func, Action<IList<Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Polyline.PointsProperty, func, onChanged, expression);
public static Polyline Points(this Polyline control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polyline.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static Polyline Points<TValue>(this Polyline control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polyline.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

