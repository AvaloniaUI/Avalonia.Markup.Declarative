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
public static Style<T> CaretIndex<T>(this Style<T> style, Int32 value) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretIndexProperty, binding);
public static Style<T> RevealPassword<T>(this Style<T> style, Boolean value) where T : TextPresenter
=> style._addSetter(TextPresenter.RevealPasswordProperty, value);
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.RevealPasswordProperty, binding);
public static Style<T> PasswordChar<T>(this Style<T> style, Char value) where T : TextPresenter
=> style._addSetter(TextPresenter.PasswordCharProperty, value);
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.PasswordCharProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBrush value) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBrush value) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionForegroundBrushProperty, binding);
public static Style<T> CaretBrush<T>(this Style<T> style, IBrush value) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretBrushProperty, value);
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretBrushProperty, binding);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, TimeSpan value) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretBlinkIntervalProperty, value);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.CaretBlinkIntervalProperty, binding);
public static Style<T> SelectionStart<T>(this Style<T> style, Int32 value) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, Int32 value) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.SelectionEndProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : TextPresenter
=> style._addSetter(TextPresenter.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.TextProperty, binding);
public static Style<T> PreeditText<T>(this Style<T> style, String value) where T : TextPresenter
=> style._addSetter(TextPresenter.PreeditTextProperty, value);
public static Style<T> PreeditText<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.PreeditTextProperty, binding);
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, Nullable<Int32> value) where T : TextPresenter
=> style._addSetter(TextPresenter.PreeditTextCursorPositionProperty, value);
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.PreeditTextCursorPositionProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, TextAlignment value) where T : TextPresenter
=> style._addSetter(TextPresenter.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.TextAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, TextWrapping value) where T : TextPresenter
=> style._addSetter(TextPresenter.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.TextWrappingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, Double value) where T : TextPresenter
=> style._addSetter(TextPresenter.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.LineHeightProperty, binding);
public static Style<T> LetterSpacing<T>(this Style<T> style, Double value) where T : TextPresenter
=> style._addSetter(TextPresenter.LetterSpacingProperty, value);
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.LetterSpacingProperty, binding);
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : TextPresenter
=> style._addSetter(TextPresenter.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : TextPresenter
=> style._addSetter(TextPresenter.BackgroundProperty, binding);
}

