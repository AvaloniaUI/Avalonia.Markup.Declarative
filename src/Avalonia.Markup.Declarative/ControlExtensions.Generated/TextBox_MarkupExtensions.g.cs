#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TextBox_MarkupExtensions
{
//================= Properties ======================//
 // AcceptsReturnProperty

/*BindFromExpressionSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AcceptsReturn<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AcceptsReturn<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AcceptsTabProperty

/*BindFromExpressionSetterGenerator*/
public static T AcceptsTab<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AcceptsTab<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptsTab<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsTab<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AcceptsTab<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretIndexProperty

/*BindFromExpressionSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsReadOnlyProperty

/*BindFromExpressionSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsReadOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsReadOnly<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PasswordCharProperty

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PasswordChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionForegroundBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionForegroundBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CaretBlinkIntervalProperty

/*BindFromExpressionSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretBlinkInterval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionStartProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionEndProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxLengthProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxLinesProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinLinesProperty

/*BindFromExpressionSetterGenerator*/
public static T MinLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinLines<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MinLinesProperty, ps, () => control.MinLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.MinLinesProperty, ps, () => control.MinLines = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextProperty

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalContentAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalContentAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextWrappingProperty

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineHeightProperty

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LetterSpacingProperty

/*BindFromExpressionSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LetterSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // WatermarkProperty

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Watermark<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UseFloatingWatermarkProperty

/*BindFromExpressionSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UseFloatingWatermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // NewLineProperty

/*BindFromExpressionSetterGenerator*/
public static T NewLine<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T NewLine<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.NewLineProperty, ps, () => control.NewLine = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NewLine<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NewLine<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T NewLine<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.NewLineProperty, ps, () => control.NewLine = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerLeftContentProperty

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerLeftContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerRightContentProperty

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerRightContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RevealPasswordProperty

/*BindFromExpressionSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RevealPassword<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RevealPassword<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsUndoEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsUndoEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UndoLimitProperty

/*BindFromExpressionSetterGenerator*/
public static T UndoLimit<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UndoLimit<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UndoLimit<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UndoLimit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UndoLimit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBox
=> control._setEx(Avalonia.Controls.TextBox.UndoLimitProperty, ps, () => control.UndoLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
    public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CopyingToClipboard += h);


 // CuttingToClipboard

/*ActionToEventGenerator*/
    public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CuttingToClipboard += h);


 // PastingFromClipboard

/*ActionToEventGenerator*/
    public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PastingFromClipboard += h);


 // TextChanged

/*ActionToEventGenerator*/
    public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TextChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextChanged += h);


 // TextChanging

/*ActionToEventGenerator*/
    public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action) where T : Avalonia.Controls.TextBox => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TextChangingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextChanging += h);



//================= Styles ======================//
 // AcceptsReturnProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);


 // AcceptsTabProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);


 // CaretIndexProperty

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);


 // IsReadOnlyProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);


 // PasswordCharProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);


 // SelectionBrushProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrushProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);


 // CaretBrushProperty

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);


 // CaretBlinkIntervalProperty

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);


 // SelectionStartProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);


 // SelectionEndProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);


 // MaxLengthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);


 // MaxLinesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);


 // MinLinesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);


 // TextProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);


 // TextAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);


 // HorizontalContentAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);


 // TextWrappingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);


 // LineHeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);


 // LetterSpacingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);


 // WatermarkProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);


 // UseFloatingWatermarkProperty

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);


 // NewLineProperty

/*ValueStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);


 // InnerLeftContentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);


 // InnerRightContentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);


 // RevealPasswordProperty

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);


 // IsUndoEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);


 // UndoLimitProperty

/*ValueStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);



}
