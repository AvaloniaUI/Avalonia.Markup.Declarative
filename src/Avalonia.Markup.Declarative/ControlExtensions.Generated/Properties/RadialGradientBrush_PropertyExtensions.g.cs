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
public static partial class RadialGradientBrushExtensions
{
public static RadialGradientBrush Center(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.CenterProperty, binding);
public static RadialGradientBrush Center(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RadialGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RadialGradientBrush Center(this RadialGradientBrush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.CenterProperty, func, onChanged, expression);
public static RadialGradientBrush Center(this RadialGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush Center<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RadialGradientBrush Center(this RadialGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new RelativePoint(x, y, unit));
public static RadialGradientBrush Center(this RadialGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new RelativePoint(point, unit));
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.GradientOriginProperty, binding);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RadialGradientBrush.GradientOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.GradientOriginProperty, func, onChanged, expression);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush GradientOrigin<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.GradientOrigin = new RelativePoint(x, y, unit));
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.GradientOrigin = new RelativePoint(point, unit));
public static RadialGradientBrush RadiusX(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.RadiusXProperty, binding);
public static RadialGradientBrush RadiusX(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RadialGradientBrush.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RadialGradientBrush RadiusX(this RadialGradientBrush control, Func<RelativeScalar> func, Action<RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.RadiusXProperty, func, onChanged, expression);
public static RadialGradientBrush RadiusX(this RadialGradientBrush control, RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush RadiusX<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RadialGradientBrush RadiusY(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.RadiusYProperty, binding);
public static RadialGradientBrush RadiusY(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RadialGradientBrush.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RadialGradientBrush RadiusY(this RadialGradientBrush control, Func<RelativeScalar> func, Action<RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.RadiusYProperty, func, onChanged, expression);
public static RadialGradientBrush RadiusY(this RadialGradientBrush control, RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush RadiusY<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

