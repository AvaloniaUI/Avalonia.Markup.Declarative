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
public static partial class TextElement_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamily

/*BindFromExpressionSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontFamily<T>(this T control,Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFamily<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFamily<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFeatures

/*BindFromExpressionSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontFeatures<T>(this T control,Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontFeatures<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontFeatures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontFeatures<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontFeatureCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontSize

/*BindFromExpressionSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStyle

/*BindFromExpressionSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontStyle<T>(this T control,Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontWeight

/*BindFromExpressionSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontWeight<T>(this T control,Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontWeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontWeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontStretch

/*BindFromExpressionSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement FontStretch<T>(this T control,Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FontStretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FontStretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Foreground

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.TextElement Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement=> control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // FontFamily

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFamily(control, value), bindingMode, converter, bindingSource);


 // FontFeatures

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFeatures(control, value), bindingMode, converter, bindingSource);


 // FontSize

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontSize(control, value), bindingMode, converter, bindingSource);


 // FontStyle

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStyle(control, value), bindingMode, converter, bindingSource);


 // FontWeight

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontWeight(control, value), bindingMode, converter, bindingSource);


 // FontStretch

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStretch(control, value), bindingMode, converter, bindingSource);


 // Foreground

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetForeground(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);



}
