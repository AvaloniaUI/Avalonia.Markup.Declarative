#nullable enable
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
public static T AcceptsReturn<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.AcceptsReturnProperty, binding);
public static T AcceptsReturn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AcceptsReturn<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.AcceptsReturnProperty, func, onChanged, expression);
public static T AcceptsReturn<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value, bindingMode, converter, bindingSource);
public static T AcceptsReturn<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AcceptsTab<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.AcceptsTabProperty, binding);
public static T AcceptsTab<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AcceptsTab<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.AcceptsTabProperty, func, onChanged, expression);
public static T AcceptsTab<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value, bindingMode, converter, bindingSource);
public static T AcceptsTab<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretIndex<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.CaretIndexProperty, binding);
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.CaretIndexProperty, func, onChanged, expression);
public static T CaretIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsReadOnly<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.IsReadOnlyProperty, binding);
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsReadOnly<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.IsReadOnlyProperty, func, onChanged, expression);
public static T IsReadOnly<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static T IsReadOnly<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PasswordChar<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.PasswordCharProperty, binding);
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PasswordChar<T>(this T control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.PasswordCharProperty, func, onChanged, expression);
public static T PasswordChar<T>(this T control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static T PasswordChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionBrush<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.SelectionBrushProperty, binding);
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.SelectionBrushProperty, func, onChanged, expression);
public static T SelectionBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static T SelectionBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.SelectionForegroundBrushProperty, binding);
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionForegroundBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.SelectionForegroundBrushProperty, func, onChanged, expression);
public static T SelectionForegroundBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBrush<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.CaretBrushProperty, binding);
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.CaretBrushProperty, func, onChanged, expression);
public static T CaretBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static T CaretBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.CaretBlinkIntervalProperty, binding);
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretBlinkInterval<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.CaretBlinkIntervalProperty, func, onChanged, expression);
public static T CaretBlinkInterval<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);
public static T CaretBlinkInterval<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionStart<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.SelectionStartProperty, binding);
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionStart<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.SelectionStartProperty, func, onChanged, expression);
public static T SelectionStart<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static T SelectionStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionEnd<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.SelectionEndProperty, binding);
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionEnd<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.SelectionEndProperty, func, onChanged, expression);
public static T SelectionEnd<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static T SelectionEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLength<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.MaxLengthProperty, binding);
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLength<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.MaxLengthProperty, func, onChanged, expression);
public static T MaxLength<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);
public static T MaxLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLines<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.MaxLinesProperty, binding);
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLines<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.MaxLinesProperty, func, onChanged, expression);
public static T MaxLines<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static T MaxLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinLines<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.MinLinesProperty, binding);
public static T MinLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.MinLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinLines<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.MinLinesProperty, func, onChanged, expression);
public static T MinLines<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MinLinesProperty, ps, () => control.MinLines = value, bindingMode, converter, bindingSource);
public static T MinLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.MinLinesProperty, ps, () => control.MinLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextWrapping<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.TextWrappingProperty, binding);
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextWrapping<T>(this T control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.TextWrappingProperty, func, onChanged, expression);
public static T TextWrapping<T>(this T control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineHeight<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.LineHeightProperty, binding);
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.LineHeightProperty, func, onChanged, expression);
public static T LineHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LetterSpacing<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.LetterSpacingProperty, binding);
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LetterSpacing<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.LetterSpacingProperty, func, onChanged, expression);
public static T LetterSpacing<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static T LetterSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.UseFloatingWatermarkProperty, binding);
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseFloatingWatermark<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.UseFloatingWatermarkProperty, func, onChanged, expression);
public static T UseFloatingWatermark<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static T UseFloatingWatermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T NewLine<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.NewLineProperty, binding);
public static T NewLine<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T NewLine<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.NewLineProperty, func, onChanged, expression);
public static T NewLine<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = value, bindingMode, converter, bindingSource);
public static T NewLine<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.InnerLeftContentProperty, binding);
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerLeftContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.InnerLeftContentProperty, func, onChanged, expression);
public static T InnerLeftContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static T InnerLeftContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRightContent<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.InnerRightContentProperty, binding);
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRightContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.InnerRightContentProperty, func, onChanged, expression);
public static T InnerRightContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static T InnerRightContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RevealPassword<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.RevealPasswordProperty, binding);
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RevealPassword<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.RevealPasswordProperty, func, onChanged, expression);
public static T RevealPassword<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static T RevealPassword<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsUndoEnabled<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.IsUndoEnabledProperty, binding);
public static T IsUndoEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsUndoEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.IsUndoEnabledProperty, func, onChanged, expression);
public static T IsUndoEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value, bindingMode, converter, bindingSource);
public static T IsUndoEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UndoLimit<T>(this T control, IBinding binding) where T : TextBox
   => control._set(TextBox.UndoLimitProperty, binding);
public static T UndoLimit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBox
   => control._set(TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UndoLimit<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBox
   => control._set(TextBox.UndoLimitProperty, func, onChanged, expression);
public static T UndoLimit<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value, bindingMode, converter, bindingSource);
public static T UndoLimit<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBox
=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

