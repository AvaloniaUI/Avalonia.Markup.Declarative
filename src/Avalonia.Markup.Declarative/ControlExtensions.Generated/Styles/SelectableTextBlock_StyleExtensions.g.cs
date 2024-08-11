using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectableTextBlockExtensions
{
public static Style<T> SelectionStart<T>(this Style<T> style, Int32 value) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, Int32 value) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionEndProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBrush value) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBrush value) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : SelectableTextBlock
=> style._addSetter(SelectableTextBlock.SelectionForegroundBrushProperty, binding);
}

