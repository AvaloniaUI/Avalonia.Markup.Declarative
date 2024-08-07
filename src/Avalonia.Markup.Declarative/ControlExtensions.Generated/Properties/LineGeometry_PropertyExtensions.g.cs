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
public static partial class LineGeometryExtensions
{
public static LineGeometry StartPoint(this LineGeometry control, IBinding binding)
   => control._set(LineGeometry.StartPointProperty, binding);
public static LineGeometry StartPoint(this LineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(LineGeometry.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static LineGeometry StartPoint(this LineGeometry control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineGeometry.StartPointProperty, func, onChanged, expression);
public static LineGeometry StartPoint(this LineGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static LineGeometry StartPoint<TValue>(this LineGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static LineGeometry EndPoint(this LineGeometry control, IBinding binding)
   => control._set(LineGeometry.EndPointProperty, binding);
public static LineGeometry EndPoint(this LineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(LineGeometry.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static LineGeometry EndPoint(this LineGeometry control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineGeometry.EndPointProperty, func, onChanged, expression);
public static LineGeometry EndPoint(this LineGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static LineGeometry EndPoint<TValue>(this LineGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

