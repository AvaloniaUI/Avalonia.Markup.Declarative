#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using RadialGradientBrush = Avalonia.Media.RadialGradientBrush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RadialGradientBrushExtensions
{
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, binding);
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty, func, onChanged, expression);
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RadialGradientBrush Center<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, binding);
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, func, onChanged, expression);
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RadialGradientBrush GradientOrigin<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(point, unit));
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, binding);
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty, func, onChanged, expression);
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RadialGradientBrush RadiusX<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, binding);
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty, func, onChanged, expression);
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.RadialGradientBrush RadiusY<TValue>(this Avalonia.Media.RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeScalar> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.RadialGradientBrush.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

