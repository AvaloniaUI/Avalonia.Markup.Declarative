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
public static partial class MotionCanvas_MarkupExtensions
{
//================= Properties ======================//
 // PaintTasksProperty

/*BindFromExpressionSetterGenerator*/
public static T PaintTasks<T>(this T control, Func<System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PaintTasks<T>(this T control, System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PaintTasks<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaintTasks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PaintTasks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
