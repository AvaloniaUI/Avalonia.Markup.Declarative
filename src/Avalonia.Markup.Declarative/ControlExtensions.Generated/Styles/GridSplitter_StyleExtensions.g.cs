using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using GridSplitter = Avalonia.Controls.GridSplitter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridSplitterExtensions
{
public static Style<T> ResizeDirection<T>(this Style<T> style, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, value);
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);
public static Style<T> ResizeBehavior<T>(this Style<T> style, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, value);
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);
public static Style<T> ShowsPreview<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, value);
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);
public static Style<T> KeyboardIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, value);
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);
public static Style<T> DragIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, value);
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);
public static Style<T> PreviewContent<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, value);
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);
}

