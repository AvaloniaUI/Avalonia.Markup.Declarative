#nullable enable
using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LineExtensions
{
public static T StartPoint<T>(this T control, IBinding binding) where T : Line
   => control._set(Line.StartPointProperty, binding);
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Line
   => control._set(Line.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StartPoint<T>(this T control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Line
   => control._set(Line.StartPointProperty, func, onChanged, expression);
public static T StartPoint<T>(this T control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Line
=> control._setEx(Line.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static T StartPoint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Line
=> control._setEx(Line.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T EndPoint<T>(this T control, IBinding binding) where T : Line
   => control._set(Line.EndPointProperty, binding);
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Line
   => control._set(Line.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T EndPoint<T>(this T control, Func<Point> func, Action<Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Line
   => control._set(Line.EndPointProperty, func, onChanged, expression);
public static T EndPoint<T>(this T control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Line
=> control._setEx(Line.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static T EndPoint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Line
=> control._setEx(Line.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

