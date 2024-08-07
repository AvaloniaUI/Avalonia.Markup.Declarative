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
public static EllipseGeometry Rect(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RectProperty, binding);
public static EllipseGeometry Rect(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(EllipseGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static EllipseGeometry Rect(this EllipseGeometry control, Func<Rect> func, Action<Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RectProperty, func, onChanged, expression);
public static EllipseGeometry Rect(this EllipseGeometry control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static EllipseGeometry Rect<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static EllipseGeometry Rect(this EllipseGeometry control, Double x = default, Double y = default, Double width = default, Double height = default)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static EllipseGeometry Rect(this EllipseGeometry control, Size size = default)
   => control._set(() => control.Rect = new Rect(size));
public static EllipseGeometry Rect(this EllipseGeometry control, Point position = default, Size size = default)
   => control._set(() => control.Rect = new Rect(position, size));
public static EllipseGeometry Rect(this EllipseGeometry control, Point topLeft = default, Point bottomRight = default)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
public static EllipseGeometry RadiusX(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RadiusXProperty, binding);
public static EllipseGeometry RadiusX(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(EllipseGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static EllipseGeometry RadiusX(this EllipseGeometry control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RadiusXProperty, func, onChanged, expression);
public static EllipseGeometry RadiusX(this EllipseGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusX<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusY(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RadiusYProperty, binding);
public static EllipseGeometry RadiusY(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(EllipseGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static EllipseGeometry RadiusY(this EllipseGeometry control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RadiusYProperty, func, onChanged, expression);
public static EllipseGeometry RadiusY(this EllipseGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusY<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static EllipseGeometry Center(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.CenterProperty, binding);
public static EllipseGeometry Center(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(EllipseGeometry.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static EllipseGeometry Center(this EllipseGeometry control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.CenterProperty, func, onChanged, expression);
public static EllipseGeometry Center(this EllipseGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static EllipseGeometry Center<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

