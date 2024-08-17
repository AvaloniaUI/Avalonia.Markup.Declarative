#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ConicGradientBrush = Avalonia.Media.ConicGradientBrush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ConicGradientBrushExtensions
{
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, binding);
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, func, onChanged, expression);
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ConicGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ConicGradientBrush Center<TValue>(this Avalonia.Media.ConicGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ConicGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, binding);
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, func, onChanged, expression);
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ConicGradientBrush.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ConicGradientBrush Angle<TValue>(this Avalonia.Media.ConicGradientBrush control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ConicGradientBrush.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

