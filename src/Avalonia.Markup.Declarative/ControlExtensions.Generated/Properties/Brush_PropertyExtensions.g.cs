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
public static partial class BrushExtensions
{
public static T Opacity<T>(this T control, IBinding binding) where T : Brush
   => control._set(Brush.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Brush
   => control._set(Brush.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Opacity<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Brush
   => control._set(Brush.OpacityProperty, func, onChanged, expression);
public static T Opacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Transform<T>(this T control, IBinding binding) where T : Brush
   => control._set(Brush.TransformProperty, binding);
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Brush
   => control._set(Brush.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Transform<T>(this T control, Func<ITransform> func, Action<ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Brush
   => control._set(Brush.TransformProperty, func, onChanged, expression);
public static T Transform<T>(this T control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static T Transform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TransformOrigin<T>(this T control, IBinding binding) where T : Brush
   => control._set(Brush.TransformOriginProperty, binding);
public static T TransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Brush
   => control._set(Brush.TransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransformOrigin<T>(this T control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Brush
   => control._set(Brush.TransformOriginProperty, func, onChanged, expression);
public static T TransformOrigin<T>(this T control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = value, bindingMode, converter, bindingSource);
public static T TransformOrigin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Brush
=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T TransformOrigin<T>(this T control, Double x = default, Double y = default, RelativeUnit unit = default) where T : Brush
   => control._set(() => control.TransformOrigin = new RelativePoint(x, y, unit));
public static T TransformOrigin<T>(this T control, Point point = default, RelativeUnit unit = default) where T : Brush
   => control._set(() => control.TransformOrigin = new RelativePoint(point, unit));
}

