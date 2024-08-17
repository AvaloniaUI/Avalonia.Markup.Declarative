using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using SelectableTextBlock = Avalonia.Controls.SelectableTextBlock;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectableTextBlockExtensions
{
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);
}

