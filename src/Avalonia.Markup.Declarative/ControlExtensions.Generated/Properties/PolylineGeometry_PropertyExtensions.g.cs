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
public static T Points<T>(this T control, IBinding binding) where T : PolylineGeometry
   => control._set(PolylineGeometry.PointsProperty, binding);
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolylineGeometry
   => control._set(PolylineGeometry.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Points<T>(this T control, Func<IList<Point>> func, Action<IList<Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolylineGeometry
   => control._set(PolylineGeometry.PointsProperty, func, onChanged, expression);
public static T Points<T>(this T control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolylineGeometry
=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static T Points<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolylineGeometry
=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsFilled<T>(this T control, IBinding binding) where T : PolylineGeometry
   => control._set(PolylineGeometry.IsFilledProperty, binding);
public static T IsFilled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolylineGeometry
   => control._set(PolylineGeometry.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsFilled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolylineGeometry
   => control._set(PolylineGeometry.IsFilledProperty, func, onChanged, expression);
public static T IsFilled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolylineGeometry
=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static T IsFilled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolylineGeometry
=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

