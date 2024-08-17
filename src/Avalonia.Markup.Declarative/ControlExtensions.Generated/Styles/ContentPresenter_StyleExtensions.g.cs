using Avalonia;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using ContentPresenter = Avalonia.Controls.Presenters.ContentPresenter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContentPresenterExtensions
{
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, value);
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, value);
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, value);
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);

public static Style<T> BorderThickness<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> BorderThickness<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> BorderThickness<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, value);
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);

public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow shadow) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));
public static Style<T> BoxShadow<T>(this Style<T> style, BoxShadow first, BoxShadow[] rest) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, value);
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, value);
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, value);
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, value);
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, value);
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, value);
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, value);
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, value);
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, value);
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, value);
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, value);
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, value);
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);
}

