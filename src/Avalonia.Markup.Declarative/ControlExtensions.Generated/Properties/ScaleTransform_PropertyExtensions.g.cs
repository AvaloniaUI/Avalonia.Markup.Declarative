#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ScaleTransform = Avalonia.Media.ScaleTransform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScaleTransformExtensions
{
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, IBinding binding)
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty, binding);
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty, func, onChanged, expression);
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ScaleTransform ScaleX<TValue>(this Avalonia.Media.ScaleTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, IBinding binding)
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty, binding);
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty, func, onChanged, expression);
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ScaleTransform ScaleY<TValue>(this Avalonia.Media.ScaleTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

