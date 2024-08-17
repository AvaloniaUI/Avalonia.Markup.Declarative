#nullable enable
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
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, func, onChanged, expression);
public static T CaretIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RevealPassword<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, func, onChanged, expression);
public static T RevealPassword<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static T RevealPassword<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PasswordChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, func, onChanged, expression);
public static T PasswordChar<T>(this T control, System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static T PasswordChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, func, onChanged, expression);
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static T SelectionBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, func, onChanged, expression);
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, func, onChanged, expression);
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static T CaretBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, func, onChanged, expression);
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, func, onChanged, expression);
public static T SelectionStart<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static T SelectionStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, func, onChanged, expression);
public static T SelectionEnd<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static T SelectionEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreeditText<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);
public static T PreeditText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreeditText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, func, onChanged, expression);
public static T PreeditText<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = value, bindingMode, converter, bindingSource);
public static T PreeditText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreeditTextCursorPosition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);
public static T PreeditTextCursorPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreeditTextCursorPosition<T>(this T control, Func<System.Nullable<System.Int32>> func, Action<System.Nullable<System.Int32>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, func, onChanged, expression);
public static T PreeditTextCursorPosition<T>(this T control, System.Nullable<System.Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = value, bindingMode, converter, bindingSource);
public static T PreeditTextCursorPosition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, func, onChanged, expression);
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, func, onChanged, expression);
public static T LineHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, func, onChanged, expression);
public static T LetterSpacing<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static T LetterSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

