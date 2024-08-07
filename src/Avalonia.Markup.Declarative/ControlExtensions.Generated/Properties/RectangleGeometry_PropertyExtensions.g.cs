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
public static partial class RectangleGeometryExtensions
{
public static RectangleGeometry RadiusX(this RectangleGeometry control, IBinding binding)
   => control._set(RectangleGeometry.RadiusXProperty, binding);
public static RectangleGeometry RadiusX(this RectangleGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RectangleGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RectangleGeometry RadiusX(this RectangleGeometry control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RectangleGeometry.RadiusXProperty, func, onChanged, expression);
public static RectangleGeometry RadiusX(this RectangleGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static RectangleGeometry RadiusX<TValue>(this RectangleGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RectangleGeometry RadiusY(this RectangleGeometry control, IBinding binding)
   => control._set(RectangleGeometry.RadiusYProperty, binding);
public static RectangleGeometry RadiusY(this RectangleGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RectangleGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RectangleGeometry RadiusY(this RectangleGeometry control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RectangleGeometry.RadiusYProperty, func, onChanged, expression);
public static RectangleGeometry RadiusY(this RectangleGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static RectangleGeometry RadiusY<TValue>(this RectangleGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RectangleGeometry Rect(this RectangleGeometry control, IBinding binding)
   => control._set(RectangleGeometry.RectProperty, binding);
public static RectangleGeometry Rect(this RectangleGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RectangleGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RectangleGeometry Rect(this RectangleGeometry control, Func<Rect> func, Action<Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RectangleGeometry.RectProperty, func, onChanged, expression);
public static RectangleGeometry Rect(this RectangleGeometry control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static RectangleGeometry Rect<TValue>(this RectangleGeometry control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RectangleGeometry Rect(this RectangleGeometry control, Double x = default, Double y = default, Double width = default, Double height = default)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static RectangleGeometry Rect(this RectangleGeometry control, Size size = default)
   => control._set(() => control.Rect = new Rect(size));
public static RectangleGeometry Rect(this RectangleGeometry control, Point position = default, Size size = default)
   => control._set(() => control.Rect = new Rect(position, size));
public static RectangleGeometry Rect(this RectangleGeometry control, Point topLeft = default, Point bottomRight = default)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
}

