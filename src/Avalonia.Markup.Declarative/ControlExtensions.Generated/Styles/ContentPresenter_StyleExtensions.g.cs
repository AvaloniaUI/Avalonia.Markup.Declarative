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
public static Style<ContentPresenter> Background(this Style<ContentPresenter> style, IBrush value)
=> style._addSetter(ContentPresenter.BackgroundProperty, value);
public static Style<ContentPresenter> Background(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.BackgroundProperty, binding);
public static Style<ContentPresenter> BackgroundSizing(this Style<ContentPresenter> style, BackgroundSizing value)
=> style._addSetter(ContentPresenter.BackgroundSizingProperty, value);
public static Style<ContentPresenter> BackgroundSizing(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.BackgroundSizingProperty, binding);
public static Style<ContentPresenter> BorderBrush(this Style<ContentPresenter> style, IBrush value)
=> style._addSetter(ContentPresenter.BorderBrushProperty, value);
public static Style<ContentPresenter> BorderBrush(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.BorderBrushProperty, binding);
public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, Thickness value)
=> style._addSetter(ContentPresenter.BorderThicknessProperty, value);
public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.BorderThicknessProperty, binding);

public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, Double uniformLength)
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(uniformLength));
public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, Double horizontal, Double vertical)
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(horizontal, vertical));
public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, Double left, Double top, Double right, Double bottom)
   => style._addSetter(ContentPresenter.BorderThicknessProperty, new Thickness(left, top, right, bottom));
public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, CornerRadius value)
=> style._addSetter(ContentPresenter.CornerRadiusProperty, value);
public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.CornerRadiusProperty, binding);

public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, Double uniformRadius)
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, Double top, Double bottom)
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => style._addSetter(ContentPresenter.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<ContentPresenter> BoxShadow(this Style<ContentPresenter> style, BoxShadows value)
=> style._addSetter(ContentPresenter.BoxShadowProperty, value);
public static Style<ContentPresenter> BoxShadow(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.BoxShadowProperty, binding);

public static Style<ContentPresenter> BoxShadow(this Style<ContentPresenter> style, BoxShadow shadow)
   => style._addSetter(ContentPresenter.BoxShadowProperty, new BoxShadows(shadow));
public static Style<ContentPresenter> BoxShadow(this Style<ContentPresenter> style, BoxShadow first, BoxShadow[] rest)
   => style._addSetter(ContentPresenter.BoxShadowProperty, new BoxShadows(first, rest));
public static Style<ContentPresenter> Foreground(this Style<ContentPresenter> style, IBrush value)
=> style._addSetter(ContentPresenter.ForegroundProperty, value);
public static Style<ContentPresenter> Foreground(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.ForegroundProperty, binding);
public static Style<ContentPresenter> FontFamily(this Style<ContentPresenter> style, FontFamily value)
=> style._addSetter(ContentPresenter.FontFamilyProperty, value);
public static Style<ContentPresenter> FontFamily(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.FontFamilyProperty, binding);
public static Style<ContentPresenter> FontSize(this Style<ContentPresenter> style, Double value)
=> style._addSetter(ContentPresenter.FontSizeProperty, value);
public static Style<ContentPresenter> FontSize(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.FontSizeProperty, binding);
public static Style<ContentPresenter> FontStyle(this Style<ContentPresenter> style, FontStyle value)
=> style._addSetter(ContentPresenter.FontStyleProperty, value);
public static Style<ContentPresenter> FontStyle(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.FontStyleProperty, binding);
public static Style<ContentPresenter> FontWeight(this Style<ContentPresenter> style, FontWeight value)
=> style._addSetter(ContentPresenter.FontWeightProperty, value);
public static Style<ContentPresenter> FontWeight(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.FontWeightProperty, binding);
public static Style<ContentPresenter> FontStretch(this Style<ContentPresenter> style, FontStretch value)
=> style._addSetter(ContentPresenter.FontStretchProperty, value);
public static Style<ContentPresenter> FontStretch(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.FontStretchProperty, binding);
public static Style<ContentPresenter> TextAlignment(this Style<ContentPresenter> style, TextAlignment value)
=> style._addSetter(ContentPresenter.TextAlignmentProperty, value);
public static Style<ContentPresenter> TextAlignment(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.TextAlignmentProperty, binding);
public static Style<ContentPresenter> TextWrapping(this Style<ContentPresenter> style, TextWrapping value)
=> style._addSetter(ContentPresenter.TextWrappingProperty, value);
public static Style<ContentPresenter> TextWrapping(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.TextWrappingProperty, binding);
public static Style<ContentPresenter> TextTrimming(this Style<ContentPresenter> style, TextTrimming value)
=> style._addSetter(ContentPresenter.TextTrimmingProperty, value);
public static Style<ContentPresenter> TextTrimming(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.TextTrimmingProperty, binding);
public static Style<ContentPresenter> LineHeight(this Style<ContentPresenter> style, Double value)
=> style._addSetter(ContentPresenter.LineHeightProperty, value);
public static Style<ContentPresenter> LineHeight(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.LineHeightProperty, binding);
public static Style<ContentPresenter> MaxLines(this Style<ContentPresenter> style, Int32 value)
=> style._addSetter(ContentPresenter.MaxLinesProperty, value);
public static Style<ContentPresenter> MaxLines(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.MaxLinesProperty, binding);
public static Style<ContentPresenter> Content(this Style<ContentPresenter> style, Object value)
=> style._addSetter(ContentPresenter.ContentProperty, value);
public static Style<ContentPresenter> Content(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.ContentProperty, binding);
public static Style<ContentPresenter> ContentTemplate(this Style<ContentPresenter> style, IDataTemplate value)
=> style._addSetter(ContentPresenter.ContentTemplateProperty, value);
public static Style<ContentPresenter> ContentTemplate(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.ContentTemplateProperty, binding);
public static Style<ContentPresenter> HorizontalContentAlignment(this Style<ContentPresenter> style, HorizontalAlignment value)
=> style._addSetter(ContentPresenter.HorizontalContentAlignmentProperty, value);
public static Style<ContentPresenter> HorizontalContentAlignment(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static Style<ContentPresenter> VerticalContentAlignment(this Style<ContentPresenter> style, VerticalAlignment value)
=> style._addSetter(ContentPresenter.VerticalContentAlignmentProperty, value);
public static Style<ContentPresenter> VerticalContentAlignment(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.VerticalContentAlignmentProperty, binding);
public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, Thickness value)
=> style._addSetter(ContentPresenter.PaddingProperty, value);
public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.PaddingProperty, binding);

public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, Double uniformLength)
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(uniformLength));
public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, Double horizontal, Double vertical)
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, Double left, Double top, Double right, Double bottom)
   => style._addSetter(ContentPresenter.PaddingProperty, new Thickness(left, top, right, bottom));
public static Style<ContentPresenter> RecognizesAccessKey(this Style<ContentPresenter> style, Boolean value)
=> style._addSetter(ContentPresenter.RecognizesAccessKeyProperty, value);
public static Style<ContentPresenter> RecognizesAccessKey(this Style<ContentPresenter> style, IBinding binding)
=> style._addSetter(ContentPresenter.RecognizesAccessKeyProperty, binding);
}

