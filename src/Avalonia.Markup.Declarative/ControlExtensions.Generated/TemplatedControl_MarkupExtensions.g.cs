#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TemplatedControl_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BackgroundSizing

/*BindFromExpressionSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BackgroundSizing<T>(this T control,Avalonia.Media.BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BackgroundSizing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderBrush

/*BindFromExpressionSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BorderBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderThickness

/*BindFromExpressionSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderThickness<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T BorderThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CornerRadius

/*BindFromExpressionSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CornerRadius<T>(this T control,Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default, System.Double bottom = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default, System.Double topRight = default, System.Double bottomRight = default, System.Double bottomLeft = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

/*BindSetterGenerator*/
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CornerRadius<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamily

/*BindFromExpressionSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFamily<T>(this T control,Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFamily<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFeatures

/*BindFromExpressionSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontFeatures<T>(this T control,Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFeatures<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFeatures<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontSize

/*BindFromExpressionSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStyle

/*BindFromExpressionSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStyle<T>(this T control,Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontWeight

/*BindFromExpressionSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontWeight<T>(this T control,Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontWeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStretch

/*BindFromExpressionSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FontStretch<T>(this T control,Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Foreground

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Padding

/*BindFromExpressionSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Padding<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Padding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Template

/*BindFromExpressionSetterGenerator*/
public static T Template<T>(this T control, Func<Avalonia.Controls.Templates.IControlTemplate> func, Action<Avalonia.Controls.Templates.IControlTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Template<T>(this T control,Avalonia.Controls.Templates.IControlTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, ps, () => control.Template = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Template<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Template<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Template<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IControlTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._setEx(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, ps, () => control.Template = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // IsTemplateFocusTarget

/*AttachedPropertyMagicalSetterGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty, ps, () => Avalonia.Controls.Primitives.TemplatedControl.SetIsTemplateFocusTarget(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty, func, onChanged, expression);



//================= Events ======================//
 // TemplateApplied

/*ActionToEventGenerator*/
    public static T OnTemplateApplied<T>(this T control, Action<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> action) where T : Avalonia.Controls.Primitives.TemplatedControl => 
        control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.TemplateAppliedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TemplateApplied += h);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // Template

/*ValueStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, binding);



}
