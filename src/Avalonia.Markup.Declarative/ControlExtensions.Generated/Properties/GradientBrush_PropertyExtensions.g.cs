#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GradientBrushExtensions
{
public static T SpreadMethod<T>(this T control, IBinding binding) where T : GradientBrush
   => control._set(GradientBrush.SpreadMethodProperty, binding);
public static T SpreadMethod<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GradientBrush
   => control._set(GradientBrush.SpreadMethodProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SpreadMethod<T>(this T control, Func<GradientSpreadMethod> func, Action<GradientSpreadMethod>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GradientBrush
   => control._set(GradientBrush.SpreadMethodProperty, func, onChanged, expression);
public static T SpreadMethod<T>(this T control, GradientSpreadMethod value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GradientBrush
=> control._setEx(GradientBrush.SpreadMethodProperty, ps, () => control.SpreadMethod = value, bindingMode, converter, bindingSource);
public static T SpreadMethod<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GradientSpreadMethod> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GradientBrush
=> control._setEx(GradientBrush.SpreadMethodProperty, ps, () => control.SpreadMethod = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T GradientStops<T>(this T control, IBinding binding) where T : GradientBrush
   => control._set(GradientBrush.GradientStopsProperty, binding);
public static T GradientStops<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GradientBrush
   => control._set(GradientBrush.GradientStopsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T GradientStops<T>(this T control, Func<GradientStops> func, Action<GradientStops>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GradientBrush
   => control._set(GradientBrush.GradientStopsProperty, func, onChanged, expression);
public static T GradientStops<T>(this T control, GradientStops value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GradientBrush
=> control._setEx(GradientBrush.GradientStopsProperty, ps, () => control.GradientStops = value, bindingMode, converter, bindingSource);
public static T GradientStops<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GradientStops> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GradientBrush
=> control._setEx(GradientBrush.GradientStopsProperty, ps, () => control.GradientStops = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

