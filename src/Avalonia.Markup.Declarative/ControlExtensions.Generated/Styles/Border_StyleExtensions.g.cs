using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class BorderExtensions
{
public static Style<Border> Background(this Style<Border> style, IBrush value)
=> style._addSetter(Border.BackgroundProperty, value);
public static Style<Border> Background(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.BackgroundProperty, binding);
public static Style<Border> BackgroundSizing(this Style<Border> style, BackgroundSizing value)
=> style._addSetter(Border.BackgroundSizingProperty, value);
public static Style<Border> BackgroundSizing(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.BackgroundSizingProperty, binding);
public static Style<Border> BorderBrush(this Style<Border> style, IBrush value)
=> style._addSetter(Border.BorderBrushProperty, value);
public static Style<Border> BorderBrush(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.BorderBrushProperty, binding);
public static Style<Border> BorderThickness(this Style<Border> style, Thickness value)
=> style._addSetter(Border.BorderThicknessProperty, value);
public static Style<Border> BorderThickness(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.BorderThicknessProperty, binding);

public static Style<Border> BorderThickness(this Style<Border> style, Double uniformLength)
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(uniformLength));
public static Style<Border> BorderThickness(this Style<Border> style, Double horizontal, Double vertical)
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(horizontal, vertical));
public static Style<Border> BorderThickness(this Style<Border> style, Double left, Double top, Double right, Double bottom)
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(left, top, right, bottom));
public static Style<Border> CornerRadius(this Style<Border> style, CornerRadius value)
=> style._addSetter(Border.CornerRadiusProperty, value);
public static Style<Border> CornerRadius(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.CornerRadiusProperty, binding);

public static Style<Border> CornerRadius(this Style<Border> style, Double uniformRadius)
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<Border> CornerRadius(this Style<Border> style, Double top, Double bottom)
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<Border> CornerRadius(this Style<Border> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<Border> BoxShadow(this Style<Border> style, BoxShadows value)
=> style._addSetter(Border.BoxShadowProperty, value);
public static Style<Border> BoxShadow(this Style<Border> style, IBinding binding)
=> style._addSetter(Border.BoxShadowProperty, binding);

public static Style<Border> BoxShadow(this Style<Border> style, BoxShadow shadow)
   => style._addSetter(Border.BoxShadowProperty, new BoxShadows(shadow));
public static Style<Border> BoxShadow(this Style<Border> style, BoxShadow first, BoxShadow[] rest)
   => style._addSetter(Border.BoxShadowProperty, new BoxShadows(first, rest));
}

