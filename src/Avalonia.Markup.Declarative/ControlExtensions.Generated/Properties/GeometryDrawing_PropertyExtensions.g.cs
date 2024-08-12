#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryDrawingExtensions
{
public static GeometryDrawing Geometry(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.GeometryProperty, binding);
public static GeometryDrawing Geometry(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeometryDrawing.GeometryProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeometryDrawing Geometry(this GeometryDrawing control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.GeometryProperty, func, onChanged, expression);
public static GeometryDrawing Geometry(this GeometryDrawing control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.GeometryProperty, ps, () => control.Geometry = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Geometry<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.GeometryProperty, ps, () => control.Geometry = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeometryDrawing Brush(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.BrushProperty, binding);
public static GeometryDrawing Brush(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeometryDrawing.BrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeometryDrawing Brush(this GeometryDrawing control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.BrushProperty, func, onChanged, expression);
public static GeometryDrawing Brush(this GeometryDrawing control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.BrushProperty, ps, () => control.Brush = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Brush<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.BrushProperty, ps, () => control.Brush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeometryDrawing Pen(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.PenProperty, binding);
public static GeometryDrawing Pen(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeometryDrawing.PenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeometryDrawing Pen(this GeometryDrawing control, Func<IPen> func, Action<IPen>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.PenProperty, func, onChanged, expression);
public static GeometryDrawing Pen(this GeometryDrawing control, IPen value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.PenProperty, ps, () => control.Pen = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Pen<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, IPen> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.PenProperty, ps, () => control.Pen = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

