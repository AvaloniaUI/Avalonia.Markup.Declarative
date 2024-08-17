#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using MotionCanvas = LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MotionCanvasExtensions
{
public static T PaintTasks<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, binding);
public static T PaintTasks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaintTasks<T>(this T control, Func<System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> func, Action<System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, func, onChanged, expression);
public static T PaintTasks<T>(this T control, System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = value, bindingMode, converter, bindingSource);
public static T PaintTasks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.List<LiveChartsCore.Kernel.PaintSchedule<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

