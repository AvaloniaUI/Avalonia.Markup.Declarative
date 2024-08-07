#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore.Drawing;
using LiveChartsCore.Geo;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeoMapExtensions
{
public static GeoMap ActiveMap(this GeoMap control, IBinding binding)
   => control._set(GeoMap.ActiveMapProperty, binding);
public static GeoMap ActiveMap(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.ActiveMapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap ActiveMap(this GeoMap control, Func<CoreMap<SkiaSharpDrawingContext>> func, Action<CoreMap<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.ActiveMapProperty, func, onChanged, expression);
public static GeoMap ActiveMap(this GeoMap control, CoreMap<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = value, bindingMode, converter, bindingSource);
public static GeoMap ActiveMap<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, CoreMap<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap SyncContext(this GeoMap control, IBinding binding)
   => control._set(GeoMap.SyncContextProperty, binding);
public static GeoMap SyncContext(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap SyncContext(this GeoMap control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.SyncContextProperty, func, onChanged, expression);
public static GeoMap SyncContext(this GeoMap control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static GeoMap SyncContext<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap ViewCommand(this GeoMap control, IBinding binding)
   => control._set(GeoMap.ViewCommandProperty, binding);
public static GeoMap ViewCommand(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.ViewCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap ViewCommand(this GeoMap control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.ViewCommandProperty, func, onChanged, expression);
public static GeoMap ViewCommand(this GeoMap control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = value, bindingMode, converter, bindingSource);
public static GeoMap ViewCommand<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap MapProjection(this GeoMap control, IBinding binding)
   => control._set(GeoMap.MapProjectionProperty, binding);
public static GeoMap MapProjection(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.MapProjectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap MapProjection(this GeoMap control, Func<MapProjection> func, Action<MapProjection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.MapProjectionProperty, func, onChanged, expression);
public static GeoMap MapProjection(this GeoMap control, MapProjection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.MapProjectionProperty, ps, () => control.MapProjection = value, bindingMode, converter, bindingSource);
public static GeoMap MapProjection<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, MapProjection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.MapProjectionProperty, ps, () => control.MapProjection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap Series(this GeoMap control, IBinding binding)
   => control._set(GeoMap.SeriesProperty, binding);
public static GeoMap Series(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap Series(this GeoMap control, Func<IEnumerable<IGeoSeries>> func, Action<IEnumerable<IGeoSeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.SeriesProperty, func, onChanged, expression);
public static GeoMap Series(this GeoMap control, IEnumerable<IGeoSeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static GeoMap Series<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, IEnumerable<IGeoSeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap Stroke(this GeoMap control, IBinding binding)
   => control._set(GeoMap.StrokeProperty, binding);
public static GeoMap Stroke(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap Stroke(this GeoMap control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.StrokeProperty, func, onChanged, expression);
public static GeoMap Stroke(this GeoMap control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static GeoMap Stroke<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeoMap Fill(this GeoMap control, IBinding binding)
   => control._set(GeoMap.FillProperty, binding);
public static GeoMap Fill(this GeoMap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GeoMap.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GeoMap Fill(this GeoMap control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeoMap.FillProperty, func, onChanged, expression);
public static GeoMap Fill(this GeoMap control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static GeoMap Fill<TValue>(this GeoMap control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeoMap.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

