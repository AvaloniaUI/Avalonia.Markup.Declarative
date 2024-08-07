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
public static MotionCanvas PaintTasks(this MotionCanvas control, IBinding binding)
   => control._set(MotionCanvas.PaintTasksProperty, binding);
public static MotionCanvas PaintTasks(this MotionCanvas control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MotionCanvas.PaintTasksProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MotionCanvas PaintTasks(this MotionCanvas control, Func<List<PaintSchedule<SkiaSharpDrawingContext>>> func, Action<List<PaintSchedule<SkiaSharpDrawingContext>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MotionCanvas.PaintTasksProperty, func, onChanged, expression);
public static MotionCanvas PaintTasks(this MotionCanvas control, List<PaintSchedule<SkiaSharpDrawingContext>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = value, bindingMode, converter, bindingSource);
public static MotionCanvas PaintTasks<TValue>(this MotionCanvas control, TValue value, FuncValueConverter<TValue, List<PaintSchedule<SkiaSharpDrawingContext>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MotionCanvas.PaintTasksProperty, ps, () => control.PaintTasks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

