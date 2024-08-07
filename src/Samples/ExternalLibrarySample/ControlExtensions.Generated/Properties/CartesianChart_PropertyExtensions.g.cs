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
public static partial class CartesianChartExtensions
{
public static CartesianChart DrawMargin(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.DrawMarginProperty, binding);
public static CartesianChart DrawMargin(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.DrawMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart DrawMargin(this CartesianChart control, Func<Margin> func, Action<Margin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.DrawMarginProperty, func, onChanged, expression);
public static CartesianChart DrawMargin(this CartesianChart control, Margin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DrawMarginProperty, ps, () => control.DrawMargin = value, bindingMode, converter, bindingSource);
public static CartesianChart DrawMargin<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Margin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DrawMarginProperty, ps, () => control.DrawMargin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart SyncContext(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.SyncContextProperty, binding);
public static CartesianChart SyncContext(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart SyncContext(this CartesianChart control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.SyncContextProperty, func, onChanged, expression);
public static CartesianChart SyncContext(this CartesianChart control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static CartesianChart SyncContext<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart Title(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TitleProperty, binding);
public static CartesianChart Title(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart Title(this CartesianChart control, Func<VisualElement<SkiaSharpDrawingContext>> func, Action<VisualElement<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TitleProperty, func, onChanged, expression);
public static CartesianChart Title(this CartesianChart control, VisualElement<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static CartesianChart Title<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, VisualElement<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart Series(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.SeriesProperty, binding);
public static CartesianChart Series(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart Series(this CartesianChart control, Func<IEnumerable<ISeries>> func, Action<IEnumerable<ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.SeriesProperty, func, onChanged, expression);
public static CartesianChart Series(this CartesianChart control, IEnumerable<ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static CartesianChart Series<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart XAxes(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.XAxesProperty, binding);
public static CartesianChart XAxes(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.XAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart XAxes(this CartesianChart control, Func<IEnumerable<ICartesianAxis>> func, Action<IEnumerable<ICartesianAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.XAxesProperty, func, onChanged, expression);
public static CartesianChart XAxes(this CartesianChart control, IEnumerable<ICartesianAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.XAxesProperty, ps, () => control.XAxes = value, bindingMode, converter, bindingSource);
public static CartesianChart XAxes<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ICartesianAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.XAxesProperty, ps, () => control.XAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart YAxes(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.YAxesProperty, binding);
public static CartesianChart YAxes(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.YAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart YAxes(this CartesianChart control, Func<IEnumerable<ICartesianAxis>> func, Action<IEnumerable<ICartesianAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.YAxesProperty, func, onChanged, expression);
public static CartesianChart YAxes(this CartesianChart control, IEnumerable<ICartesianAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.YAxesProperty, ps, () => control.YAxes = value, bindingMode, converter, bindingSource);
public static CartesianChart YAxes<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ICartesianAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.YAxesProperty, ps, () => control.YAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart Sections(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.SectionsProperty, binding);
public static CartesianChart Sections(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.SectionsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart Sections(this CartesianChart control, Func<IEnumerable<Section<SkiaSharpDrawingContext>>> func, Action<IEnumerable<Section<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.SectionsProperty, func, onChanged, expression);
public static CartesianChart Sections(this CartesianChart control, IEnumerable<Section<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SectionsProperty, ps, () => control.Sections = value, bindingMode, converter, bindingSource);
public static CartesianChart Sections<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IEnumerable<Section<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.SectionsProperty, ps, () => control.Sections = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart VisualElements(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.VisualElementsProperty, binding);
public static CartesianChart VisualElements(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart VisualElements(this CartesianChart control, Func<IEnumerable<ChartElement<SkiaSharpDrawingContext>>> func, Action<IEnumerable<ChartElement<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.VisualElementsProperty, func, onChanged, expression);
public static CartesianChart VisualElements(this CartesianChart control, IEnumerable<ChartElement<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);
public static CartesianChart VisualElements<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IEnumerable<ChartElement<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart DrawMarginFrame(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.DrawMarginFrameProperty, binding);
public static CartesianChart DrawMarginFrame(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.DrawMarginFrameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart DrawMarginFrame(this CartesianChart control, Func<DrawMarginFrame<SkiaSharpDrawingContext>> func, Action<DrawMarginFrame<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.DrawMarginFrameProperty, func, onChanged, expression);
public static CartesianChart DrawMarginFrame(this CartesianChart control, DrawMarginFrame<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DrawMarginFrameProperty, ps, () => control.DrawMarginFrame = value, bindingMode, converter, bindingSource);
public static CartesianChart DrawMarginFrame<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, DrawMarginFrame<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DrawMarginFrameProperty, ps, () => control.DrawMarginFrame = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart ZoomMode(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.ZoomModeProperty, binding);
public static CartesianChart ZoomMode(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.ZoomModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart ZoomMode(this CartesianChart control, Func<ZoomAndPanMode> func, Action<ZoomAndPanMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.ZoomModeProperty, func, onChanged, expression);
public static CartesianChart ZoomMode(this CartesianChart control, ZoomAndPanMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ZoomModeProperty, ps, () => control.ZoomMode = value, bindingMode, converter, bindingSource);
public static CartesianChart ZoomMode<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ZoomAndPanMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ZoomModeProperty, ps, () => control.ZoomMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart ZoomingSpeed(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.ZoomingSpeedProperty, binding);
public static CartesianChart ZoomingSpeed(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.ZoomingSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart ZoomingSpeed(this CartesianChart control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.ZoomingSpeedProperty, func, onChanged, expression);
public static CartesianChart ZoomingSpeed(this CartesianChart control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ZoomingSpeedProperty, ps, () => control.ZoomingSpeed = value, bindingMode, converter, bindingSource);
public static CartesianChart ZoomingSpeed<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ZoomingSpeedProperty, ps, () => control.ZoomingSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart AnimationsSpeed(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.AnimationsSpeedProperty, binding);
public static CartesianChart AnimationsSpeed(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart AnimationsSpeed(this CartesianChart control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.AnimationsSpeedProperty, func, onChanged, expression);
public static CartesianChart AnimationsSpeed(this CartesianChart control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);
public static CartesianChart AnimationsSpeed<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart EasingFunction(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.EasingFunctionProperty, binding);
public static CartesianChart EasingFunction(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart EasingFunction(this CartesianChart control, Func<Func<Single,Single>> func, Action<Func<Single,Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.EasingFunctionProperty, func, onChanged, expression);
public static CartesianChart EasingFunction(this CartesianChart control, Func<Single,Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);
public static CartesianChart EasingFunction<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Func<Single,Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart TooltipPosition(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TooltipPositionProperty, binding);
public static CartesianChart TooltipPosition(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart TooltipPosition(this CartesianChart control, Func<TooltipPosition> func, Action<TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TooltipPositionProperty, func, onChanged, expression);
public static CartesianChart TooltipPosition(this CartesianChart control, TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);
public static CartesianChart TooltipPosition<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart TooltipFindingStrategy(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TooltipFindingStrategyProperty, binding);
public static CartesianChart TooltipFindingStrategy(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TooltipFindingStrategyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart TooltipFindingStrategy(this CartesianChart control, Func<TooltipFindingStrategy> func, Action<TooltipFindingStrategy>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TooltipFindingStrategyProperty, func, onChanged, expression);
public static CartesianChart TooltipFindingStrategy(this CartesianChart control, TooltipFindingStrategy value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipFindingStrategyProperty, ps, () => control.TooltipFindingStrategy = value, bindingMode, converter, bindingSource);
public static CartesianChart TooltipFindingStrategy<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, TooltipFindingStrategy> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipFindingStrategyProperty, ps, () => control.TooltipFindingStrategy = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart TooltipBackgroundPaint(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TooltipBackgroundPaintProperty, binding);
public static CartesianChart TooltipBackgroundPaint(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart TooltipBackgroundPaint(this CartesianChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TooltipBackgroundPaintProperty, func, onChanged, expression);
public static CartesianChart TooltipBackgroundPaint(this CartesianChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);
public static CartesianChart TooltipBackgroundPaint<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart TooltipTextPaint(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TooltipTextPaintProperty, binding);
public static CartesianChart TooltipTextPaint(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart TooltipTextPaint(this CartesianChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TooltipTextPaintProperty, func, onChanged, expression);
public static CartesianChart TooltipTextPaint(this CartesianChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);
public static CartesianChart TooltipTextPaint<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart TooltipTextSize(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.TooltipTextSizeProperty, binding);
public static CartesianChart TooltipTextSize(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart TooltipTextSize(this CartesianChart control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.TooltipTextSizeProperty, func, onChanged, expression);
public static CartesianChart TooltipTextSize(this CartesianChart control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);
public static CartesianChart TooltipTextSize<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart LegendPosition(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.LegendPositionProperty, binding);
public static CartesianChart LegendPosition(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart LegendPosition(this CartesianChart control, Func<LegendPosition> func, Action<LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.LegendPositionProperty, func, onChanged, expression);
public static CartesianChart LegendPosition(this CartesianChart control, LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);
public static CartesianChart LegendPosition<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart LegendBackgroundPaint(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.LegendBackgroundPaintProperty, binding);
public static CartesianChart LegendBackgroundPaint(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart LegendBackgroundPaint(this CartesianChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.LegendBackgroundPaintProperty, func, onChanged, expression);
public static CartesianChart LegendBackgroundPaint(this CartesianChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);
public static CartesianChart LegendBackgroundPaint<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart LegendTextPaint(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.LegendTextPaintProperty, binding);
public static CartesianChart LegendTextPaint(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart LegendTextPaint(this CartesianChart control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.LegendTextPaintProperty, func, onChanged, expression);
public static CartesianChart LegendTextPaint(this CartesianChart control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);
public static CartesianChart LegendTextPaint<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart LegendTextSize(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.LegendTextSizeProperty, binding);
public static CartesianChart LegendTextSize(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart LegendTextSize(this CartesianChart control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.LegendTextSizeProperty, func, onChanged, expression);
public static CartesianChart LegendTextSize(this CartesianChart control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);
public static CartesianChart LegendTextSize<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart UpdateStartedCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.UpdateStartedCommandProperty, binding);
public static CartesianChart UpdateStartedCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart UpdateStartedCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.UpdateStartedCommandProperty, func, onChanged, expression);
public static CartesianChart UpdateStartedCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart UpdateStartedCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart PointerPressedCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.PointerPressedCommandProperty, binding);
public static CartesianChart PointerPressedCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart PointerPressedCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.PointerPressedCommandProperty, func, onChanged, expression);
public static CartesianChart PointerPressedCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart PointerPressedCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart PointerReleasedCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.PointerReleasedCommandProperty, binding);
public static CartesianChart PointerReleasedCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart PointerReleasedCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.PointerReleasedCommandProperty, func, onChanged, expression);
public static CartesianChart PointerReleasedCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart PointerReleasedCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart PointerMoveCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.PointerMoveCommandProperty, binding);
public static CartesianChart PointerMoveCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart PointerMoveCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.PointerMoveCommandProperty, func, onChanged, expression);
public static CartesianChart PointerMoveCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart PointerMoveCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart DataPointerDownCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.DataPointerDownCommandProperty, binding);
public static CartesianChart DataPointerDownCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart DataPointerDownCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.DataPointerDownCommandProperty, func, onChanged, expression);
public static CartesianChart DataPointerDownCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart DataPointerDownCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart ChartPointPointerDownCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.ChartPointPointerDownCommandProperty, binding);
public static CartesianChart ChartPointPointerDownCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart ChartPointPointerDownCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);
public static CartesianChart ChartPointPointerDownCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart ChartPointPointerDownCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CartesianChart VisualElementsPointerDownCommand(this CartesianChart control, IBinding binding)
   => control._set(CartesianChart.VisualElementsPointerDownCommandProperty, binding);
public static CartesianChart VisualElementsPointerDownCommand(this CartesianChart control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CartesianChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CartesianChart VisualElementsPointerDownCommand(this CartesianChart control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CartesianChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);
public static CartesianChart VisualElementsPointerDownCommand(this CartesianChart control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);
public static CartesianChart VisualElementsPointerDownCommand<TValue>(this CartesianChart control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CartesianChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

