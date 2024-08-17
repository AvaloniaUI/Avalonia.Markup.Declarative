using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextBox = Avalonia.Controls.TextBox;

namespace Avalonia.Markup.Declarative;
public static partial class TextBoxExtensions
{
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, value);
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, value);
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, value);
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, value);
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, value);
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, value);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, value);
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, value);
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, value);
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, value);
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, value);
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, value);
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, value);
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, value);
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, value);
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);
}

