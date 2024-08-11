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
public static T CaretIndex<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.CaretIndexProperty, binding);
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.CaretIndexProperty, func, onChanged, expression);
public static T CaretIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RevealPassword<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.RevealPasswordProperty, binding);
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RevealPassword<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.RevealPasswordProperty, func, onChanged, expression);
public static T RevealPassword<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static T RevealPassword<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PasswordChar<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.PasswordCharProperty, binding);
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PasswordChar<T>(this T control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.PasswordCharProperty, func, onChanged, expression);
public static T PasswordChar<T>(this T control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static T PasswordChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionBrush<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.SelectionBrushProperty, binding);
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionBrushProperty, func, onChanged, expression);
public static T SelectionBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static T SelectionBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.SelectionForegroundBrushProperty, binding);
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionForegroundBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionForegroundBrushProperty, func, onChanged, expression);
public static T SelectionForegroundBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBrush<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.CaretBrushProperty, binding);
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.CaretBrushProperty, func, onChanged, expression);
public static T CaretBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static T CaretBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.CaretBlinkIntervalProperty, binding);
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBlinkInterval<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.CaretBlinkIntervalProperty, func, onChanged, expression);
public static T CaretBlinkInterval<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionStart<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.SelectionStartProperty, binding);
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionStart<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionStartProperty, func, onChanged, expression);
public static T SelectionStart<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static T SelectionStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionEnd<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.SelectionEndProperty, binding);
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionEnd<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.SelectionEndProperty, func, onChanged, expression);
public static T SelectionEnd<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static T SelectionEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreeditText<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextProperty, binding);
public static T PreeditText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreeditText<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextProperty, func, onChanged, expression);
public static T PreeditText<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = value, bindingMode, converter, bindingSource);
public static T PreeditText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreeditTextCursorPosition<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, binding);
public static T PreeditTextCursorPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreeditTextCursorPosition<T>(this T control, Func<Nullable<Int32>> func, Action<Nullable<Int32>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.PreeditTextCursorPositionProperty, func, onChanged, expression);
public static T PreeditTextCursorPosition<T>(this T control, Nullable<Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = value, bindingMode, converter, bindingSource);
public static T PreeditTextCursorPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextWrapping<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.TextWrappingProperty, binding);
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextWrapping<T>(this T control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.TextWrappingProperty, func, onChanged, expression);
public static T TextWrapping<T>(this T control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineHeight<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.LineHeightProperty, binding);
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.LineHeightProperty, func, onChanged, expression);
public static T LineHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LetterSpacing<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.LetterSpacingProperty, binding);
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LetterSpacing<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.LetterSpacingProperty, func, onChanged, expression);
public static T LetterSpacing<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static T LetterSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Background<T>(this T control, IBinding binding) where T : TextPresenter
   => control._set(TextPresenter.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextPresenter
   => control._set(TextPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextPresenter
   => control._set(TextPresenter.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextPresenter
=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

