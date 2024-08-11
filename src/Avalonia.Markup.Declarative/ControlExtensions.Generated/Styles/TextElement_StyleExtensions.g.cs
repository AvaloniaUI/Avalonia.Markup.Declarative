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
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : TextElement
=> style._addSetter(TextElement.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.BackgroundProperty, binding);
public static Style<T> FontFamily<T>(this Style<T> style, FontFamily value) where T : TextElement
=> style._addSetter(TextElement.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontFamilyProperty, binding);
public static Style<T> FontFeatures<T>(this Style<T> style, FontFeatureCollection value) where T : TextElement
=> style._addSetter(TextElement.FontFeaturesProperty, value);
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontFeaturesProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, Double value) where T : TextElement
=> style._addSetter(TextElement.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, FontStyle value) where T : TextElement
=> style._addSetter(TextElement.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, FontWeight value) where T : TextElement
=> style._addSetter(TextElement.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, FontStretch value) where T : TextElement
=> style._addSetter(TextElement.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.FontStretchProperty, binding);
public static Style<T> Foreground<T>(this Style<T> style, IBrush value) where T : TextElement
=> style._addSetter(TextElement.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : TextElement
=> style._addSetter(TextElement.ForegroundProperty, binding);
}

