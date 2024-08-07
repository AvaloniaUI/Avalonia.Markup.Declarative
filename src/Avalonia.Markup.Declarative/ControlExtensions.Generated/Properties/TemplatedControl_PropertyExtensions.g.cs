#nullable enable
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
public static T Background<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundSizingProperty, binding);
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BackgroundSizing<T>(this T control, Func<BackgroundSizing> func, Action<BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundSizingProperty, func, onChanged, expression);
public static T BackgroundSizing<T>(this T control, BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);
public static T BackgroundSizing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderBrush<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, binding);
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderBrush<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, func, onChanged, expression);
public static T BorderBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static T BorderBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderThickness<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, binding);
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BorderThickness<T>(this T control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, func, onChanged, expression);
public static T BorderThickness<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static T BorderThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BorderThickness<T>(this T control, Double uniformLength = default) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal = default, Double vertical = default) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static T CornerRadius<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, binding);
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CornerRadius<T>(this T control, Func<CornerRadius> func, Action<CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, func, onChanged, expression);
public static T CornerRadius<T>(this T control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T CornerRadius<T>(this T control, Double uniformRadius = default) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top = default, Double bottom = default) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T FontFamily<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, binding);
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFamily<T>(this T control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, func, onChanged, expression);
public static T FontFamily<T>(this T control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontFeatures<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontFeaturesProperty, binding);
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFeatures<T>(this T control, Func<FontFeatureCollection> func, Action<FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFeaturesProperty, func, onChanged, expression);
public static T FontFeatures<T>(this T control, FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);
public static T FontFeatures<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontSize<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, binding);
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontSize<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, func, onChanged, expression);
public static T FontSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStyle<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, binding);
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStyle<T>(this T control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, func, onChanged, expression);
public static T FontStyle<T>(this T control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontWeight<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, binding);
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontWeight<T>(this T control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, func, onChanged, expression);
public static T FontWeight<T>(this T control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStretch<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, binding);
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStretch<T>(this T control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, func, onChanged, expression);
public static T FontStretch<T>(this T control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Foreground<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, binding);
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Foreground<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, func, onChanged, expression);
public static T Foreground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Padding<T>(this T control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, func, onChanged, expression);
public static T Padding<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength = default) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal = default, Double vertical = default) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static T Template<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, binding);
public static T Template<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Template<T>(this T control, Func<IControlTemplate> func, Action<IControlTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, func, onChanged, expression);
public static T Template<T>(this T control, IControlTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.TemplateProperty, ps, () => control.Template = value, bindingMode, converter, bindingSource);
public static T Template<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IControlTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.TemplateProperty, ps, () => control.Template = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

