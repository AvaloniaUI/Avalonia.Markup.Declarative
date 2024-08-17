#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using SkewTransform = Avalonia.Media.SkewTransform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SkewTransformExtensions
{
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, IBinding binding)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, binding);
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, func, onChanged, expression);
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.SkewTransform AngleX<TValue>(this Avalonia.Media.SkewTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, IBinding binding)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, binding);
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, func, onChanged, expression);
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.SkewTransform AngleY<TValue>(this Avalonia.Media.SkewTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

