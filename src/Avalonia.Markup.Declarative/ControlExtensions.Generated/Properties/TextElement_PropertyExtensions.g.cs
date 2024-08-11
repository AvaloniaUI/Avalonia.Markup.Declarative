#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextElementExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontFamily<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontFamilyProperty, binding);
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFamily<T>(this T control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontFamilyProperty, func, onChanged, expression);
public static T FontFamily<T>(this T control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontFeatures<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontFeaturesProperty, binding);
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontFeatures<T>(this T control, Func<FontFeatureCollection> func, Action<FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontFeaturesProperty, func, onChanged, expression);
public static T FontFeatures<T>(this T control, FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);
public static T FontFeatures<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontSize<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontSizeProperty, binding);
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontSize<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontSizeProperty, func, onChanged, expression);
public static T FontSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStyle<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontStyleProperty, binding);
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStyle<T>(this T control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontStyleProperty, func, onChanged, expression);
public static T FontStyle<T>(this T control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontWeight<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontWeightProperty, binding);
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontWeight<T>(this T control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontWeightProperty, func, onChanged, expression);
public static T FontWeight<T>(this T control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStretch<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.FontStretchProperty, binding);
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FontStretch<T>(this T control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.FontStretchProperty, func, onChanged, expression);
public static T FontStretch<T>(this T control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Foreground<T>(this T control, IBinding binding) where T : TextElement
   => control._set(TextElement.ForegroundProperty, binding);
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TextElement
   => control._set(TextElement.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Foreground<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TextElement
   => control._set(TextElement.ForegroundProperty, func, onChanged, expression);
public static T Foreground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TextElement
=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

