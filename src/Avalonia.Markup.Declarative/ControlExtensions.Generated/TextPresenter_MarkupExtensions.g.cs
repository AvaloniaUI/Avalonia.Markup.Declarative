#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TextPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ShowSelectionHighlight

/*BindFromExpressionSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, ps, () => control.ShowSelectionHighlight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowSelectionHighlight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, ps, () => control.ShowSelectionHighlight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretIndex

/*BindFromExpressionSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RevealPassword

/*BindFromExpressionSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RevealPassword<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RevealPassword<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RevealPassword<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PasswordChar

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PasswordChar<T>(this T control,System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PasswordChar<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionBrush

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionForegroundBrush

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionForegroundBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretBrush

/*BindFromExpressionSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretBlinkInterval

/*BindFromExpressionSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretBlinkInterval<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionStart

/*BindFromExpressionSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionStart<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionStart<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionEnd

/*BindFromExpressionSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionEnd<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionEnd<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PreeditText

/*BindFromExpressionSetterGenerator*/
public static T PreeditText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PreeditText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PreeditText<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PreeditText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PreeditText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PreeditTextCursorPosition

/*BindFromExpressionSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, Func<System.Nullable<System.Int32>> func, Action<System.Nullable<System.Int32>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control,System.Nullable<System.Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PreeditTextCursorPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, ps, () => control.PreeditTextCursorPosition = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignment

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextWrapping

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextWrapping<T>(this T control,Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextWrapping<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineHeight

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LineHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LineHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LetterSpacing

/*BindFromExpressionSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LetterSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LetterSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._setEx(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // CaretBoundsChanged

/*ActionToEventGenerator*/
public static T OnCaretBoundsChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Presenters.TextPresenter  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CaretBoundsChanged += h);



//================= Styles ======================//
 // ShowSelectionHighlight

/*ValueStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);


 // PreeditText

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);


 // PreeditTextCursorPosition

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);


 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);



}
