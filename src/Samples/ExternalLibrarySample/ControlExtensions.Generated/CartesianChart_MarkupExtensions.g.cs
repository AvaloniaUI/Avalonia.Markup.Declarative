#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class CartesianChart_MarkupExtensions
{
//================= Properties ======================//
 // DrawMargin

/*ValueSetterGenerator*/
public static T DrawMargin<T>(this T control, LiveChartsCore.Measure.Margin value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.DrawMargin = value!);

/*BindFromExpressionSetterGenerator*/
public static T DrawMargin<T>(this T control, Func<LiveChartsCore.Measure.Margin> func, Action<LiveChartsCore.Measure.Margin>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DrawMargin<T>(this T control,LiveChartsCore.Measure.Margin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginProperty, ps, () => control.DrawMargin = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DrawMargin<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DrawMargin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DrawMargin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.Margin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginProperty, ps, () => control.DrawMargin = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SyncContext

/*ValueSetterGenerator*/
public static T SyncContext<T>(this T control, System.Object value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.SyncContext = value!);

/*BindFromExpressionSetterGenerator*/
public static T SyncContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SyncContextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SyncContext<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SyncContextProperty, ps, () => control.SyncContext = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SyncContext<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SyncContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SyncContext<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.VisualElements.VisualElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Series

/*ValueSetterGenerator*/
public static T Series<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.Series = value!);

/*BindFromExpressionSetterGenerator*/
public static T Series<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SeriesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Series<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SeriesProperty, ps, () => control.Series = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Series<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SeriesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Series<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.ISeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SeriesProperty, ps, () => control.Series = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // XAxes

/*ValueSetterGenerator*/
public static T XAxes<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.XAxes = value!);

/*BindFromExpressionSetterGenerator*/
public static T XAxes<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.XAxesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T XAxes<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.XAxesProperty, ps, () => control.XAxes = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T XAxes<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.XAxesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T XAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.XAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T XAxes<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.XAxesProperty, ps, () => control.XAxes = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // YAxes

/*ValueSetterGenerator*/
public static T YAxes<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.YAxes = value!);

/*BindFromExpressionSetterGenerator*/
public static T YAxes<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.YAxesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T YAxes<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.YAxesProperty, ps, () => control.YAxes = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YAxes<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.YAxesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YAxes<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.YAxesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T YAxes<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.Sketches.ICartesianAxis>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.YAxesProperty, ps, () => control.YAxes = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Sections

/*ValueSetterGenerator*/
public static T Sections<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Section<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.Sections = value!);

/*BindFromExpressionSetterGenerator*/
public static T Sections<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Section<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Section<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SectionsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Sections<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.Section<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SectionsProperty, ps, () => control.Sections = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Sections<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SectionsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Sections<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SectionsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Sections<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Section<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.SectionsProperty, ps, () => control.Sections = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VisualElements

/*ValueSetterGenerator*/
public static T VisualElements<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.VisualElements = value!);

/*BindFromExpressionSetterGenerator*/
public static T VisualElements<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VisualElements<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsProperty, ps, () => control.VisualElements = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VisualElements<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VisualElements<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VisualElements<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartElement<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsProperty, ps, () => control.VisualElements = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DrawMarginFrame

/*ValueSetterGenerator*/
public static T DrawMarginFrame<T>(this T control, LiveChartsCore.DrawMarginFrame<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.DrawMarginFrame = value!);

