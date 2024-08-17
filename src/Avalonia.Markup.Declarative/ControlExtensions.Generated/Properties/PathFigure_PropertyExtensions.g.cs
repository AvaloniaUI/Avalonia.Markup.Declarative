#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using PathFigure = Avalonia.Media.PathFigure;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathFigureExtensions
{
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, IBinding binding)
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty, binding);
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty, func, onChanged, expression);
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure IsClosed<TValue>(this Avalonia.Media.PathFigure control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, IBinding binding)
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty, binding);
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty, func, onChanged, expression);
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure IsFilled<TValue>(this Avalonia.Media.PathFigure control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, IBinding binding)
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty, binding);
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Func<Avalonia.Media.PathSegments> func, Action<Avalonia.Media.PathSegments>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty, func, onChanged, expression);
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Avalonia.Media.PathSegments value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.SegmentsProperty, ps, () => control.Segments = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure Segments<TValue>(this Avalonia.Media.PathFigure control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PathSegments> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.SegmentsProperty, ps, () => control.Segments = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, IBinding binding)
   => control._set(Avalonia.Media.PathFigure.StartPointProperty, binding);
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.PathFigure.StartPointProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.PathFigure.StartPointProperty, func, onChanged, expression);
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Avalonia.Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.PathFigure StartPoint<TValue>(this Avalonia.Media.PathFigure control, TValue value, FuncValueConverter<TValue, Avalonia.Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PathFigure.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

