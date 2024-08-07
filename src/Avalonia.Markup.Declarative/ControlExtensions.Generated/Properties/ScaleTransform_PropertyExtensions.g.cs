#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScaleTransformExtensions
{
public static ScaleTransform ScaleX(this ScaleTransform control, IBinding binding)
   => control._set(ScaleTransform.ScaleXProperty, binding);
public static ScaleTransform ScaleX(this ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScaleTransform.ScaleXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScaleTransform ScaleX(this ScaleTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScaleTransform.ScaleXProperty, func, onChanged, expression);
public static ScaleTransform ScaleX(this ScaleTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = value, bindingMode, converter, bindingSource);
public static ScaleTransform ScaleX<TValue>(this ScaleTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScaleTransform ScaleY(this ScaleTransform control, IBinding binding)
   => control._set(ScaleTransform.ScaleYProperty, binding);
public static ScaleTransform ScaleY(this ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScaleTransform.ScaleYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScaleTransform ScaleY(this ScaleTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScaleTransform.ScaleYProperty, func, onChanged, expression);
public static ScaleTransform ScaleY(this ScaleTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = value, bindingMode, converter, bindingSource);
public static ScaleTransform ScaleY<TValue>(this ScaleTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

