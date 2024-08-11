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
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : TextBlock
=> style._addSetter(TextBlock.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.BackgroundProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Thickness value) where T : TextBlock
=> style._addSetter(TextBlock.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : TextBlock
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : TextBlock
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : TextBlock
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(left, top, right, bottom));
public static Style<T> FontFamily<T>(this Style<T> style, FontFamily value) where T : TextBlock
=> style._addSetter(TextBlock.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontFamilyProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, Double value) where T : TextBlock
=> style._addSetter(TextBlock.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, FontStyle value) where T : TextBlock
=> style._addSetter(TextBlock.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, FontWeight value) where T : TextBlock
=> style._addSetter(TextBlock.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, FontStretch value) where T : TextBlock
=> style._addSetter(TextBlock.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontStretchProperty, binding);
public static Style<T> Foreground<T>(this Style<T> style, IBrush value) where T : TextBlock
=> style._addSetter(TextBlock.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.ForegroundProperty, binding);
public static Style<T> BaselineOffset<T>(this Style<T> style, Double value) where T : TextBlock
=> style._addSetter(TextBlock.BaselineOffsetProperty, value);
public static Style<T> BaselineOffset<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.BaselineOffsetProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, Double value) where T : TextBlock
=> style._addSetter(TextBlock.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.LineHeightProperty, binding);
public static Style<T> LineSpacing<T>(this Style<T> style, Double value) where T : TextBlock
=> style._addSetter(TextBlock.LineSpacingProperty, value);
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.LineSpacingProperty, binding);
public static Style<T> LetterSpacing<T>(this Style<T> style, Double value) where T : TextBlock
=> style._addSetter(TextBlock.LetterSpacingProperty, value);
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.LetterSpacingProperty, binding);
public static Style<T> MaxLines<T>(this Style<T> style, Int32 value) where T : TextBlock
=> style._addSetter(TextBlock.MaxLinesProperty, value);
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.MaxLinesProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : TextBlock
=> style._addSetter(TextBlock.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.TextProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, TextAlignment value) where T : TextBlock
=> style._addSetter(TextBlock.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.TextAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, TextWrapping value) where T : TextBlock
=> style._addSetter(TextBlock.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.TextWrappingProperty, binding);
public static Style<T> TextTrimming<T>(this Style<T> style, TextTrimming value) where T : TextBlock
=> style._addSetter(TextBlock.TextTrimmingProperty, value);
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.TextTrimmingProperty, binding);
public static Style<T> TextDecorations<T>(this Style<T> style, TextDecorationCollection value) where T : TextBlock
=> style._addSetter(TextBlock.TextDecorationsProperty, value);
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.TextDecorationsProperty, binding);
public static Style<T> FontFeatures<T>(this Style<T> style, FontFeatureCollection value) where T : TextBlock
=> style._addSetter(TextBlock.FontFeaturesProperty, value);
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.FontFeaturesProperty, binding);
public static Style<T> Inlines<T>(this Style<T> style, InlineCollection value) where T : TextBlock
=> style._addSetter(TextBlock.InlinesProperty, value);
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : TextBlock
=> style._addSetter(TextBlock.InlinesProperty, binding);
}

