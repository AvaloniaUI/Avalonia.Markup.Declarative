#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GradientStopExtensions
{
public static GradientStop Offset(this GradientStop control, IBinding binding)
   => control._set(GradientStop.OffsetProperty, binding);
public static GradientStop Offset(this GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GradientStop.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GradientStop Offset(this GradientStop control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientStop.OffsetProperty, func, onChanged, expression);
public static GradientStop Offset(this GradientStop control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static GradientStop Offset<TValue>(this GradientStop control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GradientStop Color(this GradientStop control, IBinding binding)
   => control._set(GradientStop.ColorProperty, binding);
public static GradientStop Color(this GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GradientStop.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GradientStop Color(this GradientStop control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientStop.ColorProperty, func, onChanged, expression);
public static GradientStop Color(this GradientStop control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static GradientStop Color<TValue>(this GradientStop control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

