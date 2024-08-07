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
public static partial class LinearGradientBrushExtensions
{
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, IBinding binding)
   => control._set(LinearGradientBrush.StartPointProperty, binding);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(LinearGradientBrush.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LinearGradientBrush.StartPointProperty, func, onChanged, expression);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static LinearGradientBrush StartPoint<TValue>(this LinearGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.StartPoint = new RelativePoint(x, y, unit));
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.StartPoint = new RelativePoint(point, unit));
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, IBinding binding)
   => control._set(LinearGradientBrush.EndPointProperty, binding);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(LinearGradientBrush.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LinearGradientBrush.EndPointProperty, func, onChanged, expression);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static LinearGradientBrush EndPoint<TValue>(this LinearGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.EndPoint = new RelativePoint(x, y, unit));
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.EndPoint = new RelativePoint(point, unit));
}

