#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using LinearGradientBrush = Avalonia.Media.LinearGradientBrush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LinearGradientBrushExtensions
{
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty, binding);
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty, func, onChanged, expression);
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.LinearGradientBrush StartPoint<TValue>(this Avalonia.Media.LinearGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(point, unit));
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, IBinding binding)
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty, binding);
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty, func, onChanged, expression);
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.LinearGradientBrush EndPoint<TValue>(this Avalonia.Media.LinearGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(point, unit));
}

