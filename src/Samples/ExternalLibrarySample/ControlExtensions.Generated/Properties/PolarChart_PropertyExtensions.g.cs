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
using PolarChart = LiveChartsCore.SkiaSharpView.Avalonia.PolarChart;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class PolarChartExtensions
{
public static T SyncContext<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SyncContextProperty, binding);
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SyncContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SyncContextProperty, func, onChanged, expression);
public static T SyncContext<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Title<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TitleProperty, binding);
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Title<T>(this T control, Func<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TitleProperty, func, onChanged, expression);
public static T Title<T>(this T control, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Series<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SeriesProperty, binding);
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Series<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SeriesProperty, func, onChanged, expression);
public static T Series<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElements<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsProperty, binding);
public static T VisualElements<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElements<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsProperty, func, onChanged, expression);
public static T VisualElements<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);
public static T VisualElements<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FitToBounds<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.FitToBoundsProperty, binding);
public static T FitToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.FitToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FitToBounds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.FitToBoundsProperty, func, onChanged, expression);
public static T FitToBounds<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = value, bindingMode, converter, bindingSource);
public static T FitToBounds<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.FitToBoundsProperty, ps, () => control.FitToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TotalAngle<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TotalAngleProperty, binding);
public static T TotalAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TotalAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TotalAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TotalAngleProperty, func, onChanged, expression);
public static T TotalAngle<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = value, bindingMode, converter, bindingSource);
public static T TotalAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TotalAngleProperty, ps, () => control.TotalAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRadius<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InnerRadiusProperty, binding);
public static T InnerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InnerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRadius<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InnerRadiusProperty, func, onChanged, expression);
public static T InnerRadius<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = value, bindingMode, converter, bindingSource);
public static T InnerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InnerRadiusProperty, ps, () => control.InnerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InitialRotation<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InitialRotationProperty, binding);
public static T InitialRotation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InitialRotationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InitialRotation<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InitialRotationProperty, func, onChanged, expression);
public static T InitialRotation<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = value, bindingMode, converter, bindingSource);
public static T InitialRotation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.InitialRotationProperty, ps, () => control.InitialRotation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AngleAxes<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AngleAxesProperty, binding);
public static T AngleAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AngleAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AngleAxes<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AngleAxesProperty, func, onChanged, expression);
public static T AngleAxes<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = value, bindingMode, converter, bindingSource);
public static T AngleAxes<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AngleAxesProperty, ps, () => control.AngleAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RadiusAxes<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.RadiusAxesProperty, binding);
public static T RadiusAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.RadiusAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusAxes<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.RadiusAxesProperty, func, onChanged, expression);
public static T RadiusAxes<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = value, bindingMode, converter, bindingSource);
public static T RadiusAxes<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.IPolarAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.RadiusAxesProperty, ps, () => control.RadiusAxes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AnimationsSpeedProperty, binding);
public static T AnimationsSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AnimationsSpeed<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AnimationsSpeedProperty, func, onChanged, expression);
public static T AnimationsSpeed<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);
public static T AnimationsSpeed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T EasingFunction<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.EasingFunctionProperty, binding);
public static T EasingFunction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T EasingFunction<T>(this T control, Func<System.Func<System.Single,System.Single>> func, Action<System.Func<System.Single,System.Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.EasingFunctionProperty, func, onChanged, expression);
public static T EasingFunction<T>(this T control, System.Func<System.Single,System.Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);
public static T EasingFunction<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Func<System.Single,System.Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipPositionProperty, binding);
public static T TooltipPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipPosition<T>(this T control, Func<LiveChartsCore.Measure.TooltipPosition> func, Action<LiveChartsCore.Measure.TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipPositionProperty, func, onChanged, expression);
public static T TooltipPosition<T>(this T control, LiveChartsCore.Measure.TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);
public static T TooltipPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipBackgroundPaintProperty, binding);
public static T TooltipBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipBackgroundPaintProperty, func, onChanged, expression);
public static T TooltipBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T TooltipBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextPaintProperty, binding);
public static T TooltipTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextPaintProperty, func, onChanged, expression);
public static T TooltipTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);
public static T TooltipTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TooltipTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextSizeProperty, binding);
public static T TooltipTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TooltipTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextSizeProperty, func, onChanged, expression);
public static T TooltipTextSize<T>(this T control, System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);
public static T TooltipTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendPositionProperty, binding);
public static T LegendPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendPosition<T>(this T control, Func<LiveChartsCore.Measure.LegendPosition> func, Action<LiveChartsCore.Measure.LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendPositionProperty, func, onChanged, expression);
public static T LegendPosition<T>(this T control, LiveChartsCore.Measure.LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);
public static T LegendPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendBackgroundPaintProperty, binding);
public static T LegendBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendBackgroundPaintProperty, func, onChanged, expression);
public static T LegendBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);
public static T LegendBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextPaintProperty, binding);
public static T LegendTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextPaintProperty, func, onChanged, expression);
public static T LegendTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);
public static T LegendTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LegendTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextSizeProperty, binding);
public static T LegendTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LegendTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextSizeProperty, func, onChanged, expression);
public static T LegendTextSize<T>(this T control, System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);
public static T LegendTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.UpdateStartedCommandProperty, binding);
public static T UpdateStartedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UpdateStartedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.UpdateStartedCommandProperty, func, onChanged, expression);
public static T UpdateStartedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);
public static T UpdateStartedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerPressedCommandProperty, binding);
public static T PointerPressedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerPressedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerPressedCommandProperty, func, onChanged, expression);
public static T PointerPressedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);
public static T PointerPressedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerReleasedCommandProperty, binding);
public static T PointerReleasedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerReleasedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerReleasedCommandProperty, func, onChanged, expression);
public static T PointerReleasedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);
public static T PointerReleasedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerMoveCommandProperty, binding);
public static T PointerMoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PointerMoveCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerMoveCommandProperty, func, onChanged, expression);
public static T PointerMoveCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);
public static T PointerMoveCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.DataPointerDownCommandProperty, binding);
public static T DataPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.DataPointerDownCommandProperty, func, onChanged, expression);
public static T DataPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T DataPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.ChartPointPointerDownCommandProperty, binding);
public static T ChartPointPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ChartPointPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);
public static T ChartPointPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T ChartPointPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsPointerDownCommandProperty, binding);
public static T VisualElementsPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VisualElementsPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);
public static T VisualElementsPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);
public static T VisualElementsPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PolarChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PolarChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

