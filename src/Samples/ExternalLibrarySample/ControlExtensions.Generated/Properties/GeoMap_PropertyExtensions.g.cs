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
public static T ActiveMap<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.ActiveMapProperty, binding);
public static T ActiveMap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.ActiveMapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ActiveMap<T>(this T control, Func<CoreMap<SkiaSharpDrawingContext>> func, Action<CoreMap<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.ActiveMapProperty, func, onChanged, expression);
public static T ActiveMap<T>(this T control, CoreMap<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = value, bindingMode, converter, bindingSource);
public static T ActiveMap<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CoreMap<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SyncContext<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.SyncContextProperty, binding);
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SyncContext<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.SyncContextProperty, func, onChanged, expression);
public static T SyncContext<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ViewCommand<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.ViewCommandProperty, binding);
public static T ViewCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.ViewCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewCommand<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.ViewCommandProperty, func, onChanged, expression);
public static T ViewCommand<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = value, bindingMode, converter, bindingSource);
public static T ViewCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MapProjection<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.MapProjectionProperty, binding);
public static T MapProjection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.MapProjectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MapProjection<T>(this T control, Func<MapProjection> func, Action<MapProjection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.MapProjectionProperty, func, onChanged, expression);
public static T MapProjection<T>(this T control, MapProjection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.MapProjectionProperty, ps, () => control.MapProjection = value, bindingMode, converter, bindingSource);
public static T MapProjection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, MapProjection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.MapProjectionProperty, ps, () => control.MapProjection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Series<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.SeriesProperty, binding);
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Series<T>(this T control, Func<IEnumerable<IGeoSeries>> func, Action<IEnumerable<IGeoSeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.SeriesProperty, func, onChanged, expression);
public static T Series<T>(this T control, IEnumerable<IGeoSeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<IGeoSeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stroke<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.StrokeProperty, binding);
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stroke<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.StrokeProperty, func, onChanged, expression);
public static T Stroke<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static T Stroke<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Fill<T>(this T control, IBinding binding) where T : GeoMap
   => control._set(GeoMap.FillProperty, binding);
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeoMap
   => control._set(GeoMap.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Fill<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeoMap
   => control._set(GeoMap.FillProperty, func, onChanged, expression);
public static T Fill<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static T Fill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeoMap
=> control._setEx(GeoMap.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

