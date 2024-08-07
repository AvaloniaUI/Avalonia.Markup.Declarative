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
public static TextBox AcceptsReturn(this TextBox control, IBinding binding)
   => control._set(TextBox.AcceptsReturnProperty, binding);
public static TextBox AcceptsReturn(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox AcceptsReturn(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.AcceptsReturnProperty, func, onChanged, expression);
public static TextBox AcceptsReturn(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value, bindingMode, converter, bindingSource);
public static TextBox AcceptsReturn<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox AcceptsTab(this TextBox control, IBinding binding)
   => control._set(TextBox.AcceptsTabProperty, binding);
public static TextBox AcceptsTab(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox AcceptsTab(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.AcceptsTabProperty, func, onChanged, expression);
public static TextBox AcceptsTab(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value, bindingMode, converter, bindingSource);
public static TextBox AcceptsTab<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox CaretIndex(this TextBox control, IBinding binding)
   => control._set(TextBox.CaretIndexProperty, binding);
public static TextBox CaretIndex(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox CaretIndex(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.CaretIndexProperty, func, onChanged, expression);
public static TextBox CaretIndex(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static TextBox CaretIndex<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox IsReadOnly(this TextBox control, IBinding binding)
   => control._set(TextBox.IsReadOnlyProperty, binding);
public static TextBox IsReadOnly(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox IsReadOnly(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.IsReadOnlyProperty, func, onChanged, expression);
public static TextBox IsReadOnly(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static TextBox IsReadOnly<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox PasswordChar(this TextBox control, IBinding binding)
   => control._set(TextBox.PasswordCharProperty, binding);
public static TextBox PasswordChar(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox PasswordChar(this TextBox control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.PasswordCharProperty, func, onChanged, expression);
public static TextBox PasswordChar(this TextBox control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static TextBox PasswordChar<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionBrushProperty, binding);
public static TextBox SelectionBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox SelectionBrush(this TextBox control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionBrushProperty, func, onChanged, expression);
public static TextBox SelectionBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static TextBox SelectionBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionForegroundBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionForegroundBrushProperty, binding);
public static TextBox SelectionForegroundBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox SelectionForegroundBrush(this TextBox control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionForegroundBrushProperty, func, onChanged, expression);
public static TextBox SelectionForegroundBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static TextBox SelectionForegroundBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox CaretBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.CaretBrushProperty, binding);
public static TextBox CaretBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox CaretBrush(this TextBox control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.CaretBrushProperty, func, onChanged, expression);
public static TextBox CaretBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static TextBox CaretBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox CaretBlinkInterval(this TextBox control, IBinding binding)
   => control._set(TextBox.CaretBlinkIntervalProperty, binding);
public static TextBox CaretBlinkInterval(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox CaretBlinkInterval(this TextBox control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.CaretBlinkIntervalProperty, func, onChanged, expression);
public static TextBox CaretBlinkInterval(this TextBox control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value, bindingMode, converter, bindingSource);
public static TextBox CaretBlinkInterval<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionStart(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionStartProperty, binding);
public static TextBox SelectionStart(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox SelectionStart(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionStartProperty, func, onChanged, expression);
public static TextBox SelectionStart(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static TextBox SelectionStart<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionEnd(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionEndProperty, binding);
public static TextBox SelectionEnd(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox SelectionEnd(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionEndProperty, func, onChanged, expression);
public static TextBox SelectionEnd(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static TextBox SelectionEnd<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox MaxLength(this TextBox control, IBinding binding)
   => control._set(TextBox.MaxLengthProperty, binding);
public static TextBox MaxLength(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox MaxLength(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.MaxLengthProperty, func, onChanged, expression);
public static TextBox MaxLength(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);
public static TextBox MaxLength<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox MaxLines(this TextBox control, IBinding binding)
   => control._set(TextBox.MaxLinesProperty, binding);
public static TextBox MaxLines(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox MaxLines(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.MaxLinesProperty, func, onChanged, expression);
public static TextBox MaxLines(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static TextBox MaxLines<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox MinLines(this TextBox control, IBinding binding)
   => control._set(TextBox.MinLinesProperty, binding);
public static TextBox MinLines(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.MinLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox MinLines(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.MinLinesProperty, func, onChanged, expression);
public static TextBox MinLines(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MinLinesProperty, ps, () => control.MinLines = value, bindingMode, converter, bindingSource);
public static TextBox MinLines<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MinLinesProperty, ps, () => control.MinLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox Text(this TextBox control, IBinding binding)
   => control._set(TextBox.TextProperty, binding);
public static TextBox Text(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox Text(this TextBox control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextProperty, func, onChanged, expression);
public static TextBox Text(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextBox Text<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox TextAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.TextAlignmentProperty, binding);
public static TextBox TextAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox TextAlignment(this TextBox control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextAlignmentProperty, func, onChanged, expression);
public static TextBox TextAlignment(this TextBox control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextBox TextAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox HorizontalContentAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.HorizontalContentAlignmentProperty, binding);
public static TextBox HorizontalContentAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox HorizontalContentAlignment(this TextBox control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static TextBox HorizontalContentAlignment(this TextBox control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static TextBox HorizontalContentAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox VerticalContentAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.VerticalContentAlignmentProperty, binding);
public static TextBox VerticalContentAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox VerticalContentAlignment(this TextBox control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.VerticalContentAlignmentProperty, func, onChanged, expression);
public static TextBox VerticalContentAlignment(this TextBox control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static TextBox VerticalContentAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox TextWrapping(this TextBox control, IBinding binding)
   => control._set(TextBox.TextWrappingProperty, binding);
public static TextBox TextWrapping(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox TextWrapping(this TextBox control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextWrappingProperty, func, onChanged, expression);
public static TextBox TextWrapping(this TextBox control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextBox TextWrapping<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox LineHeight(this TextBox control, IBinding binding)
   => control._set(TextBox.LineHeightProperty, binding);
public static TextBox LineHeight(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox LineHeight(this TextBox control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.LineHeightProperty, func, onChanged, expression);
public static TextBox LineHeight(this TextBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextBox LineHeight<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox LetterSpacing(this TextBox control, IBinding binding)
   => control._set(TextBox.LetterSpacingProperty, binding);
public static TextBox LetterSpacing(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox LetterSpacing(this TextBox control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.LetterSpacingProperty, func, onChanged, expression);
public static TextBox LetterSpacing(this TextBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextBox LetterSpacing<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox Watermark(this TextBox control, IBinding binding)
   => control._set(TextBox.WatermarkProperty, binding);
public static TextBox Watermark(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox Watermark(this TextBox control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.WatermarkProperty, func, onChanged, expression);
public static TextBox Watermark(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static TextBox Watermark<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox UseFloatingWatermark(this TextBox control, IBinding binding)
   => control._set(TextBox.UseFloatingWatermarkProperty, binding);
public static TextBox UseFloatingWatermark(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox UseFloatingWatermark(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.UseFloatingWatermarkProperty, func, onChanged, expression);
public static TextBox UseFloatingWatermark(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static TextBox UseFloatingWatermark<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox NewLine(this TextBox control, IBinding binding)
   => control._set(TextBox.NewLineProperty, binding);
public static TextBox NewLine(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox NewLine(this TextBox control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.NewLineProperty, func, onChanged, expression);
public static TextBox NewLine(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = value, bindingMode, converter, bindingSource);
public static TextBox NewLine<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox InnerLeftContent(this TextBox control, IBinding binding)
   => control._set(TextBox.InnerLeftContentProperty, binding);
public static TextBox InnerLeftContent(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox InnerLeftContent(this TextBox control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.InnerLeftContentProperty, func, onChanged, expression);
public static TextBox InnerLeftContent(this TextBox control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static TextBox InnerLeftContent<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox InnerRightContent(this TextBox control, IBinding binding)
   => control._set(TextBox.InnerRightContentProperty, binding);
public static TextBox InnerRightContent(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox InnerRightContent(this TextBox control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.InnerRightContentProperty, func, onChanged, expression);
public static TextBox InnerRightContent(this TextBox control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static TextBox InnerRightContent<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox RevealPassword(this TextBox control, IBinding binding)
   => control._set(TextBox.RevealPasswordProperty, binding);
public static TextBox RevealPassword(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox RevealPassword(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.RevealPasswordProperty, func, onChanged, expression);
public static TextBox RevealPassword(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static TextBox RevealPassword<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox IsUndoEnabled(this TextBox control, IBinding binding)
   => control._set(TextBox.IsUndoEnabledProperty, binding);
public static TextBox IsUndoEnabled(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox IsUndoEnabled(this TextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.IsUndoEnabledProperty, func, onChanged, expression);
public static TextBox IsUndoEnabled(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value, bindingMode, converter, bindingSource);
public static TextBox IsUndoEnabled<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox UndoLimit(this TextBox control, IBinding binding)
   => control._set(TextBox.UndoLimitProperty, binding);
public static TextBox UndoLimit(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBox UndoLimit(this TextBox control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.UndoLimitProperty, func, onChanged, expression);
public static TextBox UndoLimit(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value, bindingMode, converter, bindingSource);
public static TextBox UndoLimit<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

