using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextPresenter = Avalonia.Controls.Presenters.TextPresenter;

namespace Avalonia.Markup.Declarative;
public static partial class TextPresenterExtensions
{
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, value);
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, value);
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, value);
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, value);
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, value);
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, value);
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, value);
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, value);
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);
public static Style<T> PreeditText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, value);
public static Style<T> PreeditText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, value);
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, value);
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);
}

