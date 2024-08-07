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
public static Brush Opacity(this Brush control, IBinding binding)
   => control._set(Brush.OpacityProperty, binding);
public static Brush Opacity(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Brush.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Brush Opacity(this Brush control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.OpacityProperty, func, onChanged, expression);
public static Brush Opacity(this Brush control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static Brush Opacity<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Brush Transform(this Brush control, IBinding binding)
   => control._set(Brush.TransformProperty, binding);
public static Brush Transform(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Brush.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Brush Transform(this Brush control, Func<ITransform> func, Action<ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.TransformProperty, func, onChanged, expression);
public static Brush Transform(this Brush control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Brush Transform<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Brush TransformOrigin(this Brush control, IBinding binding)
   => control._set(Brush.TransformOriginProperty, binding);
public static Brush TransformOrigin(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Brush.TransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Brush TransformOrigin(this Brush control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.TransformOriginProperty, func, onChanged, expression);
public static Brush TransformOrigin(this Brush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = value, bindingMode, converter, bindingSource);
public static Brush TransformOrigin<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Brush TransformOrigin(this Brush control, Double x = default, Double y = default, RelativeUnit unit = default)
   => control._set(() => control.TransformOrigin = new RelativePoint(x, y, unit));
public static Brush TransformOrigin(this Brush control, Point point = default, RelativeUnit unit = default)
   => control._set(() => control.TransformOrigin = new RelativePoint(point, unit));
}

