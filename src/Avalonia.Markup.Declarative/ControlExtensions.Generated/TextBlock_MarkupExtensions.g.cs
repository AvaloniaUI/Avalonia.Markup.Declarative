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
public static partial class TextBlock_MarkupExtensions
{
//================= Properties ======================//
 // BackgroundProperty

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PaddingProperty

/*BindFromExpressionSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
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
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamilyProperty

/*BindFromExpressionSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontSizeProperty

/*BindFromExpressionSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStyleProperty

/*BindFromExpressionSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontWeightProperty

/*BindFromExpressionSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStretchProperty

/*BindFromExpressionSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ForegroundProperty

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BaselineOffsetProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty, func, onChanged, expression);


 // LineHeightProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty, func, onChanged, expression);


 // LineSpacingProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty, func, onChanged, expression);


 // LetterSpacingProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty, func, onChanged, expression);


 // MaxLinesProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty, func, onChanged, expression);


 // TextProperty

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty, func, onChanged, expression);


 // TextWrappingProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty, func, onChanged, expression);


 // TextTrimmingProperty

/*BindFromExpressionSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty, func, onChanged, expression);


 // TextDecorationsProperty

/*BindFromExpressionSetterGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextDecorations<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFeaturesProperty

/*BindFromExpressionSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFeatures<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFeatures<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InlinesProperty

/*BindFromExpressionSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Inlines<T>(this T control, IBinding binding) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TextBlock
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Inlines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Documents.InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TextBlock
=> control._setEx(Avalonia.Controls.TextBlock.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // BaselineOffsetProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.BaselineOffsetProperty, ps, () => Avalonia.Controls.TextBlock.SetBaselineOffset(control, value), bindingMode, converter, bindingSource);


 // LineHeightProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.LineHeightProperty, ps, () => Avalonia.Controls.TextBlock.SetLineHeight(control, value), bindingMode, converter, bindingSource);


 // LetterSpacingProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.LetterSpacingProperty, ps, () => Avalonia.Controls.TextBlock.SetLetterSpacing(control, value), bindingMode, converter, bindingSource);


 // MaxLinesProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.MaxLinesProperty, ps, () => Avalonia.Controls.TextBlock.SetMaxLines(control, value), bindingMode, converter, bindingSource);


 // TextAlignmentProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextAlignmentProperty, ps, () => Avalonia.Controls.TextBlock.SetTextAlignment(control, value), bindingMode, converter, bindingSource);


 // TextWrappingProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextWrappingProperty, ps, () => Avalonia.Controls.TextBlock.SetTextWrapping(control, value), bindingMode, converter, bindingSource);


 // TextTrimmingProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TextBlock.TextTrimmingProperty, ps, () => Avalonia.Controls.TextBlock.SetTextTrimming(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // BackgroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, binding);


 // PaddingProperty

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


 // FontFamilyProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);


 // FontSizeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, binding);


 // FontStyleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, binding);


 // FontWeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, binding);


 // FontStretchProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, binding);


 // ForegroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, binding);


 // BaselineOffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_BaselineOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_BaselineOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, binding);


 // LineHeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, binding);


 // LineSpacingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, binding);


 // LetterSpacingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, binding);


 // MaxLinesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, binding);


 // TextProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, binding);


 // TextAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, binding);


 // TextWrappingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, binding);


 // TextTrimmingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextBlock_TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextBlock_TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, binding);


 // TextDecorationsProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);


 // FontFeaturesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);



}
