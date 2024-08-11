#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextBlockExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Padding<T>(this T control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.PaddingProperty, func, onChanged, expression);
public static T Padding<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength = default) where T : TextBlock
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal = default, Double vertical = default) where T : TextBlock
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : TextBlock
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static T FontFamily<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontFamilyProperty, binding);
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFamily<T>(this T control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontFamilyProperty, func, onChanged, expression);
public static T FontFamily<T>(this T control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontSize<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontSizeProperty, binding);
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontSize<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontSizeProperty, func, onChanged, expression);
public static T FontSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStyle<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontStyleProperty, binding);
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStyle<T>(this T control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontStyleProperty, func, onChanged, expression);
public static T FontStyle<T>(this T control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontWeight<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontWeightProperty, binding);
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontWeight<T>(this T control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontWeightProperty, func, onChanged, expression);
public static T FontWeight<T>(this T control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStretch<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontStretchProperty, binding);
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStretch<T>(this T control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontStretchProperty, func, onChanged, expression);
public static T FontStretch<T>(this T control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Foreground<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.ForegroundProperty, binding);
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Foreground<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.ForegroundProperty, func, onChanged, expression);
public static T Foreground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BaselineOffset<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.BaselineOffsetProperty, binding);
public static T BaselineOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.BaselineOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BaselineOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.BaselineOffsetProperty, func, onChanged, expression);
public static T BaselineOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = value, bindingMode, converter, bindingSource);
public static T BaselineOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineHeight<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.LineHeightProperty, binding);
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.LineHeightProperty, func, onChanged, expression);
public static T LineHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineSpacing<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.LineSpacingProperty, binding);
public static T LineSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.LineSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineSpacing<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.LineSpacingProperty, func, onChanged, expression);
public static T LineSpacing<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = value, bindingMode, converter, bindingSource);
public static T LineSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LetterSpacing<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.LetterSpacingProperty, binding);
public static T LetterSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LetterSpacing<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.LetterSpacingProperty, func, onChanged, expression);
public static T LetterSpacing<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static T LetterSpacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLines<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.MaxLinesProperty, binding);
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLines<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.MaxLinesProperty, func, onChanged, expression);
public static T MaxLines<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static T MaxLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextWrapping<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.TextWrappingProperty, binding);
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextWrapping<T>(this T control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.TextWrappingProperty, func, onChanged, expression);
public static T TextWrapping<T>(this T control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextTrimming<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.TextTrimmingProperty, binding);
public static T TextTrimming<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextTrimming<T>(this T control, Func<TextTrimming> func, Action<TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.TextTrimmingProperty, func, onChanged, expression);
public static T TextTrimming<T>(this T control, TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static T TextTrimming<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextDecorations<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.TextDecorationsProperty, binding);
public static T TextDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextDecorations<T>(this T control, Func<TextDecorationCollection> func, Action<TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.TextDecorationsProperty, func, onChanged, expression);
public static T TextDecorations<T>(this T control, TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static T TextDecorations<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontFeatures<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.FontFeaturesProperty, binding);
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFeatures<T>(this T control, Func<FontFeatureCollection> func, Action<FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.FontFeaturesProperty, func, onChanged, expression);
public static T FontFeatures<T>(this T control, FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);
public static T FontFeatures<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Inlines<T>(this T control, IBinding binding) where T : TextBlock
   => control._set(TextBlock.InlinesProperty, binding);
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextBlock
   => control._set(TextBlock.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Inlines<T>(this T control, Func<InlineCollection> func, Action<InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextBlock
   => control._set(TextBlock.InlinesProperty, func, onChanged, expression);
public static T Inlines<T>(this T control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static T Inlines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextBlock
=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

