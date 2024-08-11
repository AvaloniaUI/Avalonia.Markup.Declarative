#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.Kernel;
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
public static partial class PieChartExtensions
{
public static T DrawMargin<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.DrawMarginProperty, binding);
public static T DrawMargin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.DrawMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DrawMargin<T>(this T control, Func<Margin> func, Action<Margin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.DrawMarginProperty, func, onChanged, expression);
public static T DrawMargin<T>(this T control, Margin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.DrawMarginProperty, ps, () => control.DrawMargin = value, bindingMode, converter, bindingSource);
public static T DrawMargin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Margin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.DrawMarginProperty, ps, () => control.DrawMargin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SyncContext<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.SyncContextProperty, binding);
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SyncContext<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.SyncContextProperty, func, onChanged, expression);
public static T SyncContext<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Title<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.TitleProperty, binding);
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Title<T>(this T control, Func<VisualElement<SkiaSharpDrawingContext>> func, Action<VisualElement<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.TitleProperty, func, onChanged, expression);
public static T Title<T>(this T control, VisualElement<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VisualElement<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Series<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.SeriesProperty, binding);
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Series<T>(this T control, Func<IEnumerable<ISeries>> func, Action<IEnumerable<ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.SeriesProperty, func, onChanged, expression);
public static T Series<T>(this T control, IEnumerable<ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElements<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.VisualElementsProperty, binding);
public static T VisualElements<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElements<T>(this T control, Func<IEnumerable<ChartElement<SkiaSharpDrawingContext>>> func, Action<IEnumerable<ChartElement<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.VisualElementsProperty, func, onChanged, expression);
public static T VisualElements<T>(this T control, IEnumerable<ChartElement<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);
public static T VisualElements<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable<ChartElement<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsClockwise<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.IsClockwiseProperty, binding);
public static T IsClockwise<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.IsClockwiseProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsClockwise<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.IsClockwiseProperty, func, onChanged, expression);
public static T IsClockwise<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.IsClockwiseProperty, ps, () => control.IsClockwise = value, bindingMode, converter, bindingSource);
public static T IsClockwise<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.IsClockwiseProperty, ps, () => control.IsClockwise = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InitialRotation<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.InitialRotationProperty, binding);
public static T InitialRotation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.InitialRotationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InitialRotation<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.InitialRotationProperty, func, onChanged, expression);
public static T InitialRotation<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.InitialRotationProperty, ps, () => control.InitialRotation = value, bindingMode, converter, bindingSource);
public static T InitialRotation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.InitialRotationProperty, ps, () => control.InitialRotation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxAngle<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.MaxAngleProperty, binding);
public static T MaxAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.MaxAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxAngle<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.MaxAngleProperty, func, onChanged, expression);
public static T MaxAngle<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MaxAngleProperty, ps, () => control.MaxAngle = value, bindingMode, converter, bindingSource);
public static T MaxAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MaxAngleProperty, ps, () => control.MaxAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxValue<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.MaxValueProperty, binding);
public static T MaxValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.MaxValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxValue<T>(this T control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.MaxValueProperty, func, onChanged, expression);
public static T MaxValue<T>(this T control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MaxValueProperty, ps, () => control.MaxValue = value, bindingMode, converter, bindingSource);
public static T MaxValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MaxValueProperty, ps, () => control.MaxValue = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinValue<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.MinValueProperty, binding);
public static T MinValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.MinValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinValue<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.MinValueProperty, func, onChanged, expression);
public static T MinValue<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MinValueProperty, ps, () => control.MinValue = value, bindingMode, converter, bindingSource);
public static T MinValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.MinValueProperty, ps, () => control.MinValue = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.AnimationsSpeedProperty, binding);
public static T AnimationsSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AnimationsSpeed<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.AnimationsSpeedProperty, func, onChanged, expression);
public static T AnimationsSpeed<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T EasingFunction<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.EasingFunctionProperty, binding);
public static T EasingFunction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T EasingFunction<T>(this T control, Func<Func<Single,Single>> func, Action<Func<Single,Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.EasingFunctionProperty, func, onChanged, expression);
public static T EasingFunction<T>(this T control, Func<Single,Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);
public static T EasingFunction<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Func<Single,Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipPosition<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.TooltipPositionProperty, binding);
public static T TooltipPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipPosition<T>(this T control, Func<TooltipPosition> func, Action<TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.TooltipPositionProperty, func, onChanged, expression);
public static T TooltipPosition<T>(this T control, TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);
public static T TooltipPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.TooltipBackgroundPaintProperty, binding);
public static T TooltipBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipBackgroundPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.TooltipBackgroundPaintProperty, func, onChanged, expression);
public static T TooltipBackgroundPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.TooltipTextPaintProperty, binding);
public static T TooltipTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.TooltipTextPaintProperty, func, onChanged, expression);
public static T TooltipTextPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextSize<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.TooltipTextSizeProperty, binding);
public static T TooltipTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextSize<T>(this T control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.TooltipTextSizeProperty, func, onChanged, expression);
public static T TooltipTextSize<T>(this T control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);
public static T TooltipTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendPosition<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.LegendPositionProperty, binding);
public static T LegendPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendPosition<T>(this T control, Func<LegendPosition> func, Action<LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.LegendPositionProperty, func, onChanged, expression);
public static T LegendPosition<T>(this T control, LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);
public static T LegendPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.LegendBackgroundPaintProperty, binding);
public static T LegendBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendBackgroundPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.LegendBackgroundPaintProperty, func, onChanged, expression);
public static T LegendBackgroundPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextPaint<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.LegendTextPaintProperty, binding);
public static T LegendTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextPaint<T>(this T control, Func<IPaint<SkiaSharpDrawingContext>> func, Action<IPaint<SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.LegendTextPaintProperty, func, onChanged, expression);
public static T LegendTextPaint<T>(this T control, IPaint<SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);
public static T LegendTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPaint<SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextSize<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.LegendTextSizeProperty, binding);
public static T LegendTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextSize<T>(this T control, Func<Nullable<Double>> func, Action<Nullable<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.LegendTextSizeProperty, func, onChanged, expression);
public static T LegendTextSize<T>(this T control, Nullable<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);
public static T LegendTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.UpdateStartedCommandProperty, binding);
public static T UpdateStartedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UpdateStartedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.UpdateStartedCommandProperty, func, onChanged, expression);
public static T UpdateStartedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.PointerPressedCommandProperty, binding);
public static T PointerPressedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerPressedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.PointerPressedCommandProperty, func, onChanged, expression);
public static T PointerPressedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.PointerReleasedCommandProperty, binding);
public static T PointerReleasedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerReleasedCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.PointerReleasedCommandProperty, func, onChanged, expression);
public static T PointerReleasedCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.PointerMoveCommandProperty, binding);
public static T PointerMoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerMoveCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.PointerMoveCommandProperty, func, onChanged, expression);
public static T PointerMoveCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.DataPointerDownCommandProperty, binding);
public static T DataPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.DataPointerDownCommandProperty, func, onChanged, expression);
public static T DataPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.ChartPointPointerDownCommandProperty, binding);
public static T ChartPointPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ChartPointPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);
public static T ChartPointPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T>(this T control, IBinding binding) where T : PieChart
   => control._set(PieChart.VisualElementsPointerDownCommandProperty, binding);
public static T VisualElementsPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PieChart
   => control._set(PieChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElementsPointerDownCommand<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PieChart
   => control._set(PieChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);
public static T VisualElementsPointerDownCommand<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PieChart
=> control._setEx(PieChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

