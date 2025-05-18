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
public static partial class TextBox_MarkupExtensions
{
//================= Properties ======================//
 // IsInactiveSelectionHighlightEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsInactiveSelectionHighlightEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, ps, () => control.IsInactiveSelectionHighlightEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsInactiveSelectionHighlightEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, ps, () => control.IsInactiveSelectionHighlightEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ClearSelectionOnLostFocus

/*BindFromExpressionSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ClearSelectionOnLostFocus<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, ps, () => control.ClearSelectionOnLostFocus = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ClearSelectionOnLostFocus<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, ps, () => control.ClearSelectionOnLostFocus = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AcceptsReturn

/*BindFromExpressionSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AcceptsReturn<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AcceptsReturn<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AcceptsTab

/*BindFromExpressionSetterGenerator*/
public static T AcceptsTab<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AcceptsTab<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptsTab<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsTab<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AcceptsTab<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CaretIndex

/*BindFromExpressionSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CaretIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CaretIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsReadOnly

/*BindFromExpressionSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsReadOnly<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsReadOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsReadOnly<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PasswordChar

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PasswordChar<T>(this T control,System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PasswordChar<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionBrush

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionForegroundBrush

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CaretBrush

/*BindFromExpressionSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CaretBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CaretBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CaretBlinkInterval

/*BindFromExpressionSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CaretBlinkInterval<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CaretBlinkInterval<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, ps, () => control.CaretBlinkInterval = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionStart

/*BindFromExpressionSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionStart<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionStart<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionEnd

/*BindFromExpressionSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionEnd<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionEnd<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxLength

/*BindFromExpressionSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxLength<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MaxLengthProperty, ps, () => control.MaxLength = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxLines

/*BindFromExpressionSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxLines<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MaxLinesProperty, ps, () => control.MaxLines = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinLines

/*BindFromExpressionSetterGenerator*/
public static T MinLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinLines<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MinLinesProperty, ps, () => control.MinLines = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.MinLinesProperty, ps, () => control.MinLines = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextProperty, ps, () => control.Text = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextProperty, ps, () => control.Text = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TextAlignment

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TextWrapping

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TextWrapping<T>(this T control,Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TextWrapping<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LineHeight

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LineHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.LineHeightProperty, ps, () => control.LineHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LineHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LetterSpacing

/*BindFromExpressionSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LetterSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LetterSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Watermark

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.WatermarkProperty, ps, () => control.Watermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UseFloatingWatermark

/*BindFromExpressionSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UseFloatingWatermark<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UseFloatingWatermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // NewLine

/*BindFromExpressionSetterGenerator*/
public static T NewLine<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T NewLine<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.NewLineProperty, ps, () => control.NewLine = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NewLine<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NewLine<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T NewLine<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.NewLineProperty, ps, () => control.NewLine = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerLeftContent

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerRightContent

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RevealPassword

/*BindFromExpressionSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RevealPassword<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RevealPassword<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RevealPassword<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RevealPassword<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsUndoEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsUndoEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsUndoEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UndoLimit

/*BindFromExpressionSetterGenerator*/
public static T UndoLimit<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UndoLimit<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UndoLimit<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UndoLimit<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UndoLimit<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TextBox 
=> control._setEx(Avalonia.Controls.TextBox.UndoLimitProperty, ps, () => control.UndoLimit = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}



 // CuttingToClipboard

/*ActionToEventGenerator*/
public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CuttingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CuttingToClipboardEvent.RoutingStrategies);
  return control;
}



 // PastingFromClipboard

/*ActionToEventGenerator*/
public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.PastingFromClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.PastingFromClipboardEvent.RoutingStrategies);
  return control;
}



 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // TextChanging

/*ActionToEventGenerator*/
public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);


 // ClearSelectionOnLostFocus

/*ValueStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);


 // AcceptsReturn

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);


 // AcceptsTab

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);


 // MinLines

/*ValueStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);


 // NewLine

/*ValueStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);


 // IsUndoEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);


 // UndoLimit

/*ValueStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);



}
