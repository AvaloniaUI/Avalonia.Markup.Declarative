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
public static partial class TextBlock_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Padding

/*BindFromExpressionSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Padding<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Padding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamily

/*BindFromExpressionSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFamily<T>(this T control,Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFamily<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontSize

/*BindFromExpressionSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStyle

/*BindFromExpressionSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStyle<T>(this T control,Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontWeight

/*BindFromExpressionSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontWeight<T>(this T control,Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontWeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStretch

/*BindFromExpressionSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStretch<T>(this T control,Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Foreground

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BaselineOffset

/*BindFromExpressionSetterGenerator*/
public static T BaselineOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BaselineOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BaselineOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BaselineOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BaselineOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineHeight

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LineHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LineHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineSpacing

/*BindFromExpressionSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LineSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LineSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LetterSpacing

/*BindFromExpressionSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LetterSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LetterSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LetterSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxLines

/*BindFromExpressionSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxLines<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignment

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextWrapping

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextWrapping<T>(this T control,Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextWrapping<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextTrimming

/*BindFromExpressionSetterGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextTrimming<T>(this T control,Avalonia.Media.TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextTrimming<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextTrimming<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextTrimming<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextDecorations

/*BindFromExpressionSetterGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextDecorations<T>(this T control,Avalonia.Media.TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextDecorations<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFeatures

/*BindFromExpressionSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFeatures<T>(this T control,Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFeatures<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFeatures<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Inlines

/*BindFromExpressionSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Inlines<T>(this T control,Avalonia.Controls.Documents.InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Inlines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Inlines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Documents.InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock 
=> control._setEx(Avalonia.Controls.TextBlock.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // BaselineOffset

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.BaselineOffsetProperty, ps, () => Avalonia.Controls.TextBlock.SetBaselineOffset(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty, func, onChanged, expression);


 // LineHeight

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.LineHeightProperty, ps, () => Avalonia.Controls.TextBlock.SetLineHeight(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty, func, onChanged, expression);


 // LetterSpacing

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.LetterSpacingProperty, ps, () => Avalonia.Controls.TextBlock.SetLetterSpacing(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty, func, onChanged, expression);


 // MaxLines

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.MaxLinesProperty, ps, () => Avalonia.Controls.TextBlock.SetMaxLines(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty, func, onChanged, expression);


 // TextAlignment

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextAlignmentProperty, ps, () => Avalonia.Controls.TextBlock.SetTextAlignment(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty, func, onChanged, expression);


 // TextWrapping

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextWrappingProperty, ps, () => Avalonia.Controls.TextBlock.SetTextWrapping(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty, func, onChanged, expression);


 // TextTrimming

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextTrimmingProperty, ps, () => Avalonia.Controls.TextBlock.SetTextTrimming(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty, func, onChanged, expression);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, binding);


 // BaselineOffset

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, binding);


 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);



}
