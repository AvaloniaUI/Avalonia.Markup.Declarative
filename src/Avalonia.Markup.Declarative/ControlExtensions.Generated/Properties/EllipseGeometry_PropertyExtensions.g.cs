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
public static partial class EllipseGeometryExtensions
{
public static T Rect<T>(this T control, IBinding binding) where T : EllipseGeometry
   => control._set(EllipseGeometry.RectProperty, binding);
public static T Rect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Rect<T>(this T control, Func<Rect> func, Action<Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RectProperty, func, onChanged, expression);
public static T Rect<T>(this T control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static T Rect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Rect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default) where T : EllipseGeometry
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static T Rect<T>(this T control, Size size = default) where T : EllipseGeometry
   => control._set(() => control.Rect = new Rect(size));
public static T Rect<T>(this T control, Point position = default, Size size = default) where T : EllipseGeometry
   => control._set(() => control.Rect = new Rect(position, size));
public static T Rect<T>(this T control, Point topLeft = default, Point bottomRight = default) where T : EllipseGeometry
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
public static T RadiusX<T>(this T control, IBinding binding) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusXProperty, binding);
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusX<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusXProperty, func, onChanged, expression);
public static T RadiusX<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static T RadiusX<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RadiusY<T>(this T control, IBinding binding) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusYProperty, binding);
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusY<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.RadiusYProperty, func, onChanged, expression);
public static T RadiusY<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static T RadiusY<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Center<T>(this T control, IBinding binding) where T : EllipseGeometry
   => control._set(EllipseGeometry.CenterProperty, binding);
public static T Center<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Center<T>(this T control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : EllipseGeometry
   => control._set(EllipseGeometry.CenterProperty, func, onChanged, expression);
public static T Center<T>(this T control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static T Center<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : EllipseGeometry
=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

