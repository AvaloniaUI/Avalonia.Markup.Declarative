#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.VisualElements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class PolarChartExtensions
{
public static T SyncContext<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.SyncContextProperty, binding);
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SyncContext<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.SyncContextProperty, func, onChanged, expression);
public static T SyncContext<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Title<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TitleProperty, binding);
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Title<T>(this T control, Func<VisualElement<SkiaSharpDrawingContext>> func, Action<VisualElement<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TitleProperty, func, onChanged, expression);
public static T Title<T>(this T control, VisualElement<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VisualElement<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Series<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.SeriesProperty, binding);
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Series<T>(this T control, Func<IEnumerable<ISeries>> func, Action<IEnumerable<ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.SeriesProperty, func, onChanged, expression);
public static T Series<T>(this T control, IEnumerable<ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElements<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.VisualElementsProperty, binding);
public static T VisualElements<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElements<T>(this T control, Func<IEnumerable<ChartElement<SkiaSharpDrawingContext>>> func, Action<IEnumerable<ChartElement<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.VisualElementsProperty, func, onChanged, expression);
public static T VisualElements<T>(this T control, IEnumerable<ChartElement<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);
public static T VisualElements<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<ChartElement<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FitToBounds<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.FitToBoundsProperty, binding);
public static T FitToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.FitToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FitToBounds<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.FitToBoundsProperty, func, onChanged, expression);
public static T FitToBounds<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = value, bindingMode, converter, bindingSource);
public static T FitToBounds<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TotalAngle<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TotalAngleProperty, binding);
public static T TotalAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TotalAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TotalAngle<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TotalAngleProperty, func, onChanged, expression);
public static T TotalAngle<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = value, bindingMode, converter, bindingSource);
public static T TotalAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRadius<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.InnerRadiusProperty, binding);
public static T InnerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.InnerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRadius<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.InnerRadiusProperty, func, onChanged, expression);
public static T InnerRadius<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = value, bindingMode, converter, bindingSource);
public static T InnerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InitialRotation<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.InitialRotationProperty, binding);
public static T InitialRotation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.InitialRotationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InitialRotation<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.InitialRotationProperty, func, onChanged, expression);
public static T InitialRotation<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = value, bindingMode, converter, bindingSource);
public static T InitialRotation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AngleAxes<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.AngleAxesProperty, binding);
public static T AngleAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.AngleAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AngleAxes<T>(this T control, Func<IEnumerable<IPolarAxis>> func, Action<IEnumerable<IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.AngleAxesProperty, func, onChanged, expression);
public static T AngleAxes<T>(this T control, IEnumerable<IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = value, bindingMode, converter, bindingSource);
public static T AngleAxes<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RadiusAxes<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.RadiusAxesProperty, binding);
public static T RadiusAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.RadiusAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusAxes<T>(this T control, Func<IEnumerable<IPolarAxis>> func, Action<IEnumerable<IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.RadiusAxesProperty, func, onChanged, expression);
public static T RadiusAxes<T>(this T control, IEnumerable<IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = value, bindingMode, converter, bindingSource);
public static T RadiusAxes<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.AnimationsSpeedProperty, binding);
public static T AnimationsSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AnimationsSpeed<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.AnimationsSpeedProperty, func, onChanged, expression);
public static T AnimationsSpeed<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T EasingFunction<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.EasingFunctionProperty, binding);
public static T EasingFunction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T EasingFunction<T>(this T control, Func<Func<Single,Single>> func, Action<Func<Single,Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.EasingFunctionProperty, func, onChanged, expression);
public static T EasingFunction<T>(this T control, Func<Single,Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);
public static T EasingFunction<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Func<Single,Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipPosition<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TooltipPositionProperty, binding);
public static T TooltipPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipPosition<T>(this T control, Func<TooltipPosition> func, Action<TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TooltipPositionProperty, func, onChanged, expression);
public static T TooltipPosition<T>(this T control, TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);
public static T TooltipPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TooltipBackgroundPaintProperty, binding);
public static T TooltipBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipBackgroundPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TooltipBackgroundPaintProperty, func, onChanged, expression);
public static T TooltipBackgroundPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TooltipTextPaintProperty, binding);
public static T TooltipTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TooltipTextPaintProperty, func, onChanged, expression);
public static T TooltipTextPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextSize<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.TooltipTextSizeProperty, binding);
public static T TooltipTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextSize<T>(this T control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.TooltipTextSizeProperty, func, onChanged, expression);
public static T TooltipTextSize<T>(this T control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);
public static T TooltipTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendPosition<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.LegendPositionProperty, binding);
public static T LegendPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendPosition<T>(this T control, Func<LegendPosition> func, Action<LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.LegendPositionProperty, func, onChanged, expression);
public static T LegendPosition<T>(this T control, LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);
public static T LegendPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.LegendBackgroundPaintProperty, binding);
public static T LegendBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendBackgroundPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.LegendBackgroundPaintProperty, func, onChanged, expression);
public static T LegendBackgroundPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextPaint<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.LegendTextPaintProperty, binding);
public static T LegendTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.LegendTextPaintProperty, func, onChanged, expression);
public static T LegendTextPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);
public static T LegendTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextSize<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.LegendTextSizeProperty, binding);
public static T LegendTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextSize<T>(this T control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.LegendTextSizeProperty, func, onChanged, expression);
public static T LegendTextSize<T>(this T control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);
public static T LegendTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.UpdateStartedCommandProperty, binding);
public static T UpdateStartedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UpdateStartedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.UpdateStartedCommandProperty, func, onChanged, expression);
public static T UpdateStartedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.PointerPressedCommandProperty, binding);
public static T PointerPressedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerPressedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.PointerPressedCommandProperty, func, onChanged, expression);
public static T PointerPressedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.PointerReleasedCommandProperty, binding);
public static T PointerReleasedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerReleasedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.PointerReleasedCommandProperty, func, onChanged, expression);
public static T PointerReleasedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.PointerMoveCommandProperty, binding);
public static T PointerMoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerMoveCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.PointerMoveCommandProperty, func, onChanged, expression);
public static T PointerMoveCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.DataPointerDownCommandProperty, binding);
public static T DataPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.DataPointerDownCommandProperty, func, onChanged, expression);
public static T DataPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, binding);
public static T ChartPointPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ChartPointPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);
public static T ChartPointPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T>(this T control, IBinding binding) where T : PolarChart
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, binding);
public static T VisualElementsPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PolarChart
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElementsPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PolarChart
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);
public static T VisualElementsPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PolarChart
=> control._setEx(PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

