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
public static partial class PolylineGeometryExtensions
{
public static PolylineGeometry Points(this PolylineGeometry control, IBinding binding)
   => control._set(PolylineGeometry.PointsProperty, binding);
public static PolylineGeometry Points(this PolylineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolylineGeometry.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolylineGeometry Points(this PolylineGeometry control, Func<IList<Point>> func, Action<IList<Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolylineGeometry.PointsProperty, func, onChanged, expression);
public static PolylineGeometry Points(this PolylineGeometry control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static PolylineGeometry Points<TValue>(this PolylineGeometry control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolylineGeometry IsFilled(this PolylineGeometry control, IBinding binding)
   => control._set(PolylineGeometry.IsFilledProperty, binding);
public static PolylineGeometry IsFilled(this PolylineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolylineGeometry.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolylineGeometry IsFilled(this PolylineGeometry control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolylineGeometry.IsFilledProperty, func, onChanged, expression);
public static PolylineGeometry IsFilled(this PolylineGeometry control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static PolylineGeometry IsFilled<TValue>(this PolylineGeometry control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

