#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BackgroundSizing

/*BindFromExpressionSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BackgroundSizing<T>(this T control,Avalonia.Media.BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BackgroundSizing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderBrush

/*BindFromExpressionSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BorderBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderThickness

/*BindFromExpressionSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderThickness<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T BorderThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CornerRadius

/*BindFromExpressionSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CornerRadius<T>(this T control,Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default, System.Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default, System.Double topRight = default, System.Double bottomRight = default, System.Double bottomLeft = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

/*BindSetterGenerator*/
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CornerRadius<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BoxShadow

/*BindFromExpressionSetterGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BoxShadow<T>(this T control,Avalonia.Media.BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default, Avalonia.Media.BoxShadow[] rest = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));

/*BindSetterGenerator*/
public static T BoxShadow<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BoxShadow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BoxShadow<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Foreground

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamily

/*BindFromExpressionSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFamily<T>(this T control,Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFamily<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontSize

/*BindFromExpressionSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStyle

/*BindFromExpressionSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStyle<T>(this T control,Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontWeight

/*BindFromExpressionSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontWeight<T>(this T control,Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontWeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStretch

/*BindFromExpressionSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStretch<T>(this T control,Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignment

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextWrapping

/*BindFromExpressionSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextWrapping<T>(this T control,Avalonia.Media.TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextWrapping<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextWrapping<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextWrapping<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextTrimming

/*BindFromExpressionSetterGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextTrimming<T>(this T control,Avalonia.Media.TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextTrimming<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextTrimming<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextTrimming<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // LineHeight

/*BindFromExpressionSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T LineHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T LineHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxLines

/*BindFromExpressionSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxLines<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Content

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ContentTemplate

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Padding

/*BindFromExpressionSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Padding<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Padding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RecognizesAccessKey

/*BindFromExpressionSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RecognizesAccessKey<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // RecognizesAccessKey

/*ValueStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);



}
