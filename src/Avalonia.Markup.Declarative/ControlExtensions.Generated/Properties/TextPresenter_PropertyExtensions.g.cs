#nullable enable
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
public static TextPresenter CaretIndex(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.CaretIndexProperty, binding);
public static TextPresenter CaretIndex(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter CaretIndex(this TextPresenter control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.CaretIndexProperty, func, onChanged, expression);
public static TextPresenter CaretIndex(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static TextPresenter CaretIndex<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter RevealPassword(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.RevealPasswordProperty, binding);
public static TextPresenter RevealPassword(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter RevealPassword(this TextPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.RevealPasswordProperty, func, onChanged, expression);
public static TextPresenter RevealPassword(this TextPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static TextPresenter RevealPassword<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter PasswordChar(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.PasswordCharProperty, binding);
public static TextPresenter PasswordChar(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter PasswordChar(this TextPresenter control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.PasswordCharProperty, func, onChanged, expression);
public static TextPresenter PasswordChar(this TextPresenter control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static TextPresenter PasswordChar<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionBrushProperty, binding);
public static TextPresenter SelectionBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter SelectionBrush(this TextPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionBrushProperty, func, onChanged, expression);
public static TextPresenter SelectionBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, binding);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, func, onChanged, expression);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionForegroundBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter CaretBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.CaretBrushProperty, binding);
public static TextPresenter CaretBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter CaretBrush(this TextPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.CaretBrushProperty, func, onChanged, expression);
public static TextPresenter CaretBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter CaretBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter CaretBlinkInterval(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.CaretBlinkIntervalProperty, binding);
public static TextPresenter CaretBlinkInterval(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter CaretBlinkInterval(this TextPresenter control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.CaretBlinkIntervalProperty, func, onChanged, expression);
public static TextPresenter CaretBlinkInterval(this TextPresenter control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);
public static TextPresenter CaretBlinkInterval<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionStart(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionStartProperty, binding);
public static TextPresenter SelectionStart(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter SelectionStart(this TextPresenter control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionStartProperty, func, onChanged, expression);
public static TextPresenter SelectionStart(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionStart<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionEnd(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionEndProperty, binding);
public static TextPresenter SelectionEnd(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter SelectionEnd(this TextPresenter control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionEndProperty, func, onChanged, expression);
public static TextPresenter SelectionEnd(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionEnd<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter Text(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextProperty, binding);
public static TextPresenter Text(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter Text(this TextPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextProperty, func, onChanged, expression);
public static TextPresenter Text(this TextPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextPresenter Text<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter PreeditText(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.PreeditTextProperty, binding);
public static TextPresenter PreeditText(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.PreeditTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter PreeditText(this TextPresenter control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.PreeditTextProperty, func, onChanged, expression);
public static TextPresenter PreeditText(this TextPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = value, bindingMode, converter, bindingSource);
public static TextPresenter PreeditText<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter PreeditTextCursorPosition(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, binding);
public static TextPresenter PreeditTextCursorPosition(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter PreeditTextCursorPosition(this TextPresenter control, Func<Nullable<Int32>> func, Action<Nullable<Int32>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, func, onChanged, expression);
public static TextPresenter PreeditTextCursorPosition(this TextPresenter control, Nullable<Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = value, bindingMode, converter, bindingSource);
public static TextPresenter PreeditTextCursorPosition<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Nullable<Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter TextAlignment(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextAlignmentProperty, binding);
public static TextPresenter TextAlignment(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter TextAlignment(this TextPresenter control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextAlignmentProperty, func, onChanged, expression);
public static TextPresenter TextAlignment(this TextPresenter control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextPresenter TextAlignment<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter TextWrapping(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextWrappingProperty, binding);
public static TextPresenter TextWrapping(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter TextWrapping(this TextPresenter control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextWrappingProperty, func, onChanged, expression);
public static TextPresenter TextWrapping(this TextPresenter control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextPresenter TextWrapping<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter LineHeight(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.LineHeightProperty, binding);
public static TextPresenter LineHeight(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter LineHeight(this TextPresenter control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.LineHeightProperty, func, onChanged, expression);
public static TextPresenter LineHeight(this TextPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextPresenter LineHeight<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter LetterSpacing(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.LetterSpacingProperty, binding);
public static TextPresenter LetterSpacing(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter LetterSpacing(this TextPresenter control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.LetterSpacingProperty, func, onChanged, expression);
public static TextPresenter LetterSpacing(this TextPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextPresenter LetterSpacing<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter Background(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.BackgroundProperty, binding);
public static TextPresenter Background(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextPresenter Background(this TextPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.BackgroundProperty, func, onChanged, expression);
public static TextPresenter Background(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextPresenter Background<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

