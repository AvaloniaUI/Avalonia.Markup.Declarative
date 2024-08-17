using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextBlock = Avalonia.Controls.TextBlock;

namespace Avalonia.Markup.Declarative;
public static partial class TextBlockExtensions
{
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.TextBlock
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.TextBlock
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.TextBlock
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, binding);
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, binding);
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, value);
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, value);
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);
}

