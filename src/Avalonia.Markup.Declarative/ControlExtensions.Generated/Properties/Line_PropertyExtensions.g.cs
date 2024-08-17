#nullable enable
using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Line = Avalonia.Controls.Shapes.Line;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LineExtensions
{
public static T StartPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);
public static T StartPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty, func, onChanged, expression);
public static T StartPoint<T>(this T control, Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line
=> control._setEx(Avalonia.Controls.Shapes.Line.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static T StartPoint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line
=> control._setEx(Avalonia.Controls.Shapes.Line.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T EndPoint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);
public static T EndPoint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Line
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty, func, onChanged, expression);
public static T EndPoint<T>(this T control, Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line
=> control._setEx(Avalonia.Controls.Shapes.Line.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static T EndPoint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Line
=> control._setEx(Avalonia.Controls.Shapes.Line.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

