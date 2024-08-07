#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TranslateTransformExtensions
{
public static TranslateTransform X(this TranslateTransform control, IBinding binding)
   => control._set(TranslateTransform.XProperty, binding);
public static TranslateTransform X(this TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TranslateTransform.XProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TranslateTransform X(this TranslateTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TranslateTransform.XProperty, func, onChanged, expression);
public static TranslateTransform X(this TranslateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.XProperty, ps, () => control.X = value, bindingMode, converter, bindingSource);
public static TranslateTransform X<TValue>(this TranslateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.XProperty, ps, () => control.X = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TranslateTransform Y(this TranslateTransform control, IBinding binding)
   => control._set(TranslateTransform.YProperty, binding);
public static TranslateTransform Y(this TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TranslateTransform.YProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TranslateTransform Y(this TranslateTransform control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TranslateTransform.YProperty, func, onChanged, expression);
public static TranslateTransform Y(this TranslateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.YProperty, ps, () => control.Y = value, bindingMode, converter, bindingSource);
public static TranslateTransform Y<TValue>(this TranslateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.YProperty, ps, () => control.Y = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

