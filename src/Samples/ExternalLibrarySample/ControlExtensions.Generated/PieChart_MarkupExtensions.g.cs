#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class PieChart_MarkupExtensions
{
//================= Properties ======================//
 // DrawMarginProperty

/*BindFromExpressionSetterGenerator*/
public static T DrawMargin<T>(this T control, Func<LiveChartsCore.Measure.Margin> func, Action<LiveChartsCore.Measure.Margin>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DrawMarginProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DrawMargin<T>(this T control, LiveChartsCore.Measure.Margin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DrawMarginProperty, ps, () => control.DrawMargin = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DrawMargin<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DrawMarginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DrawMargin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DrawMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DrawMargin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.Margin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DrawMarginProperty, ps, () => control.DrawMargin = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SyncContextProperty

/*BindFromExpressionSetterGenerator*/
public static T SyncContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SyncContextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SyncContext<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SyncContextProperty, ps, () => control.SyncContext = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SyncContext<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SyncContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SyncContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TitleProperty

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TitleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Title<T>(this T control, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SeriesProperty

/*BindFromExpressionSetterGenerator*/
public static T Series<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SeriesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Series<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SeriesProperty, ps, () => control.Series = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Series<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SeriesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Series<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VisualElementsProperty

/*BindFromExpressionSetterGenerator*/
public static T VisualElements<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VisualElements<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsProperty, ps, () => control.VisualElements = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VisualElements<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VisualElements<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VisualElements<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsClockwiseProperty

/*BindFromExpressionSetterGenerator*/
public static T IsClockwise<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.IsClockwiseProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsClockwise<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.IsClockwiseProperty, ps, () => control.IsClockwise = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClockwise<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.IsClockwiseProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClockwise<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.IsClockwiseProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsClockwise<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.IsClockwiseProperty, ps, () => control.IsClockwise = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InitialRotationProperty

/*BindFromExpressionSetterGenerator*/
public static T InitialRotation<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.InitialRotationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InitialRotation<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.InitialRotationProperty, ps, () => control.InitialRotation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InitialRotation<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.InitialRotationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InitialRotation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.InitialRotationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InitialRotation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.InitialRotationProperty, ps, () => control.InitialRotation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxAngleProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxAngleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxAngle<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxAngleProperty, ps, () => control.MaxAngle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxAngle<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxAngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxAngleProperty, ps, () => control.MaxAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxValueProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxValue<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxValue<T>(this T control, System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxValueProperty, ps, () => control.MaxValue = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxValue<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MaxValueProperty, ps, () => control.MaxValue = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinValueProperty

/*BindFromExpressionSetterGenerator*/
public static T MinValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MinValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinValue<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MinValueProperty, ps, () => control.MinValue = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinValue<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MinValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MinValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.MinValueProperty, ps, () => control.MinValue = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AnimationsSpeedProperty

/*BindFromExpressionSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.AnimationsSpeedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.AnimationsSpeedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AnimationsSpeed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // EasingFunctionProperty

/*BindFromExpressionSetterGenerator*/
public static T EasingFunction<T>(this T control, Func<System.Func<System.Single,System.Single>> func, Action<System.Func<System.Single,System.Single>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.EasingFunctionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T EasingFunction<T>(this T control, System.Func<System.Single,System.Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.EasingFunctionProperty, ps, () => control.EasingFunction = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EasingFunction<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.EasingFunctionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EasingFunction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T EasingFunction<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Func<System.Single,System.Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TooltipPositionProperty

/*BindFromExpressionSetterGenerator*/
public static T TooltipPosition<T>(this T control, Func<LiveChartsCore.Measure.TooltipPosition> func, Action<LiveChartsCore.Measure.TooltipPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipPositionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TooltipPosition<T>(this T control, LiveChartsCore.Measure.TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TooltipPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TooltipBackgroundPaintProperty

/*BindFromExpressionSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipBackgroundPaintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipBackgroundPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TooltipBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TooltipTextPaintProperty

/*BindFromExpressionSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextPaintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TooltipTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TooltipTextSizeProperty

/*BindFromExpressionSetterGenerator*/
public static T TooltipTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TooltipTextSize<T>(this T control, System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TooltipTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LegendPositionProperty

/*BindFromExpressionSetterGenerator*/
public static T LegendPosition<T>(this T control, Func<LiveChartsCore.Measure.LegendPosition> func, Action<LiveChartsCore.Measure.LegendPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendPositionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LegendPosition<T>(this T control, LiveChartsCore.Measure.LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendPositionProperty, ps, () => control.LegendPosition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LegendPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LegendBackgroundPaintProperty

/*BindFromExpressionSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendBackgroundPaintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendBackgroundPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LegendBackgroundPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LegendTextPaintProperty

/*BindFromExpressionSetterGenerator*/
public static T LegendTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextPaintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LegendTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LegendTextPaint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LegendTextSizeProperty

/*BindFromExpressionSetterGenerator*/
public static T LegendTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LegendTextSize<T>(this T control, System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LegendTextSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UpdateStartedCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.UpdateStartedCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.UpdateStartedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UpdateStartedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PointerPressedCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerPressedCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerPressedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PointerPressedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PointerReleasedCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerReleasedCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerReleasedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PointerReleasedCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PointerMoveCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerMoveCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerMoveCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PointerMoveCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DataPointerDownCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DataPointerDownCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DataPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DataPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ChartPointPointerDownCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.ChartPointPointerDownCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.ChartPointPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ChartPointPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VisualElementsPointerDownCommandProperty

/*BindFromExpressionSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsPointerDownCommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VisualElementsPointerDownCommand<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.PieChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Measuring

/*ActionToEventGenerator*/
    public static T OnMeasuring<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.Measuring += h);


 // UpdateStarted

/*ActionToEventGenerator*/
    public static T OnUpdateStarted<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateStarted += h);


 // UpdateFinished

/*ActionToEventGenerator*/
    public static T OnUpdateFinished<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateFinished += h);


 // DataPointerDown

/*ActionToEventGenerator*/
    public static T OnDataPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartPoint>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.ChartPointsHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.DataPointerDown += h);


 // ChartPointPointerDown

/*ActionToEventGenerator*/
    public static T OnChartPointPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, LiveChartsCore.Kernel.ChartPoint> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.ChartPointHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.ChartPointPointerDown += h);


 // VisualElementsPointerDown

/*ActionToEventGenerator*/
    public static T OnVisualElementsPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, LiveChartsCore.Kernel.Events.VisualElementsEventArgs<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.PieChart => 
        control._setEvent((LiveChartsCore.Kernel.Events.VisualElementsHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0, arg1) => action(arg0, arg1)), h => control.VisualElementsPointerDown += h);



//================= Styles ======================//

}
