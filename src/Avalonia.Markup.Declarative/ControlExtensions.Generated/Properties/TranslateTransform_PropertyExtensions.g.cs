#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TranslateTransform = Avalonia.Media.TranslateTransform;

namespace Avalonia.Markup.Declarative;
public static partial class TranslateTransformExtensions
{
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, IBinding binding)
   => control._set(Avalonia.Media.TranslateTransform.XProperty, binding);
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.TranslateTransform.XProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.TranslateTransform.XProperty, func, onChanged, expression);
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.TranslateTransform.XProperty, ps, () => control.X = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.TranslateTransform X<TValue>(this Avalonia.Media.TranslateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.TranslateTransform.XProperty, ps, () => control.X = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, IBinding binding)
   => control._set(Avalonia.Media.TranslateTransform.YProperty, binding);
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.TranslateTransform.YProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.TranslateTransform.YProperty, func, onChanged, expression);
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.TranslateTransform.YProperty, ps, () => control.Y = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.TranslateTransform Y<TValue>(this Avalonia.Media.TranslateTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.TranslateTransform.YProperty, ps, () => control.Y = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

