#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathGeometryExtensions
{
public static T Figures<T>(this T control, IBinding binding) where T : PathGeometry
   => control._set(PathGeometry.FiguresProperty, binding);
public static T Figures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PathGeometry
   => control._set(PathGeometry.FiguresProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Figures<T>(this T control, Func<PathFigures> func, Action<PathFigures>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PathGeometry
   => control._set(PathGeometry.FiguresProperty, func, onChanged, expression);
public static T Figures<T>(this T control, PathFigures value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PathGeometry
=> control._setEx(PathGeometry.FiguresProperty, ps, () => control.Figures = value, bindingMode, converter, bindingSource);
public static T Figures<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PathFigures> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PathGeometry
=> control._setEx(PathGeometry.FiguresProperty, ps, () => control.Figures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FillRule<T>(this T control, IBinding binding) where T : PathGeometry
   => control._set(PathGeometry.FillRuleProperty, binding);
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PathGeometry
   => control._set(PathGeometry.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FillRule<T>(this T control, Func<FillRule> func, Action<FillRule>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PathGeometry
   => control._set(PathGeometry.FillRuleProperty, func, onChanged, expression);
public static T FillRule<T>(this T control, FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PathGeometry
=> control._setEx(PathGeometry.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);
public static T FillRule<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PathGeometry
=> control._setEx(PathGeometry.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

