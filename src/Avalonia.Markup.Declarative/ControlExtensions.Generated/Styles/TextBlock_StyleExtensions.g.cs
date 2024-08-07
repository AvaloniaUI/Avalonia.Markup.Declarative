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
public static Style<TextBlock> Background(this Style<TextBlock> style, IBrush value)
=> style._addSetter(TextBlock.BackgroundProperty, value);
public static Style<TextBlock> Background(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.BackgroundProperty, binding);
public static Style<TextBlock> Padding(this Style<TextBlock> style, Thickness value)
=> style._addSetter(TextBlock.PaddingProperty, value);
public static Style<TextBlock> Padding(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.PaddingProperty, binding);

public static Style<TextBlock> Padding(this Style<TextBlock> style, Double uniformLength)
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(uniformLength));
public static Style<TextBlock> Padding(this Style<TextBlock> style, Double horizontal, Double vertical)
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<TextBlock> Padding(this Style<TextBlock> style, Double left, Double top, Double right, Double bottom)
   => style._addSetter(TextBlock.PaddingProperty, new Thickness(left, top, right, bottom));
public static Style<TextBlock> FontFamily(this Style<TextBlock> style, FontFamily value)
=> style._addSetter(TextBlock.FontFamilyProperty, value);
public static Style<TextBlock> FontFamily(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontFamilyProperty, binding);
public static Style<TextBlock> FontSize(this Style<TextBlock> style, Double value)
=> style._addSetter(TextBlock.FontSizeProperty, value);
public static Style<TextBlock> FontSize(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontSizeProperty, binding);
public static Style<TextBlock> FontStyle(this Style<TextBlock> style, FontStyle value)
=> style._addSetter(TextBlock.FontStyleProperty, value);
public static Style<TextBlock> FontStyle(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontStyleProperty, binding);
public static Style<TextBlock> FontWeight(this Style<TextBlock> style, FontWeight value)
=> style._addSetter(TextBlock.FontWeightProperty, value);
public static Style<TextBlock> FontWeight(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontWeightProperty, binding);
public static Style<TextBlock> FontStretch(this Style<TextBlock> style, FontStretch value)
=> style._addSetter(TextBlock.FontStretchProperty, value);
public static Style<TextBlock> FontStretch(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontStretchProperty, binding);
public static Style<TextBlock> Foreground(this Style<TextBlock> style, IBrush value)
=> style._addSetter(TextBlock.ForegroundProperty, value);
public static Style<TextBlock> Foreground(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.ForegroundProperty, binding);
public static Style<TextBlock> BaselineOffset(this Style<TextBlock> style, Double value)
=> style._addSetter(TextBlock.BaselineOffsetProperty, value);
public static Style<TextBlock> BaselineOffset(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.BaselineOffsetProperty, binding);
public static Style<TextBlock> LineHeight(this Style<TextBlock> style, Double value)
=> style._addSetter(TextBlock.LineHeightProperty, value);
public static Style<TextBlock> LineHeight(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.LineHeightProperty, binding);
public static Style<TextBlock> LineSpacing(this Style<TextBlock> style, Double value)
=> style._addSetter(TextBlock.LineSpacingProperty, value);
public static Style<TextBlock> LineSpacing(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.LineSpacingProperty, binding);
public static Style<TextBlock> LetterSpacing(this Style<TextBlock> style, Double value)
=> style._addSetter(TextBlock.LetterSpacingProperty, value);
public static Style<TextBlock> LetterSpacing(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.LetterSpacingProperty, binding);
public static Style<TextBlock> MaxLines(this Style<TextBlock> style, Int32 value)
=> style._addSetter(TextBlock.MaxLinesProperty, value);
public static Style<TextBlock> MaxLines(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.MaxLinesProperty, binding);
public static Style<TextBlock> Text(this Style<TextBlock> style, String value)
=> style._addSetter(TextBlock.TextProperty, value);
public static Style<TextBlock> Text(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.TextProperty, binding);
public static Style<TextBlock> TextAlignment(this Style<TextBlock> style, TextAlignment value)
=> style._addSetter(TextBlock.TextAlignmentProperty, value);
public static Style<TextBlock> TextAlignment(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.TextAlignmentProperty, binding);
public static Style<TextBlock> TextWrapping(this Style<TextBlock> style, TextWrapping value)
=> style._addSetter(TextBlock.TextWrappingProperty, value);
public static Style<TextBlock> TextWrapping(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.TextWrappingProperty, binding);
public static Style<TextBlock> TextTrimming(this Style<TextBlock> style, TextTrimming value)
=> style._addSetter(TextBlock.TextTrimmingProperty, value);
public static Style<TextBlock> TextTrimming(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.TextTrimmingProperty, binding);
public static Style<TextBlock> TextDecorations(this Style<TextBlock> style, TextDecorationCollection value)
=> style._addSetter(TextBlock.TextDecorationsProperty, value);
public static Style<TextBlock> TextDecorations(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.TextDecorationsProperty, binding);
public static Style<TextBlock> FontFeatures(this Style<TextBlock> style, FontFeatureCollection value)
=> style._addSetter(TextBlock.FontFeaturesProperty, value);
public static Style<TextBlock> FontFeatures(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.FontFeaturesProperty, binding);
public static Style<TextBlock> Inlines(this Style<TextBlock> style, InlineCollection value)
=> style._addSetter(TextBlock.InlinesProperty, value);
public static Style<TextBlock> Inlines(this Style<TextBlock> style, IBinding binding)
=> style._addSetter(TextBlock.InlinesProperty, binding);
}

