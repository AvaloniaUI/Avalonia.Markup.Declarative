#nullable enable
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
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, func, onChanged, expression);
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);
public static T BackgroundSizing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, func, onChanged, expression);
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static T BorderBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, func, onChanged, expression);
public static T BorderThickness<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static T BorderThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BorderThickness<T>(this T control, Double uniformLength = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal = default, Double vertical = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, func, onChanged, expression);
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T CornerRadius<T>(this T control, Double uniformRadius = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top = default, Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T BoxShadow<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);
public static T BoxShadow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, func, onChanged, expression);
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static T BoxShadow<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BoxShadow<T>(this T control, BoxShadow shadow = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, BoxShadow first = default, BoxShadow[] rest = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, func, onChanged, expression);
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, func, onChanged, expression);
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, func, onChanged, expression);
public static T FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, func, onChanged, expression);
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, func, onChanged, expression);
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, func, onChanged, expression);
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, func, onChanged, expression);
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static T TextWrapping<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextTrimming<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);
public static T TextTrimming<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, func, onChanged, expression);
public static T TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static T TextTrimming<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, func, onChanged, expression);
public static T LineHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static T LineHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, func, onChanged, expression);
public static T MaxLines<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static T MaxLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Content<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, func, onChanged, expression);
public static T Content<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static T Content<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, func, onChanged, expression);
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static T ContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, func, onChanged, expression);
public static T Padding<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal = default, Double vertical = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));
public static T RecognizesAccessKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);
public static T RecognizesAccessKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RecognizesAccessKey<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, func, onChanged, expression);
public static T RecognizesAccessKey<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = value, bindingMode, converter, bindingSource);
public static T RecognizesAccessKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

