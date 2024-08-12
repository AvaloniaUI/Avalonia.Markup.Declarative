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
public static partial class ConicGradientBrushExtensions
{
public static ConicGradientBrush Center(this ConicGradientBrush control, IBinding binding)
   => control._set(ConicGradientBrush.CenterProperty, binding);
public static ConicGradientBrush Center(this ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ConicGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ConicGradientBrush Center(this ConicGradientBrush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ConicGradientBrush.CenterProperty, func, onChanged, expression);
public static ConicGradientBrush Center(this ConicGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static ConicGradientBrush Center<TValue>(this ConicGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ConicGradientBrush Center(this ConicGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new RelativePoint(x, y, unit));
public static ConicGradientBrush Center(this ConicGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new RelativePoint(point, unit));
public static ConicGradientBrush Angle(this ConicGradientBrush control, IBinding binding)
   => control._set(ConicGradientBrush.AngleProperty, binding);
public static ConicGradientBrush Angle(this ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ConicGradientBrush.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ConicGradientBrush Angle(this ConicGradientBrush control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ConicGradientBrush.AngleProperty, func, onChanged, expression);
public static ConicGradientBrush Angle(this ConicGradientBrush control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static ConicGradientBrush Angle<TValue>(this ConicGradientBrush control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

