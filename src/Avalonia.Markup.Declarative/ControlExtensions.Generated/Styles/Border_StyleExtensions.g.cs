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
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : Border
=> style._addSetter(Border.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.BackgroundProperty, binding);
public static Style<T> BackgroundSizing<T>(this Style<T> style, BackgroundSizing value) where T : Border
=> style._addSetter(Border.BackgroundSizingProperty, value);
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.BackgroundSizingProperty, binding);
public static Style<T> BorderBrush<T>(this Style<T> style, IBrush value) where T : Border
=> style._addSetter(Border.BorderBrushProperty, value);
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.BorderBrushProperty, binding);
public static Style<T> BorderThickness<T>(this Style<T> style, Thickness value) where T : Border
=> style._addSetter(Border.BorderThicknessProperty, value);
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.BorderThicknessProperty, binding);

public static Style<T> BorderThickness<T>(this Style<T> style, Double uniformLength) where T : Border
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(uniformLength));
public static Style<T> BorderThickness<T>(this Style<T> style, Double horizontal, Double vertical) where T : Border
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(horizontal, vertical));
public static Style<T> BorderThickness<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Border
   => style._addSetter(Border.BorderThicknessProperty, new Thickness(left, top, right, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, CornerRadius value) where T : Border
=> style._addSetter(Border.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : Border
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : Border
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : Border
   => style._addSetter(Border.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadows value) where T : Border
=> style._addSetter(Border.BoxShadowProperty, value);
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Border
=> style._addSetter(Border.BoxShadowProperty, binding);

public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow shadow) where T : Border
   => style._addSetter(Border.BoxShadowProperty, new BoxShadows(shadow));
public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow first, BoxShadow[] rest) where T : Border
   => style._addSetter(Border.BoxShadowProperty, new BoxShadows(first, rest));
}

