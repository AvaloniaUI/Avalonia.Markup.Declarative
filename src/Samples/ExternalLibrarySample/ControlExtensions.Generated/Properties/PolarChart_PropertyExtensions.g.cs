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
public static PolarChart SyncContext(this PolarChart control, IBinding binding)
   => control._set(PolarChart.SyncContextProperty, binding);
public static PolarChart SyncContext(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart SyncContext(this PolarChart control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.SyncContextProperty, func, onChanged, expression);
public static PolarChart SyncContext(this PolarChart control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static PolarChart SyncContext<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart Title(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TitleProperty, binding);
public static PolarChart Title(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart Title(this PolarChart control, Func<VisualElement<SkiaSharpDrawingContext>> func, Action<VisualElement<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TitleProperty, func, onChanged, expression);
public static PolarChart Title(this PolarChart control, VisualElement<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static PolarChart Title<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, VisualElement<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart Series(this PolarChart control, IBinding binding)
   => control._set(PolarChart.SeriesProperty, binding);
public static PolarChart Series(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart Series(this PolarChart control, Func<IEnumerable<ISeries>> func, Action<IEnumerable<ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.SeriesProperty, func, onChanged, expression);
public static PolarChart Series(this PolarChart control, IEnumerable<ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static PolarChart Series<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart VisualElements(this PolarChart control, IBinding binding)
   => control._set(PolarChart.VisualElementsProperty, binding);
public static PolarChart VisualElements(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart VisualElements(this PolarChart control, Func<IEnumerable<ChartElement<SkiaSharpDrawingContext>>> func, Action<IEnumerable<ChartElement<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.VisualElementsProperty, func, onChanged, expression);
public static PolarChart VisualElements(this PolarChart control, IEnumerable<ChartElement<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);
public static PolarChart VisualElements<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ChartElement<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart FitToBounds(this PolarChart control, IBinding binding)
   => control._set(PolarChart.FitToBoundsProperty, binding);
public static PolarChart FitToBounds(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.FitToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart FitToBounds(this PolarChart control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.FitToBoundsProperty, func, onChanged, expression);
public static PolarChart FitToBounds(this PolarChart control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = value, bindingMode, converter, bindingSource);
public static PolarChart FitToBounds<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart TotalAngle(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TotalAngleProperty, binding);
public static PolarChart TotalAngle(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TotalAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart TotalAngle(this PolarChart control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TotalAngleProperty, func, onChanged, expression);
public static PolarChart TotalAngle(this PolarChart control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = value, bindingMode, converter, bindingSource);
public static PolarChart TotalAngle<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart InnerRadius(this PolarChart control, IBinding binding)
   => control._set(PolarChart.InnerRadiusProperty, binding);
public static PolarChart InnerRadius(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.InnerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart InnerRadius(this PolarChart control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.InnerRadiusProperty, func, onChanged, expression);
public static PolarChart InnerRadius(this PolarChart control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = value, bindingMode, converter, bindingSource);
public static PolarChart InnerRadius<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart InitialRotation(this PolarChart control, IBinding binding)
   => control._set(PolarChart.InitialRotationProperty, binding);
public static PolarChart InitialRotation(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.InitialRotationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart InitialRotation(this PolarChart control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.InitialRotationProperty, func, onChanged, expression);
public static PolarChart InitialRotation(this PolarChart control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = value, bindingMode, converter, bindingSource);
public static PolarChart InitialRotation<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart AngleAxes(this PolarChart control, IBinding binding)
   => control._set(PolarChart.AngleAxesProperty, binding);
public static PolarChart AngleAxes(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.AngleAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart AngleAxes(this PolarChart control, Func<IEnumerable<IPolarAxis>> func, Action<IEnumerable<IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.AngleAxesProperty, func, onChanged, expression);
public static PolarChart AngleAxes(this PolarChart control, IEnumerable<IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = value, bindingMode, converter, bindingSource);
public static PolarChart AngleAxes<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IEnumerable<IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart RadiusAxes(this PolarChart control, IBinding binding)
   => control._set(PolarChart.RadiusAxesProperty, binding);
public static PolarChart RadiusAxes(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.RadiusAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart RadiusAxes(this PolarChart control, Func<IEnumerable<IPolarAxis>> func, Action<IEnumerable<IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.RadiusAxesProperty, func, onChanged, expression);
public static PolarChart RadiusAxes(this PolarChart control, IEnumerable<IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = value, bindingMode, converter, bindingSource);
public static PolarChart RadiusAxes<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IEnumerable<IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart AnimationsSpeed(this PolarChart control, IBinding binding)
   => control._set(PolarChart.AnimationsSpeedProperty, binding);
public static PolarChart AnimationsSpeed(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart AnimationsSpeed(this PolarChart control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.AnimationsSpeedProperty, func, onChanged, expression);
public static PolarChart AnimationsSpeed(this PolarChart control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);
public static PolarChart AnimationsSpeed<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart EasingFunction(this PolarChart control, IBinding binding)
   => control._set(PolarChart.EasingFunctionProperty, binding);
public static PolarChart EasingFunction(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart EasingFunction(this PolarChart control, Func<Func<Single,Single>> func, Action<Func<Single,Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.EasingFunctionProperty, func, onChanged, expression);
public static PolarChart EasingFunction(this PolarChart control, Func<Single,Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);
public static PolarChart EasingFunction<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Func<Single,Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart TooltipPosition(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TooltipPositionProperty, binding);
public static PolarChart TooltipPosition(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart TooltipPosition(this PolarChart control, Func<TooltipPosition> func, Action<TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TooltipPositionProperty, func, onChanged, expression);
public static PolarChart TooltipPosition(this PolarChart control, TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);
public static PolarChart TooltipPosition<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart TooltipBackgroundPaint(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TooltipBackgroundPaintProperty, binding);
public static PolarChart TooltipBackgroundPaint(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart TooltipBackgroundPaint(this PolarChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TooltipBackgroundPaintProperty, func, onChanged, expression);
public static PolarChart TooltipBackgroundPaint(this PolarChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);
public static PolarChart TooltipBackgroundPaint<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart TooltipTextPaint(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TooltipTextPaintProperty, binding);
public static PolarChart TooltipTextPaint(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart TooltipTextPaint(this PolarChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TooltipTextPaintProperty, func, onChanged, expression);
public static PolarChart TooltipTextPaint(this PolarChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);
public static PolarChart TooltipTextPaint<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart TooltipTextSize(this PolarChart control, IBinding binding)
   => control._set(PolarChart.TooltipTextSizeProperty, binding);
public static PolarChart TooltipTextSize(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart TooltipTextSize(this PolarChart control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.TooltipTextSizeProperty, func, onChanged, expression);
public static PolarChart TooltipTextSize(this PolarChart control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);
public static PolarChart TooltipTextSize<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart LegendPosition(this PolarChart control, IBinding binding)
   => control._set(PolarChart.LegendPositionProperty, binding);
public static PolarChart LegendPosition(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart LegendPosition(this PolarChart control, Func<LegendPosition> func, Action<LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.LegendPositionProperty, func, onChanged, expression);
public static PolarChart LegendPosition(this PolarChart control, LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);
public static PolarChart LegendPosition<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart LegendBackgroundPaint(this PolarChart control, IBinding binding)
   => control._set(PolarChart.LegendBackgroundPaintProperty, binding);
public static PolarChart LegendBackgroundPaint(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart LegendBackgroundPaint(this PolarChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.LegendBackgroundPaintProperty, func, onChanged, expression);
public static PolarChart LegendBackgroundPaint(this PolarChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);
public static PolarChart LegendBackgroundPaint<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart LegendTextPaint(this PolarChart control, IBinding binding)
   => control._set(PolarChart.LegendTextPaintProperty, binding);
public static PolarChart LegendTextPaint(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart LegendTextPaint(this PolarChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.LegendTextPaintProperty, func, onChanged, expression);
public static PolarChart LegendTextPaint(this PolarChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);
public static PolarChart LegendTextPaint<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart LegendTextSize(this PolarChart control, IBinding binding)
   => control._set(PolarChart.LegendTextSizeProperty, binding);
public static PolarChart LegendTextSize(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart LegendTextSize(this PolarChart control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.LegendTextSizeProperty, func, onChanged, expression);
public static PolarChart LegendTextSize(this PolarChart control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);
public static PolarChart LegendTextSize<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart UpdateStartedCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.UpdateStartedCommandProperty, binding);
public static PolarChart UpdateStartedCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart UpdateStartedCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.UpdateStartedCommandProperty, func, onChanged, expression);
public static PolarChart UpdateStartedCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);
public static PolarChart UpdateStartedCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart PointerPressedCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.PointerPressedCommandProperty, binding);
public static PolarChart PointerPressedCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart PointerPressedCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.PointerPressedCommandProperty, func, onChanged, expression);
public static PolarChart PointerPressedCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);
public static PolarChart PointerPressedCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart PointerReleasedCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.PointerReleasedCommandProperty, binding);
public static PolarChart PointerReleasedCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart PointerReleasedCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.PointerReleasedCommandProperty, func, onChanged, expression);
public static PolarChart PointerReleasedCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);
public static PolarChart PointerReleasedCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart PointerMoveCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.PointerMoveCommandProperty, binding);
public static PolarChart PointerMoveCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart PointerMoveCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.PointerMoveCommandProperty, func, onChanged, expression);
public static PolarChart PointerMoveCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);
public static PolarChart PointerMoveCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart DataPointerDownCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.DataPointerDownCommandProperty, binding);
public static PolarChart DataPointerDownCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart DataPointerDownCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.DataPointerDownCommandProperty, func, onChanged, expression);
public static PolarChart DataPointerDownCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);
public static PolarChart DataPointerDownCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart ChartPointPointerDownCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, binding);
public static PolarChart ChartPointPointerDownCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart ChartPointPointerDownCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);
public static PolarChart ChartPointPointerDownCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);
public static PolarChart ChartPointPointerDownCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolarChart VisualElementsPointerDownCommand(this PolarChart control, IBinding binding)
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, binding);
public static PolarChart VisualElementsPointerDownCommand(this PolarChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PolarChart VisualElementsPointerDownCommand(this PolarChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolarChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);
public static PolarChart VisualElementsPointerDownCommand(this PolarChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);
public static PolarChart VisualElementsPointerDownCommand<TValue>(this PolarChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

