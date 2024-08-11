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
public static Style<T> ResizeDirection<T>(this Style<T> style, GridResizeDirection value) where T : GridSplitter
=> style._addSetter(GridSplitter.ResizeDirectionProperty, value);
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.ResizeDirectionProperty, binding);
public static Style<T> ResizeBehavior<T>(this Style<T> style, GridResizeBehavior value) where T : GridSplitter
=> style._addSetter(GridSplitter.ResizeBehaviorProperty, value);
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.ResizeBehaviorProperty, binding);
public static Style<T> ShowsPreview<T>(this Style<T> style, Boolean value) where T : GridSplitter
=> style._addSetter(GridSplitter.ShowsPreviewProperty, value);
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.ShowsPreviewProperty, binding);
public static Style<T> KeyboardIncrement<T>(this Style<T> style, Double value) where T : GridSplitter
=> style._addSetter(GridSplitter.KeyboardIncrementProperty, value);
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.KeyboardIncrementProperty, binding);
public static Style<T> DragIncrement<T>(this Style<T> style, Double value) where T : GridSplitter
=> style._addSetter(GridSplitter.DragIncrementProperty, value);
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.DragIncrementProperty, binding);
public static Style<T> PreviewContent<T>(this Style<T> style, ITemplate<Control> value) where T : GridSplitter
=> style._addSetter(GridSplitter.PreviewContentProperty, value);
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : GridSplitter
=> style._addSetter(GridSplitter.PreviewContentProperty, binding);
}

