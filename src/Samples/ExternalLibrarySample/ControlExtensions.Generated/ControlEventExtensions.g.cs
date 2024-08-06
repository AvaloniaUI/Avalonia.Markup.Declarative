using LiveChartsCore.Kernel.Events;
using LiveChartsCore.SkiaSharpView.Avalonia;
using LiveChartsCore.SkiaSharpView.Drawing;

namespace Avalonia.Markup.Declarative;
public static partial class CartesianChartEventsExtensions
{
    public static CartesianChart OnMeasuring(this CartesianChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.Measuring += h);
    public static CartesianChart OnUpdateStarted(this CartesianChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateStarted += h);
    public static CartesianChart OnUpdateFinished(this CartesianChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateFinished += h);
    public static CartesianChart OnDataPointerDown(this CartesianChart control, Action action) => 
        control._setEvent((ChartPointsHandler) ((_, args) => action()), h => control.DataPointerDown += h);
    public static CartesianChart OnChartPointPointerDown(this CartesianChart control, Action action) => 
        control._setEvent((ChartPointHandler) ((_, args) => action()), h => control.ChartPointPointerDown += h);
    public static CartesianChart OnVisualElementsPointerDown(this CartesianChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((VisualElementsHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.VisualElementsPointerDown += h);
}
public static partial class PieChartEventsExtensions
{
    public static PieChart OnMeasuring(this PieChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.Measuring += h);
    public static PieChart OnUpdateStarted(this PieChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateStarted += h);
    public static PieChart OnUpdateFinished(this PieChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateFinished += h);
    public static PieChart OnDataPointerDown(this PieChart control, Action action) => 
        control._setEvent((ChartPointsHandler) ((_, args) => action()), h => control.DataPointerDown += h);
    public static PieChart OnChartPointPointerDown(this PieChart control, Action action) => 
        control._setEvent((ChartPointHandler) ((_, args) => action()), h => control.ChartPointPointerDown += h);
    public static PieChart OnVisualElementsPointerDown(this PieChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((VisualElementsHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.VisualElementsPointerDown += h);
}
public static partial class PolarChartEventsExtensions
{
    public static PolarChart OnMeasuring(this PolarChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.Measuring += h);
    public static PolarChart OnUpdateStarted(this PolarChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateStarted += h);
    public static PolarChart OnUpdateFinished(this PolarChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((ChartEventHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.UpdateFinished += h);
    public static PolarChart OnDataPointerDown(this PolarChart control, Action action) => 
        control._setEvent((ChartPointsHandler) ((_, args) => action()), h => control.DataPointerDown += h);
    public static PolarChart OnChartPointPointerDown(this PolarChart control, Action action) => 
        control._setEvent((ChartPointHandler) ((_, args) => action()), h => control.ChartPointPointerDown += h);
    public static PolarChart OnVisualElementsPointerDown(this PolarChart control, Action<SkiaSharpDrawingContext> action) => 
        control._setEvent((VisualElementsHandler<SkiaSharpDrawingContext>) ((_, args) => action(args)), h => control.VisualElementsPointerDown += h);
}

