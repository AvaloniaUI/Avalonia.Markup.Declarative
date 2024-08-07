using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextPresenterExtensions
{
public static Style<TextPresenter> CaretIndex(this Style<TextPresenter> style, Int32 value)
=> style._addSetter(TextPresenter.CaretIndexProperty, value);
public static Style<TextPresenter> CaretIndex(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.CaretIndexProperty, binding);
public static Style<TextPresenter> RevealPassword(this Style<TextPresenter> style, Boolean value)
=> style._addSetter(TextPresenter.RevealPasswordProperty, value);
public static Style<TextPresenter> RevealPassword(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.RevealPasswordProperty, binding);
public static Style<TextPresenter> PasswordChar(this Style<TextPresenter> style, Char value)
=> style._addSetter(TextPresenter.PasswordCharProperty, value);
public static Style<TextPresenter> PasswordChar(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.PasswordCharProperty, binding);
public static Style<TextPresenter> SelectionBrush(this Style<TextPresenter> style, IBrush value)
=> style._addSetter(TextPresenter.SelectionBrushProperty, value);
public static Style<TextPresenter> SelectionBrush(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.SelectionBrushProperty, binding);
public static Style<TextPresenter> SelectionForegroundBrush(this Style<TextPresenter> style, IBrush value)
=> style._addSetter(TextPresenter.SelectionForegroundBrushProperty, value);
public static Style<TextPresenter> SelectionForegroundBrush(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.SelectionForegroundBrushProperty, binding);
public static Style<TextPresenter> CaretBrush(this Style<TextPresenter> style, IBrush value)
=> style._addSetter(TextPresenter.CaretBrushProperty, value);
public static Style<TextPresenter> CaretBrush(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.CaretBrushProperty, binding);
public static Style<TextPresenter> CaretBlinkInterval(this Style<TextPresenter> style, TimeSpan value)
=> style._addSetter(TextPresenter.CaretBlinkIntervalProperty, value);
public static Style<TextPresenter> CaretBlinkInterval(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.CaretBlinkIntervalProperty, binding);
public static Style<TextPresenter> SelectionStart(this Style<TextPresenter> style, Int32 value)
=> style._addSetter(TextPresenter.SelectionStartProperty, value);
public static Style<TextPresenter> SelectionStart(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.SelectionStartProperty, binding);
public static Style<TextPresenter> SelectionEnd(this Style<TextPresenter> style, Int32 value)
=> style._addSetter(TextPresenter.SelectionEndProperty, value);
public static Style<TextPresenter> SelectionEnd(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.SelectionEndProperty, binding);
public static Style<TextPresenter> Text(this Style<TextPresenter> style, String value)
=> style._addSetter(TextPresenter.TextProperty, value);
public static Style<TextPresenter> Text(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.TextProperty, binding);
public static Style<TextPresenter> PreeditText(this Style<TextPresenter> style, String value)
=> style._addSetter(TextPresenter.PreeditTextProperty, value);
public static Style<TextPresenter> PreeditText(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.PreeditTextProperty, binding);
public static Style<TextPresenter> PreeditTextCursorPosition(this Style<TextPresenter> style, Nullable<Int32> value)
=> style._addSetter(TextPresenter.PreeditTextCursorPositionProperty, value);
public static Style<TextPresenter> PreeditTextCursorPosition(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.PreeditTextCursorPositionProperty, binding);
public static Style<TextPresenter> TextAlignment(this Style<TextPresenter> style, TextAlignment value)
=> style._addSetter(TextPresenter.TextAlignmentProperty, value);
public static Style<TextPresenter> TextAlignment(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.TextAlignmentProperty, binding);
public static Style<TextPresenter> TextWrapping(this Style<TextPresenter> style, TextWrapping value)
=> style._addSetter(TextPresenter.TextWrappingProperty, value);
public static Style<TextPresenter> TextWrapping(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.TextWrappingProperty, binding);
public static Style<TextPresenter> LineHeight(this Style<TextPresenter> style, Double value)
=> style._addSetter(TextPresenter.LineHeightProperty, value);
public static Style<TextPresenter> LineHeight(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.LineHeightProperty, binding);
public static Style<TextPresenter> LetterSpacing(this Style<TextPresenter> style, Double value)
=> style._addSetter(TextPresenter.LetterSpacingProperty, value);
public static Style<TextPresenter> LetterSpacing(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.LetterSpacingProperty, binding);
public static Style<TextPresenter> Background(this Style<TextPresenter> style, IBrush value)
=> style._addSetter(TextPresenter.BackgroundProperty, value);
public static Style<TextPresenter> Background(this Style<TextPresenter> style, IBinding binding)
=> style._addSetter(TextPresenter.BackgroundProperty, binding);
}

