#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using GeoMap = LiveChartsCore.SkiaSharpView.Avalonia.GeoMap;
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
public static T ActiveMap<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, binding);
public static T ActiveMap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ActiveMap<T>(this T control, Func<LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, func, onChanged, expression);
public static T ActiveMap<T>(this T control, LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = value, bindingMode, converter, bindingSource);
public static T ActiveMap<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SyncContext<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, binding);
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SyncContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, func, onChanged, expression);
public static T SyncContext<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ViewCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, binding);
public static T ViewCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ViewCommand<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, func, onChanged, expression);
public static T ViewCommand<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = value, bindingMode, converter, bindingSource);
public static T ViewCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MapProjection<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, binding);
public static T MapProjection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MapProjection<T>(this T control, Func<LiveChartsCore.Geo.MapProjection> func, Action<LiveChartsCore.Geo.MapProjection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, func, onChanged, expression);
public static T MapProjection<T>(this T control, LiveChartsCore.Geo.MapProjection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, ps, () => control.MapProjection = value, bindingMode, converter, bindingSource);
public static T MapProjection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Geo.MapProjection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, ps, () => control.MapProjection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Series<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, binding);
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Series<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, func, onChanged, expression);
public static T Series<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stroke<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, binding);
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stroke<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, func, onChanged, expression);
public static T Stroke<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static T Stroke<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Fill<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, binding);
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Fill<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, func, onChanged, expression);
public static T Fill<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static T Fill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

