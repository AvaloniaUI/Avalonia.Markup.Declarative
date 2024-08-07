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
public static TextElement Background(this TextElement control, IBinding binding)
   => control._set(TextElement.BackgroundProperty, binding);
public static TextElement Background(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement Background(this TextElement control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.BackgroundProperty, func, onChanged, expression);
public static TextElement Background(this TextElement control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextElement Background<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontFamily(this TextElement control, IBinding binding)
   => control._set(TextElement.FontFamilyProperty, binding);
public static TextElement FontFamily(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontFamily(this TextElement control, Func<FontFamily> func, Action<FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontFamilyProperty, func, onChanged, expression);
public static TextElement FontFamily(this TextElement control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static TextElement FontFamily<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontFeatures(this TextElement control, IBinding binding)
   => control._set(TextElement.FontFeaturesProperty, binding);
public static TextElement FontFeatures(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontFeatures(this TextElement control, Func<FontFeatureCollection> func, Action<FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontFeaturesProperty, func, onChanged, expression);
public static TextElement FontFeatures(this TextElement control, FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);
public static TextElement FontFeatures<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontSize(this TextElement control, IBinding binding)
   => control._set(TextElement.FontSizeProperty, binding);
public static TextElement FontSize(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontSize(this TextElement control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontSizeProperty, func, onChanged, expression);
public static TextElement FontSize(this TextElement control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static TextElement FontSize<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontStyle(this TextElement control, IBinding binding)
   => control._set(TextElement.FontStyleProperty, binding);
public static TextElement FontStyle(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontStyle(this TextElement control, Func<FontStyle> func, Action<FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontStyleProperty, func, onChanged, expression);
public static TextElement FontStyle(this TextElement control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static TextElement FontStyle<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontWeight(this TextElement control, IBinding binding)
   => control._set(TextElement.FontWeightProperty, binding);
public static TextElement FontWeight(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontWeight(this TextElement control, Func<FontWeight> func, Action<FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontWeightProperty, func, onChanged, expression);
public static TextElement FontWeight(this TextElement control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static TextElement FontWeight<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontStretch(this TextElement control, IBinding binding)
   => control._set(TextElement.FontStretchProperty, binding);
public static TextElement FontStretch(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement FontStretch(this TextElement control, Func<FontStretch> func, Action<FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontStretchProperty, func, onChanged, expression);
public static TextElement FontStretch(this TextElement control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static TextElement FontStretch<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement Foreground(this TextElement control, IBinding binding)
   => control._set(TextElement.ForegroundProperty, binding);
public static TextElement Foreground(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TextElement.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TextElement Foreground(this TextElement control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.ForegroundProperty, func, onChanged, expression);
public static TextElement Foreground(this TextElement control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static TextElement Foreground<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

