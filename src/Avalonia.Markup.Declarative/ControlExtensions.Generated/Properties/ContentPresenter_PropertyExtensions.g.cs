#nullable enable
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
public static ContentPresenter Background(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BackgroundProperty, binding);
public static ContentPresenter Background(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter Background(this ContentPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BackgroundProperty, func, onChanged, expression);
public static ContentPresenter Background(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static ContentPresenter Background<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter BackgroundSizing(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BackgroundSizingProperty, binding);
public static ContentPresenter BackgroundSizing(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter BackgroundSizing(this ContentPresenter control, Func<BackgroundSizing> func, Action<BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BackgroundSizingProperty, func, onChanged, expression);
public static ContentPresenter BackgroundSizing(this ContentPresenter control, BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);
public static ContentPresenter BackgroundSizing<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BorderBrushProperty, binding);
public static ContentPresenter BorderBrush(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter BorderBrush(this ContentPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BorderBrushProperty, func, onChanged, expression);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static ContentPresenter BorderBrush<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter BorderThickness(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BorderThicknessProperty, binding);
public static ContentPresenter BorderThickness(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter BorderThickness(this ContentPresenter control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BorderThicknessProperty, func, onChanged, expression);
public static ContentPresenter BorderThickness(this ContentPresenter control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static ContentPresenter BorderThickness<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter BorderThickness(this ContentPresenter control, Double uniformLength = default)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double horizontal = default, Double vertical = default)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double left = default, Double top = default, Double right = default, Double bottom = default)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.CornerRadiusProperty, binding);
public static ContentPresenter CornerRadius(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter CornerRadius(this ContentPresenter control, Func<CornerRadius> func, Action<CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.CornerRadiusProperty, func, onChanged, expression);
public static ContentPresenter CornerRadius(this ContentPresenter control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static ContentPresenter CornerRadius<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter CornerRadius(this ContentPresenter control, Double uniformRadius = default)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double top = default, Double bottom = default)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ContentPresenter BoxShadow(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BoxShadowProperty, binding);
public static ContentPresenter BoxShadow(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter BoxShadow(this ContentPresenter control, Func<BoxShadows> func, Action<BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BoxShadowProperty, func, onChanged, expression);
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static ContentPresenter BoxShadow<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow shadow = default)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow first = default, BoxShadow[] rest = default)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
public static ContentPresenter Foreground(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ForegroundProperty, binding);
public static ContentPresenter Foreground(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter Foreground(this ContentPresenter control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ForegroundProperty, func, onChanged, expression);
public static ContentPresenter Foreground(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static ContentPresenter Foreground<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontFamily(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontFamilyProperty, binding);
public static ContentPresenter FontFamily(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter FontFamily(this ContentPresenter control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontFamilyProperty, func, onChanged, expression);
public static ContentPresenter FontFamily(this ContentPresenter control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontFamily<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontSize(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontSizeProperty, binding);
public static ContentPresenter FontSize(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter FontSize(this ContentPresenter control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontSizeProperty, func, onChanged, expression);
public static ContentPresenter FontSize(this ContentPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontSize<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontStyle(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontStyleProperty, binding);
public static ContentPresenter FontStyle(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter FontStyle(this ContentPresenter control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontStyleProperty, func, onChanged, expression);
public static ContentPresenter FontStyle(this ContentPresenter control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontStyle<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontWeight(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontWeightProperty, binding);
public static ContentPresenter FontWeight(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter FontWeight(this ContentPresenter control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontWeightProperty, func, onChanged, expression);
public static ContentPresenter FontWeight(this ContentPresenter control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontWeight<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontStretch(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontStretchProperty, binding);
public static ContentPresenter FontStretch(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter FontStretch(this ContentPresenter control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontStretchProperty, func, onChanged, expression);
public static ContentPresenter FontStretch(this ContentPresenter control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontStretch<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextAlignmentProperty, binding);
public static ContentPresenter TextAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter TextAlignment(this ContentPresenter control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextAlignmentProperty, func, onChanged, expression);
public static ContentPresenter TextAlignment(this ContentPresenter control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextWrapping(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextWrappingProperty, binding);
public static ContentPresenter TextWrapping(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter TextWrapping(this ContentPresenter control, Func<TextWrapping> func, Action<TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextWrappingProperty, func, onChanged, expression);
public static ContentPresenter TextWrapping(this ContentPresenter control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextWrapping<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextTrimming(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextTrimmingProperty, binding);
public static ContentPresenter TextTrimming(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter TextTrimming(this ContentPresenter control, Func<TextTrimming> func, Action<TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextTrimmingProperty, func, onChanged, expression);
public static ContentPresenter TextTrimming(this ContentPresenter control, TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextTrimming<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter LineHeight(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.LineHeightProperty, binding);
public static ContentPresenter LineHeight(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter LineHeight(this ContentPresenter control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.LineHeightProperty, func, onChanged, expression);
public static ContentPresenter LineHeight(this ContentPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static ContentPresenter LineHeight<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter MaxLines(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.MaxLinesProperty, binding);
public static ContentPresenter MaxLines(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter MaxLines(this ContentPresenter control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.MaxLinesProperty, func, onChanged, expression);
public static ContentPresenter MaxLines(this ContentPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static ContentPresenter MaxLines<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter Content(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ContentProperty, binding);
public static ContentPresenter Content(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter Content(this ContentPresenter control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ContentProperty, func, onChanged, expression);
public static ContentPresenter Content(this ContentPresenter control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static ContentPresenter Content<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ContentTemplateProperty, binding);
public static ContentPresenter ContentTemplate(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter ContentTemplate(this ContentPresenter control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ContentTemplateProperty, func, onChanged, expression);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static ContentPresenter ContentTemplate<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter HorizontalContentAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, binding);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, func, onChanged, expression);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter VerticalContentAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter Padding(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.PaddingProperty, binding);
public static ContentPresenter Padding(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter Padding(this ContentPresenter control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.PaddingProperty, func, onChanged, expression);
public static ContentPresenter Padding(this ContentPresenter control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static ContentPresenter Padding<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter Padding(this ContentPresenter control, Double uniformLength = default)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static ContentPresenter Padding(this ContentPresenter control, Double horizontal = default, Double vertical = default)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static ContentPresenter Padding(this ContentPresenter control, Double left = default, Double top = default, Double right = default, Double bottom = default)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, binding);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, func, onChanged, expression);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = value, bindingMode, converter, bindingSource);
public static ContentPresenter RecognizesAccessKey<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

