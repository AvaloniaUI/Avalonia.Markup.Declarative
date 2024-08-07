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
public static Style<TextBox> AcceptsReturn(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.AcceptsReturnProperty, value);
public static Style<TextBox> AcceptsReturn(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.AcceptsReturnProperty, binding);
public static Style<TextBox> AcceptsTab(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.AcceptsTabProperty, value);
public static Style<TextBox> AcceptsTab(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.AcceptsTabProperty, binding);
public static Style<TextBox> CaretIndex(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.CaretIndexProperty, value);
public static Style<TextBox> CaretIndex(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.CaretIndexProperty, binding);
public static Style<TextBox> IsReadOnly(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.IsReadOnlyProperty, value);
public static Style<TextBox> IsReadOnly(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.IsReadOnlyProperty, binding);
public static Style<TextBox> PasswordChar(this Style<TextBox> style, Char value)
=> style._addSetter(TextBox.PasswordCharProperty, value);
public static Style<TextBox> PasswordChar(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.PasswordCharProperty, binding);
public static Style<TextBox> SelectionBrush(this Style<TextBox> style, IBrush value)
=> style._addSetter(TextBox.SelectionBrushProperty, value);
public static Style<TextBox> SelectionBrush(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.SelectionBrushProperty, binding);
public static Style<TextBox> SelectionForegroundBrush(this Style<TextBox> style, IBrush value)
=> style._addSetter(TextBox.SelectionForegroundBrushProperty, value);
public static Style<TextBox> SelectionForegroundBrush(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.SelectionForegroundBrushProperty, binding);
public static Style<TextBox> CaretBrush(this Style<TextBox> style, IBrush value)
=> style._addSetter(TextBox.CaretBrushProperty, value);
public static Style<TextBox> CaretBrush(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.CaretBrushProperty, binding);
public static Style<TextBox> CaretBlinkInterval(this Style<TextBox> style, TimeSpan value)
=> style._addSetter(TextBox.CaretBlinkIntervalProperty, value);
public static Style<TextBox> CaretBlinkInterval(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.CaretBlinkIntervalProperty, binding);
public static Style<TextBox> SelectionStart(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.SelectionStartProperty, value);
public static Style<TextBox> SelectionStart(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.SelectionStartProperty, binding);
public static Style<TextBox> SelectionEnd(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.SelectionEndProperty, value);
public static Style<TextBox> SelectionEnd(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.SelectionEndProperty, binding);
public static Style<TextBox> MaxLength(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.MaxLengthProperty, value);
public static Style<TextBox> MaxLength(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.MaxLengthProperty, binding);
public static Style<TextBox> MaxLines(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.MaxLinesProperty, value);
public static Style<TextBox> MaxLines(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.MaxLinesProperty, binding);
public static Style<TextBox> MinLines(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.MinLinesProperty, value);
public static Style<TextBox> MinLines(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.MinLinesProperty, binding);
public static Style<TextBox> Text(this Style<TextBox> style, String value)
=> style._addSetter(TextBox.TextProperty, value);
public static Style<TextBox> Text(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.TextProperty, binding);
public static Style<TextBox> TextAlignment(this Style<TextBox> style, TextAlignment value)
=> style._addSetter(TextBox.TextAlignmentProperty, value);
public static Style<TextBox> TextAlignment(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.TextAlignmentProperty, binding);
public static Style<TextBox> HorizontalContentAlignment(this Style<TextBox> style, HorizontalAlignment value)
=> style._addSetter(TextBox.HorizontalContentAlignmentProperty, value);
public static Style<TextBox> HorizontalContentAlignment(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.HorizontalContentAlignmentProperty, binding);
public static Style<TextBox> VerticalContentAlignment(this Style<TextBox> style, VerticalAlignment value)
=> style._addSetter(TextBox.VerticalContentAlignmentProperty, value);
public static Style<TextBox> VerticalContentAlignment(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.VerticalContentAlignmentProperty, binding);
public static Style<TextBox> TextWrapping(this Style<TextBox> style, TextWrapping value)
=> style._addSetter(TextBox.TextWrappingProperty, value);
public static Style<TextBox> TextWrapping(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.TextWrappingProperty, binding);
public static Style<TextBox> LineHeight(this Style<TextBox> style, Double value)
=> style._addSetter(TextBox.LineHeightProperty, value);
public static Style<TextBox> LineHeight(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.LineHeightProperty, binding);
public static Style<TextBox> LetterSpacing(this Style<TextBox> style, Double value)
=> style._addSetter(TextBox.LetterSpacingProperty, value);
public static Style<TextBox> LetterSpacing(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.LetterSpacingProperty, binding);
public static Style<TextBox> Watermark(this Style<TextBox> style, String value)
=> style._addSetter(TextBox.WatermarkProperty, value);
public static Style<TextBox> Watermark(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.WatermarkProperty, binding);
public static Style<TextBox> UseFloatingWatermark(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.UseFloatingWatermarkProperty, value);
public static Style<TextBox> UseFloatingWatermark(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.UseFloatingWatermarkProperty, binding);
public static Style<TextBox> NewLine(this Style<TextBox> style, String value)
=> style._addSetter(TextBox.NewLineProperty, value);
public static Style<TextBox> NewLine(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.NewLineProperty, binding);
public static Style<TextBox> InnerLeftContent(this Style<TextBox> style, Object value)
=> style._addSetter(TextBox.InnerLeftContentProperty, value);
public static Style<TextBox> InnerLeftContent(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.InnerLeftContentProperty, binding);
public static Style<TextBox> InnerRightContent(this Style<TextBox> style, Object value)
=> style._addSetter(TextBox.InnerRightContentProperty, value);
public static Style<TextBox> InnerRightContent(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.InnerRightContentProperty, binding);
public static Style<TextBox> RevealPassword(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.RevealPasswordProperty, value);
public static Style<TextBox> RevealPassword(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.RevealPasswordProperty, binding);
public static Style<TextBox> IsUndoEnabled(this Style<TextBox> style, Boolean value)
=> style._addSetter(TextBox.IsUndoEnabledProperty, value);
public static Style<TextBox> IsUndoEnabled(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.IsUndoEnabledProperty, binding);
public static Style<TextBox> UndoLimit(this Style<TextBox> style, Int32 value)
=> style._addSetter(TextBox.UndoLimitProperty, value);
public static Style<TextBox> UndoLimit(this Style<TextBox> style, IBinding binding)
=> style._addSetter(TextBox.UndoLimitProperty, binding);
}

