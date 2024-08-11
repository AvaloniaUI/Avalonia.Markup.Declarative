#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MotionCanvasExtensions
{
public static T PaintTasks<T>(this T control, IBinding binding) where T : MotionCanvas
   => control._set(MotionCanvas.PaintTasksProperty, binding);
public static T PaintTasks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MotionCanvas
   => control._set(MotionCanvas.PaintTasksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaintTasks<T>(this T control, Func<List<PaintSchedule<SkiaSharpDrawingContext>>> func, Action<List<PaintSchedule<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MotionCanvas
   => control._set(MotionCanvas.PaintTasksProperty, func, onChanged, expression);
public static T PaintTasks<T>(this T control, List<PaintSchedule<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MotionCanvas
=> control._setEx(MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = value, bindingMode, converter, bindingSource);
public static T PaintTasks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, List<PaintSchedule<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MotionCanvas
=> control._setEx(MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

