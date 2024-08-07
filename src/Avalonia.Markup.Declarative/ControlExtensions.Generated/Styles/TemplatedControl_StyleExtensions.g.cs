using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TemplatedControlExtensions
{
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BackgroundProperty, binding);
public static Style<T> BackgroundSizing<T>(this Style<T> style, BackgroundSizing value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BackgroundSizingProperty, value);
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BackgroundSizingProperty, binding);
public static Style<T> BorderBrush<T>(this Style<T> style, IBrush value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BorderBrushProperty, value);
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BorderBrushProperty, binding);
public static Style<T> BorderThickness<T>(this Style<T> style, Thickness value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BorderThicknessProperty, value);
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.BorderThicknessProperty, binding);

public static Style<T> BorderThickness<T>(this Style<T> style, Double uniformLength) where T : TemplatedControl
   => style._addSetter(TemplatedControl.BorderThicknessProperty, new Thickness(uniformLength));
public static Style<T> BorderThickness<T>(this Style<T> style, Double horizontal, Double vertical) where T : TemplatedControl
   => style._addSetter(TemplatedControl.BorderThicknessProperty, new Thickness(horizontal, vertical));
public static Style<T> BorderThickness<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => style._addSetter(TemplatedControl.BorderThicknessProperty, new Thickness(left, top, right, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, CornerRadius value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : TemplatedControl
   => style._addSetter(TemplatedControl.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : TemplatedControl
   => style._addSetter(TemplatedControl.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : TemplatedControl
   => style._addSetter(TemplatedControl.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> FontFamily<T>(this Style<T> style, FontFamily value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontFamilyProperty, binding);
public static Style<T> FontFeatures<T>(this Style<T> style, FontFeatureCollection value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontFeaturesProperty, value);
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontFeaturesProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, Double value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, FontStyle value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, FontWeight value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, FontStretch value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.FontStretchProperty, binding);
public static Style<T> Foreground<T>(this Style<T> style, IBrush value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.ForegroundProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Thickness value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : TemplatedControl
   => style._addSetter(TemplatedControl.PaddingProperty, new Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : TemplatedControl
   => style._addSetter(TemplatedControl.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => style._addSetter(TemplatedControl.PaddingProperty, new Thickness(left, top, right, bottom));
public static Style<T> Template<T>(this Style<T> style, IControlTemplate value) where T : TemplatedControl
=> style._addSetter(TemplatedControl.TemplateProperty, value);
public static Style<T> Template<T>(this Style<T> style, IBinding binding) where T : TemplatedControl
=> style._addSetter(TemplatedControl.TemplateProperty, binding);
}

