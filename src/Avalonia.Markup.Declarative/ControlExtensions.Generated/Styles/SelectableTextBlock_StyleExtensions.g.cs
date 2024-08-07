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
public static Style<SelectableTextBlock> SelectionStart(this Style<SelectableTextBlock> style, Int32 value)
=> style._addSetter(SelectableTextBlock.SelectionStartProperty, value);
public static Style<SelectableTextBlock> SelectionStart(this Style<SelectableTextBlock> style, IBinding binding)
=> style._addSetter(SelectableTextBlock.SelectionStartProperty, binding);
public static Style<SelectableTextBlock> SelectionEnd(this Style<SelectableTextBlock> style, Int32 value)
=> style._addSetter(SelectableTextBlock.SelectionEndProperty, value);
public static Style<SelectableTextBlock> SelectionEnd(this Style<SelectableTextBlock> style, IBinding binding)
=> style._addSetter(SelectableTextBlock.SelectionEndProperty, binding);
public static Style<SelectableTextBlock> SelectionBrush(this Style<SelectableTextBlock> style, IBrush value)
=> style._addSetter(SelectableTextBlock.SelectionBrushProperty, value);
public static Style<SelectableTextBlock> SelectionBrush(this Style<SelectableTextBlock> style, IBinding binding)
=> style._addSetter(SelectableTextBlock.SelectionBrushProperty, binding);
public static Style<SelectableTextBlock> SelectionForegroundBrush(this Style<SelectableTextBlock> style, IBrush value)
=> style._addSetter(SelectableTextBlock.SelectionForegroundBrushProperty, value);
public static Style<SelectableTextBlock> SelectionForegroundBrush(this Style<SelectableTextBlock> style, IBinding binding)
=> style._addSetter(SelectableTextBlock.SelectionForegroundBrushProperty, binding);
}

