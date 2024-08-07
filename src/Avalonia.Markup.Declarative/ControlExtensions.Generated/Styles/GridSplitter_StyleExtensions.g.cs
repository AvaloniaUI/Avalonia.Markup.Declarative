using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridSplitterExtensions
{
public static Style<GridSplitter> ResizeDirection(this Style<GridSplitter> style, GridResizeDirection value)
=> style._addSetter(GridSplitter.ResizeDirectionProperty, value);
public static Style<GridSplitter> ResizeDirection(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.ResizeDirectionProperty, binding);
public static Style<GridSplitter> ResizeBehavior(this Style<GridSplitter> style, GridResizeBehavior value)
=> style._addSetter(GridSplitter.ResizeBehaviorProperty, value);
public static Style<GridSplitter> ResizeBehavior(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.ResizeBehaviorProperty, binding);
public static Style<GridSplitter> ShowsPreview(this Style<GridSplitter> style, Boolean value)
=> style._addSetter(GridSplitter.ShowsPreviewProperty, value);
public static Style<GridSplitter> ShowsPreview(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.ShowsPreviewProperty, binding);
public static Style<GridSplitter> KeyboardIncrement(this Style<GridSplitter> style, Double value)
=> style._addSetter(GridSplitter.KeyboardIncrementProperty, value);
public static Style<GridSplitter> KeyboardIncrement(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.KeyboardIncrementProperty, binding);
public static Style<GridSplitter> DragIncrement(this Style<GridSplitter> style, Double value)
=> style._addSetter(GridSplitter.DragIncrementProperty, value);
public static Style<GridSplitter> DragIncrement(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.DragIncrementProperty, binding);
public static Style<GridSplitter> PreviewContent(this Style<GridSplitter> style, ITemplate<Control> value)
=> style._addSetter(GridSplitter.PreviewContentProperty, value);
public static Style<GridSplitter> PreviewContent(this Style<GridSplitter> style, IBinding binding)
=> style._addSetter(GridSplitter.PreviewContentProperty, binding);
}