/*BindFromExpressionSetterGenerator*/
public static T DrawMarginFrame<T>(this T control, Func<LiveChartsCore.DrawMarginFrame<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.DrawMarginFrame<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginFrameProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DrawMarginFrame<T>(this T control,LiveChartsCore.DrawMarginFrame<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginFrameProperty, ps, () => control.DrawMarginFrame = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DrawMarginFrame<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginFrameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DrawMarginFrame<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginFrameProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DrawMarginFrame<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.DrawMarginFrame<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DrawMarginFrameProperty, ps, () => control.DrawMarginFrame = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ZoomMode

/*ValueSetterGenerator*/
public static T ZoomMode<T>(this T control, LiveChartsCore.Measure.ZoomAndPanMode value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.ZoomMode = value!);

/*BindFromExpressionSetterGenerator*/
public static T ZoomMode<T>(this T control, Func<LiveChartsCore.Measure.ZoomAndPanMode> func, Action<LiveChartsCore.Measure.ZoomAndPanMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ZoomMode<T>(this T control,LiveChartsCore.Measure.ZoomAndPanMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomModeProperty, ps, () => control.ZoomMode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ZoomMode<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ZoomMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ZoomMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.ZoomAndPanMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomModeProperty, ps, () => control.ZoomMode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ZoomingSpeed

/*ValueSetterGenerator*/
public static T ZoomingSpeed<T>(this T control, System.Double value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.ZoomingSpeed = value!);

/*BindFromExpressionSetterGenerator*/
public static T ZoomingSpeed<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomingSpeedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ZoomingSpeed<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomingSpeedProperty, ps, () => control.ZoomingSpeed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ZoomingSpeed<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomingSpeedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ZoomingSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomingSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ZoomingSpeed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ZoomingSpeedProperty, ps, () => control.ZoomingSpeed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AnimationsSpeed

/*ValueSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, System.TimeSpan value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.AnimationsSpeed = value!);

/*BindFromExpressionSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.AnimationsSpeedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AnimationsSpeed<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.AnimationsSpeedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AnimationsSpeed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.AnimationsSpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AnimationsSpeed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.AnimationsSpeedProperty, ps, () => control.AnimationsSpeed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // EasingFunction

/*ValueSetterGenerator*/
public static T EasingFunction<T>(this T control, System.Func<System.Single,System.Single> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.EasingFunction = value!);

/*BindFromExpressionSetterGenerator*/
public static T EasingFunction<T>(this T control, Func<System.Func<System.Single,System.Single>> func, Action<System.Func<System.Single,System.Single>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.EasingFunctionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T EasingFunction<T>(this T control,System.Func<System.Single,System.Single> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.EasingFunctionProperty, ps, () => control.EasingFunction = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EasingFunction<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.EasingFunctionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EasingFunction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.EasingFunctionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T EasingFunction<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Func<System.Single,System.Single>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.EasingFunctionProperty, ps, () => control.EasingFunction = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TooltipPosition

/*ValueSetterGenerator*/
public static T TooltipPosition<T>(this T control, LiveChartsCore.Measure.TooltipPosition value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.TooltipPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T TooltipPosition<T>(this T control, Func<LiveChartsCore.Measure.TooltipPosition> func, Action<LiveChartsCore.Measure.TooltipPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TooltipPosition<T>(this T control,LiveChartsCore.Measure.TooltipPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipPositionProperty, ps, () => control.TooltipPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TooltipPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.TooltipPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipPositionProperty, ps, () => control.TooltipPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TooltipFindingStrategy

/*ValueSetterGenerator*/
public static T TooltipFindingStrategy<T>(this T control, LiveChartsCore.Measure.TooltipFindingStrategy value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.TooltipFindingStrategy = value!);

/*BindFromExpressionSetterGenerator*/
public static T TooltipFindingStrategy<T>(this T control, Func<LiveChartsCore.Measure.TooltipFindingStrategy> func, Action<LiveChartsCore.Measure.TooltipFindingStrategy>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipFindingStrategyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TooltipFindingStrategy<T>(this T control,LiveChartsCore.Measure.TooltipFindingStrategy value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipFindingStrategyProperty, ps, () => control.TooltipFindingStrategy = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipFindingStrategy<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipFindingStrategyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipFindingStrategy<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipFindingStrategyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TooltipFindingStrategy<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.TooltipFindingStrategy> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipFindingStrategyProperty, ps, () => control.TooltipFindingStrategy = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TooltipBackgroundPaint

/*ValueSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.TooltipBackgroundPaint = value!);

/*BindFromExpressionSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipBackgroundPaintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TooltipBackgroundPaint<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipBackgroundPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TooltipBackgroundPaint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipBackgroundPaintProperty, ps, () => control.TooltipBackgroundPaint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TooltipTextPaint

/*ValueSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.TooltipTextPaint = value!);

/*BindFromExpressionSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextPaintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TooltipTextPaint<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TooltipTextPaint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextPaintProperty, ps, () => control.TooltipTextPaint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TooltipTextSize

/*ValueSetterGenerator*/
public static T TooltipTextSize<T>(this T control, System.Nullable<System.Double> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.TooltipTextSize = value!);

/*BindFromExpressionSetterGenerator*/
public static T TooltipTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextSizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TooltipTextSize<T>(this T control,System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TooltipTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TooltipTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TooltipTextSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.TooltipTextSizeProperty, ps, () => control.TooltipTextSize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LegendPosition

/*ValueSetterGenerator*/
public static T LegendPosition<T>(this T control, LiveChartsCore.Measure.LegendPosition value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.LegendPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T LegendPosition<T>(this T control, Func<LiveChartsCore.Measure.LegendPosition> func, Action<LiveChartsCore.Measure.LegendPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LegendPosition<T>(this T control,LiveChartsCore.Measure.LegendPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendPositionProperty, ps, () => control.LegendPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendPosition<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LegendPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Measure.LegendPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendPositionProperty, ps, () => control.LegendPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LegendBackgroundPaint

/*ValueSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.LegendBackgroundPaint = value!);

/*BindFromExpressionSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendBackgroundPaintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LegendBackgroundPaint<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendBackgroundPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendBackgroundPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendBackgroundPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LegendBackgroundPaint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendBackgroundPaintProperty, ps, () => control.LegendBackgroundPaint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LegendTextPaint

/*ValueSetterGenerator*/
public static T LegendTextPaint<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.LegendTextPaint = value!);

/*BindFromExpressionSetterGenerator*/
public static T LegendTextPaint<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextPaintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LegendTextPaint<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendTextPaint<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextPaintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendTextPaint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextPaintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LegendTextPaint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextPaintProperty, ps, () => control.LegendTextPaint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LegendTextSize

/*ValueSetterGenerator*/
public static T LegendTextSize<T>(this T control, System.Nullable<System.Double> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.LegendTextSize = value!);

/*BindFromExpressionSetterGenerator*/
public static T LegendTextSize<T>(this T control, Func<System.Nullable<System.Double>> func, Action<System.Nullable<System.Double>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextSizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LegendTextSize<T>(this T control,System.Nullable<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LegendTextSize<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LegendTextSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LegendTextSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.LegendTextSizeProperty, ps, () => control.LegendTextSize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UpdateStartedCommand

/*ValueSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.UpdateStartedCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.UpdateStartedCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UpdateStartedCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.UpdateStartedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpdateStartedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.UpdateStartedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UpdateStartedCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.UpdateStartedCommandProperty, ps, () => control.UpdateStartedCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PointerPressedCommand

/*ValueSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.PointerPressedCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerPressedCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PointerPressedCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerPressedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerPressedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerPressedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PointerPressedCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerPressedCommandProperty, ps, () => control.PointerPressedCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PointerReleasedCommand

/*ValueSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.PointerReleasedCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerReleasedCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PointerReleasedCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerReleasedCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerReleasedCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerReleasedCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PointerReleasedCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerReleasedCommandProperty, ps, () => control.PointerReleasedCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PointerMoveCommand

/*ValueSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.PointerMoveCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerMoveCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PointerMoveCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerMoveCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PointerMoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerMoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PointerMoveCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.PointerMoveCommandProperty, ps, () => control.PointerMoveCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DataPointerDownCommand

/*ValueSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.DataPointerDownCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DataPointerDownCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DataPointerDownCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DataPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DataPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DataPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DataPointerDownCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.DataPointerDownCommandProperty, ps, () => control.DataPointerDownCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ChartPointPointerDownCommand

/*ValueSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.ChartPointPointerDownCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ChartPointPointerDownCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ChartPointPointerDownCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ChartPointPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ChartPointPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ChartPointPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ChartPointPointerDownCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.ChartPointPointerDownCommandProperty, ps, () => control.ChartPointPointerDownCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VisualElementsPointerDownCommand

/*ValueSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, System.Windows.Input.ICommand value) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._set(() => control.VisualElementsPointerDownCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsPointerDownCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VisualElementsPointerDownCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsPointerDownCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VisualElementsPointerDownCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsPointerDownCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VisualElementsPointerDownCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart.VisualElementsPointerDownCommandProperty, ps, () => control.VisualElementsPointerDownCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Measuring

/*ActionToEventGenerator*/
public static T OnMeasuring<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.Measuring += h);


 // UpdateStarted

/*ActionToEventGenerator*/
public static T OnUpdateStarted<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateStarted += h);


 // UpdateFinished

/*ActionToEventGenerator*/
public static T OnUpdateFinished<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.ChartEventHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateFinished += h);


 // DataPointerDown

/*ActionToEventGenerator*/
public static T OnDataPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, System.Collections.Generic.IEnumerable<LiveChartsCore.Kernel.ChartPoint>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.ChartPointsHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.DataPointerDown += h);


 // ChartPointPointerDown

/*ActionToEventGenerator*/
public static T OnChartPointPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, LiveChartsCore.Kernel.ChartPoint> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.ChartPointHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.ChartPointPointerDown += h);


 // VisualElementsPointerDown

/*ActionToEventGenerator*/
public static T OnVisualElementsPointerDown<T>(this T control, Action<LiveChartsCore.Kernel.Sketches.IChartView, LiveChartsCore.Kernel.Events.VisualElementsEventArgs<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> action) where T : LiveChartsCore.SkiaSharpView.Avalonia.CartesianChart  => 
 control._setEvent((LiveChartsCore.Kernel.Events.VisualElementsHandler<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>) ((arg0, arg1) => action(arg0, arg1)), h => control.VisualElementsPointerDown += h);



}
