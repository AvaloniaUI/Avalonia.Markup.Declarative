using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextElementExtensions
{
public static Style<TextElement> Background(this Style<TextElement> style, IBrush value)
=> style._addSetter(TextElement.BackgroundProperty, value);
public static Style<TextElement> Background(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.BackgroundProperty, binding);
public static Style<TextElement> FontFamily(this Style<TextElement> style, FontFamily value)
=> style._addSetter(TextElement.FontFamilyProperty, value);
public static Style<TextElement> FontFamily(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontFamilyProperty, binding);
public static Style<TextElement> FontFeatures(this Style<TextElement> style, FontFeatureCollection value)
=> style._addSetter(TextElement.FontFeaturesProperty, value);
public static Style<TextElement> FontFeatures(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontFeaturesProperty, binding);
public static Style<TextElement> FontSize(this Style<TextElement> style, Double value)
=> style._addSetter(TextElement.FontSizeProperty, value);
public static Style<TextElement> FontSize(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontSizeProperty, binding);
public static Style<TextElement> FontStyle(this Style<TextElement> style, FontStyle value)
=> style._addSetter(TextElement.FontStyleProperty, value);
public static Style<TextElement> FontStyle(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontStyleProperty, binding);
public static Style<TextElement> FontWeight(this Style<TextElement> style, FontWeight value)
=> style._addSetter(TextElement.FontWeightProperty, value);
public static Style<TextElement> FontWeight(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontWeightProperty, binding);
public static Style<TextElement> FontStretch(this Style<TextElement> style, FontStretch value)
=> style._addSetter(TextElement.FontStretchProperty, value);
public static Style<TextElement> FontStretch(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.FontStretchProperty, binding);
public static Style<TextElement> Foreground(this Style<TextElement> style, IBrush value)
=> style._addSetter(TextElement.ForegroundProperty, value);
public static Style<TextElement> Foreground(this Style<TextElement> style, IBinding binding)
=> style._addSetter(TextElement.ForegroundProperty, binding);
}

