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
public static T RadiusX<T>(this T control, IBinding binding) where T : Rectangle
   => control._set(Rectangle.RadiusXProperty, binding);
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Rectangle
   => control._set(Rectangle.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusX<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Rectangle
   => control._set(Rectangle.RadiusXProperty, func, onChanged, expression);
public static T RadiusX<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Rectangle
=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static T RadiusX<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Rectangle
=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RadiusY<T>(this T control, IBinding binding) where T : Rectangle
   => control._set(Rectangle.RadiusYProperty, binding);
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Rectangle
   => control._set(Rectangle.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusY<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Rectangle
   => control._set(Rectangle.RadiusYProperty, func, onChanged, expression);
public static T RadiusY<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Rectangle
=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static T RadiusY<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Rectangle
=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

