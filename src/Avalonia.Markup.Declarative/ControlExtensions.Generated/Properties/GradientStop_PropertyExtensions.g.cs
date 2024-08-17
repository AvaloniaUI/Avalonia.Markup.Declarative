#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using GradientStop = Avalonia.Media.GradientStop;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GradientStopExtensions
{
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, IBinding binding)
   => control._set(Avalonia.Media.GradientStop.OffsetProperty, binding);
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.GradientStop.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.GradientStop.OffsetProperty, func, onChanged, expression);
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GradientStop.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.GradientStop Offset<TValue>(this Avalonia.Media.GradientStop control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GradientStop.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, IBinding binding)
   => control._set(Avalonia.Media.GradientStop.ColorProperty, binding);
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.GradientStop.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.GradientStop.ColorProperty, func, onChanged, expression);
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GradientStop.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.GradientStop Color<TValue>(this Avalonia.Media.GradientStop control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GradientStop.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

