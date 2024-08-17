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
using TemplatedControl = Avalonia.Controls.Primitives.TemplatedControl;

namespace Avalonia.Markup.Declarative;
public static partial class TemplatedControlExtensions
{
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, binding);
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, value);
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, binding);
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, value);
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, binding);
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, value);
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, binding);

public static Style<T> BorderThickness<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> BorderThickness<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> BorderThickness<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, binding);
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, value);
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, binding);
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> Template<T>(this Style<T> style, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value);
public static Style<T> Template<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, binding);
}

