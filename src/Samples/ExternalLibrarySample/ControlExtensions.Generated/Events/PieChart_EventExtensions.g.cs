using Avalonia.Data;
using Avalonia.Data.Converters;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Events;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PieChartEventsExtensions
{
    public static T OnMeasuring<T>(this T control, Action<IChartView<SkiaSharpDrawingContext>> action) where T : PieChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.Measuring += h);
    public static T OnUpdateStarted<T>(this T control, Action<IChartView<SkiaSharpDrawingContext>> action) where T : PieChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateStarted += h);
    public static T OnUpdateFinished<T>(this T control, Action<IChartView<SkiaSharpDrawingContext>> action) where T : PieChart => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((arg0) => action(arg0)), h => control.UpdateFinished += h);
    public static T OnDataPointerDown<T>(this T control, Action<IChartView, IEnumerable<ChartPoint>> action) where T : PieChart => 
        control._setEvent((ChartPointsHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.DataPointerDown += h);
    public static T OnChartPointPointerDown<T>(this T control, Action<IChartView, ChartPoint> action) where T : PieChart => 
        control._setEvent((ChartPointHandler) ((arg0, arg1) => action(arg0, arg1)), h => control.ChartPointPointerDown += h);
    public static T OnVisualElementsPointerDown<T>(this T control, Action<IChartView, VisualElementsEventArgs<SkiaSharpDrawingContext>> action) where T : PieChart => 
        control._setEvent((VisualElementsHandler<SkiaSharpDrawingContext>) ((arg0, arg1) => action(arg0, arg1)), h => control.VisualElementsPointerDown += h);
}

