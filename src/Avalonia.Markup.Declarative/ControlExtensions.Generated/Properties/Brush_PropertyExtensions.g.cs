#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Brush = Avalonia.Media.Brush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class BrushExtensions
{
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.OpacityProperty, func, onChanged, expression);
public static T Opacity<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformProperty, binding);
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Transform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformProperty, func, onChanged, expression);
public static T Transform<T>(this T control, Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static T Transform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TransformOrigin<T>(this T control, IBinding binding) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, binding);
public static T TransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Brush
   => control._set(Avalonia.Media.Brush.TransformOriginProperty, func, onChanged, expression);
public static T TransformOrigin<T>(this T control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.TransformOriginProperty, ps, () => control.TransformOrigin = value, bindingMode, converter, bindingSource);
public static T TransformOrigin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Brush
=> control._setEx(Avalonia.Media.Brush.TransformOriginProperty, ps, () => control.TransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T TransformOrigin<T>(this T control, Double x = default, Double y = default, RelativeUnit unit = default) where T : Avalonia.Media.Brush
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T TransformOrigin<T>(this T control, Point point = default, RelativeUnit unit = default) where T : Avalonia.Media.Brush
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(point, unit));
}

