using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore.Kernel.Events;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CartesianChartEventsExtensions
{
    public static T OnMeasuring<T>(this T control, Action<SkiaSharpDrawingContext> action) where T : CartesianChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.Measuring += h);
    public static T OnUpdateStarted<T>(this T control, Action<SkiaSharpDrawingContext> action) where T : CartesianChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateStarted += h);
    public static T OnUpdateFinished<T>(this T control, Action<SkiaSharpDrawingContext> action) where T : CartesianChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateFinished += h);
    public static T OnDataPointerDown<T>(this T control, Action action) where T : CartesianChart => 
        control._setEvent((ChartPointsHandler) ((_, args) => action()), h => control.DataPointerDown += h);
    public static T OnChartPointPointerDown<T>(this T control, Action action) where T : CartesianChart => 
        control._setEvent((ChartPointHandler) ((_, args) => action()), h => control.ChartPointPointerDown += h);
    public static T OnVisualElementsPointerDown<T>(this T control, Action<SkiaSharpDrawingContext> action) where T : CartesianChart => 
        control._setEvent((VisualElementsHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.VisualElementsPointerDown += h);
}

