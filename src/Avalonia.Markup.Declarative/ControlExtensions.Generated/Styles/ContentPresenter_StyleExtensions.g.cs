using Avalonia;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContentPresenterExtensions
{
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BackgroundProperty, binding);
public static Style<T> BackgroundSizing<T>(this Style<T> style, BackgroundSizing value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BackgroundSizingProperty, value);
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BackgroundSizingProperty, binding);
public static Style<T> BorderBrush<T>(this Style<T> style, IBrush value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BorderBrushProperty, value);
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BorderBrushProperty, binding);
public static Style<T> BorderThickness<T>(this Style<T> style, Thickness value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BorderThicknessProperty, value);
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BorderThicknessProperty, binding);

public static Style<T> BorderThickness<T>(this Style<T> style, Double uniformLength) where T : ContentPresenter
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(uniformLength));
public static Style<T> BorderThickness<T>(this Style<T> style, Double horizontal, Double vertical) where T : ContentPresenter
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(horizontal, vertical));
public static Style<T> BorderThickness<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : ContentPresenter
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(left, top, right, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, CornerRadius value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : ContentPresenter
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : ContentPresenter
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : ContentPresenter
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadows value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BoxShadowProperty, value);
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.BoxShadowProperty, binding);

public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow shadow) where T : ContentPresenter
   => style._addSetter(ContentPresenter.BoxShadowProperty, new BoxShadows(shadow));
public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow first, BoxShadow[] rest) where T : ContentPresenter
   => style._addSetter(ContentPresenter.BoxShadowProperty, new BoxShadows(first, rest));
public static Style<T> Foreground<T>(this Style<T> style, IBrush value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ForegroundProperty, binding);
public static Style<T> FontFamily<T>(this Style<T> style, FontFamily value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontFamilyProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, Double value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, FontStyle value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, FontWeight value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, FontStretch value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.FontStretchProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, TextAlignment value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, TextWrapping value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextWrappingProperty, binding);
public static Style<T> TextTrimming<T>(this Style<T> style, TextTrimming value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextTrimmingProperty, value);
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.TextTrimmingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, Double value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.LineHeightProperty, binding);
public static Style<T> MaxLines<T>(this Style<T> style, Int32 value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.MaxLinesProperty, value);
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.MaxLinesProperty, binding);
public static Style<T> Content<T>(this Style<T> style, Object value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ContentProperty, value);
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ContentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.ContentTemplateProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.VerticalContentAlignmentProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Thickness value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : ContentPresenter
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : ContentPresenter
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : ContentPresenter
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(left, top, right, bottom));
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, Boolean value) where T : ContentPresenter
=> style._addSetter(ContentPresenter.RecognizesAccessKeyProperty, value);
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, IBinding binding) where T : ContentPresenter
=> style._addSetter(ContentPresenter.RecognizesAccessKeyProperty, binding);
}

