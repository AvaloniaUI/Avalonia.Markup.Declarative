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
public static TextBlock Background(this TextBlock control, IBinding binding)
   => control._set(TextBlock.BackgroundProperty, binding);
public static TextBlock Background(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock Background(this TextBlock control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.BackgroundProperty, func, onChanged, expression);
public static TextBlock Background(this TextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextBlock Background<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Padding(this TextBlock control, IBinding binding)
   => control._set(TextBlock.PaddingProperty, binding);
public static TextBlock Padding(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock Padding(this TextBlock control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.PaddingProperty, func, onChanged, expression);
public static TextBlock Padding(this TextBlock control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static TextBlock Padding<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TextBlock Padding(this TextBlock control, Double uniformLength = default)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static TextBlock Padding(this TextBlock control, Double horizontal = default, Double vertical = default)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static TextBlock Padding(this TextBlock control, Double left = default, Double top = default, Double right = default, Double bottom = default)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static TextBlock FontFamily(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontFamilyProperty, binding);
public static TextBlock FontFamily(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontFamily(this TextBlock control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontFamilyProperty, func, onChanged, expression);
public static TextBlock FontFamily(this TextBlock control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static TextBlock FontFamily<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontSize(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontSizeProperty, binding);
public static TextBlock FontSize(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontSize(this TextBlock control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontSizeProperty, func, onChanged, expression);
public static TextBlock FontSize(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static TextBlock FontSize<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontStyle(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontStyleProperty, binding);
public static TextBlock FontStyle(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontStyle(this TextBlock control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontStyleProperty, func, onChanged, expression);
public static TextBlock FontStyle(this TextBlock control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static TextBlock FontStyle<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontWeight(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontWeightProperty, binding);
public static TextBlock FontWeight(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontWeight(this TextBlock control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontWeightProperty, func, onChanged, expression);
public static TextBlock FontWeight(this TextBlock control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static TextBlock FontWeight<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontStretch(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontStretchProperty, binding);
public static TextBlock FontStretch(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontStretch(this TextBlock control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontStretchProperty, func, onChanged, expression);
public static TextBlock FontStretch(this TextBlock control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static TextBlock FontStretch<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Foreground(this TextBlock control, IBinding binding)
   => control._set(TextBlock.ForegroundProperty, binding);
public static TextBlock Foreground(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock Foreground(this TextBlock control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.ForegroundProperty, func, onChanged, expression);
public static TextBlock Foreground(this TextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static TextBlock Foreground<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock BaselineOffset(this TextBlock control, IBinding binding)
   => control._set(TextBlock.BaselineOffsetProperty, binding);
public static TextBlock BaselineOffset(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.BaselineOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock BaselineOffset(this TextBlock control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.BaselineOffsetProperty, func, onChanged, expression);
public static TextBlock BaselineOffset(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = value, bindingMode, converter, bindingSource);
public static TextBlock BaselineOffset<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock LineHeight(this TextBlock control, IBinding binding)
   => control._set(TextBlock.LineHeightProperty, binding);
public static TextBlock LineHeight(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock LineHeight(this TextBlock control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.LineHeightProperty, func, onChanged, expression);
public static TextBlock LineHeight(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextBlock LineHeight<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock LineSpacing(this TextBlock control, IBinding binding)
   => control._set(TextBlock.LineSpacingProperty, binding);
public static TextBlock LineSpacing(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.LineSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock LineSpacing(this TextBlock control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.LineSpacingProperty, func, onChanged, expression);
public static TextBlock LineSpacing(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = value, bindingMode, converter, bindingSource);
public static TextBlock LineSpacing<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineSpacingProperty, ps, () => control.LineSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock LetterSpacing(this TextBlock control, IBinding binding)
   => control._set(TextBlock.LetterSpacingProperty, binding);
public static TextBlock LetterSpacing(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.LetterSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock LetterSpacing(this TextBlock control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.LetterSpacingProperty, func, onChanged, expression);
public static TextBlock LetterSpacing(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextBlock LetterSpacing<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock MaxLines(this TextBlock control, IBinding binding)
   => control._set(TextBlock.MaxLinesProperty, binding);
public static TextBlock MaxLines(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock MaxLines(this TextBlock control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.MaxLinesProperty, func, onChanged, expression);
public static TextBlock MaxLines(this TextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static TextBlock MaxLines<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Text(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextProperty, binding);
public static TextBlock Text(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock Text(this TextBlock control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextProperty, func, onChanged, expression);
public static TextBlock Text(this TextBlock control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextBlock Text<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextAlignment(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextAlignmentProperty, binding);
public static TextBlock TextAlignment(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock TextAlignment(this TextBlock control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextAlignmentProperty, func, onChanged, expression);
public static TextBlock TextAlignment(this TextBlock control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextBlock TextAlignment<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextWrapping(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextWrappingProperty, binding);
public static TextBlock TextWrapping(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock TextWrapping(this TextBlock control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextWrappingProperty, func, onChanged, expression);
public static TextBlock TextWrapping(this TextBlock control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextBlock TextWrapping<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextTrimming(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextTrimmingProperty, binding);
public static TextBlock TextTrimming(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock TextTrimming(this TextBlock control, Func<TextTrimming> func, Action<TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextTrimmingProperty, func, onChanged, expression);
public static TextBlock TextTrimming(this TextBlock control, TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static TextBlock TextTrimming<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextDecorations(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextDecorationsProperty, binding);
public static TextBlock TextDecorations(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock TextDecorations(this TextBlock control, Func<TextDecorationCollection> func, Action<TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextDecorationsProperty, func, onChanged, expression);
public static TextBlock TextDecorations(this TextBlock control, TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static TextBlock TextDecorations<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontFeatures(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontFeaturesProperty, binding);
public static TextBlock FontFeatures(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock FontFeatures(this TextBlock control, Func<FontFeatureCollection> func, Action<FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontFeaturesProperty, func, onChanged, expression);
public static TextBlock FontFeatures(this TextBlock control, FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);
public static TextBlock FontFeatures<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Inlines(this TextBlock control, IBinding binding)
   => control._set(TextBlock.InlinesProperty, binding);
public static TextBlock Inlines(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextBlock.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextBlock Inlines(this TextBlock control, Func<InlineCollection> func, Action<InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.InlinesProperty, func, onChanged, expression);
public static TextBlock Inlines(this TextBlock control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static TextBlock Inlines<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

