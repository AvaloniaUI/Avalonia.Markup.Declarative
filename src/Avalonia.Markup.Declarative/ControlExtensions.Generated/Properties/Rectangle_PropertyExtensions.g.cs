#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RectangleExtensions
{
public static Rectangle RadiusX(this Rectangle control, IBinding binding)
   => control._set(Rectangle.RadiusXProperty, binding);
public static Rectangle RadiusX(this Rectangle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rectangle.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rectangle RadiusX(this Rectangle control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rectangle.RadiusXProperty, func, onChanged, expression);
public static Rectangle RadiusX(this Rectangle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static Rectangle RadiusX<TValue>(this Rectangle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rectangle RadiusY(this Rectangle control, IBinding binding)
   => control._set(Rectangle.RadiusYProperty, binding);
public static Rectangle RadiusY(this Rectangle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Rectangle.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Rectangle RadiusY(this Rectangle control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rectangle.RadiusYProperty, func, onChanged, expression);
public static Rectangle RadiusY(this Rectangle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static Rectangle RadiusY<TValue>(this Rectangle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

