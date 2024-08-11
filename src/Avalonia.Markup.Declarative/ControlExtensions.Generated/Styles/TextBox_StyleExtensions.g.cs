using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextBoxExtensions
{
public static Style<T> AcceptsReturn<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.AcceptsReturnProperty, value);
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.AcceptsReturnProperty, binding);
public static Style<T> AcceptsTab<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.AcceptsTabProperty, value);
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.AcceptsTabProperty, binding);
public static Style<T> CaretIndex<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.CaretIndexProperty, binding);
public static Style<T> IsReadOnly<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.IsReadOnlyProperty, value);
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.IsReadOnlyProperty, binding);
public static Style<T> PasswordChar<T>(this Style<T> style, Char value) where T : TextBox
=> style._addSetter(TextBox.PasswordCharProperty, value);
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.PasswordCharProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBrush value) where T : TextBox
=> style._addSetter(TextBox.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBrush value) where T : TextBox
=> style._addSetter(TextBox.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.SelectionForegroundBrushProperty, binding);
public static Style<T> CaretBrush<T>(this Style<T> style, IBrush value) where T : TextBox
=> style._addSetter(TextBox.CaretBrushProperty, value);
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.CaretBrushProperty, binding);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, TimeSpan value) where T : TextBox
=> style._addSetter(TextBox.CaretBlinkIntervalProperty, value);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.CaretBlinkIntervalProperty, binding);
public static Style<T> SelectionStart<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.SelectionEndProperty, binding);
public static Style<T> MaxLength<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.MaxLengthProperty, value);
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.MaxLengthProperty, binding);
public static Style<T> MaxLines<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.MaxLinesProperty, value);
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.MaxLinesProperty, binding);
public static Style<T> MinLines<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.MinLinesProperty, value);
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.MinLinesProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : TextBox
=> style._addSetter(TextBox.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.TextProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, TextAlignment value) where T : TextBox
=> style._addSetter(TextBox.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.TextAlignmentProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : TextBox
=> style._addSetter(TextBox.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : TextBox
=> style._addSetter(TextBox.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.VerticalContentAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, TextWrapping value) where T : TextBox
=> style._addSetter(TextBox.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.TextWrappingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, Double value) where T : TextBox
=> style._addSetter(TextBox.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.LineHeightProperty, binding);
public static Style<T> LetterSpacing<T>(this Style<T> style, Double value) where T : TextBox
=> style._addSetter(TextBox.LetterSpacingProperty, value);
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.LetterSpacingProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, String value) where T : TextBox
=> style._addSetter(TextBox.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.WatermarkProperty, binding);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.UseFloatingWatermarkProperty, value);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.UseFloatingWatermarkProperty, binding);
public static Style<T> NewLine<T>(this Style<T> style, String value) where T : TextBox
=> style._addSetter(TextBox.NewLineProperty, value);
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.NewLineProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, Object value) where T : TextBox
=> style._addSetter(TextBox.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, Object value) where T : TextBox
=> style._addSetter(TextBox.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.InnerRightContentProperty, binding);
public static Style<T> RevealPassword<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.RevealPasswordProperty, value);
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.RevealPasswordProperty, binding);
public static Style<T> IsUndoEnabled<T>(this Style<T> style, Boolean value) where T : TextBox
=> style._addSetter(TextBox.IsUndoEnabledProperty, value);
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.IsUndoEnabledProperty, binding);
public static Style<T> UndoLimit<T>(this Style<T> style, Int32 value) where T : TextBox
=> style._addSetter(TextBox.UndoLimitProperty, value);
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : TextBox
=> style._addSetter(TextBox.UndoLimitProperty, binding);
}

