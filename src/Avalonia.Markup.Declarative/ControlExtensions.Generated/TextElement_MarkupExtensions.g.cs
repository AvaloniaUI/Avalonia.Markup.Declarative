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
 // BackgroundProperty

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FontFamilyProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);


 // FontFeaturesProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => control.FontFeatures = value, bindingMode, converter, bindingSource);


 // FontSizeProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);


 // FontStyleProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);


 // FontWeightProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);


 // FontStretchProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);


 // ForegroundProperty

/*BindFromExpressionSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.TextElement
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
=> control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // FontFamilyProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFamily(control, value), bindingMode, converter, bindingSource);


 // FontFeaturesProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFeatures(control, value), bindingMode, converter, bindingSource);


 // FontSizeProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontSize(control, value), bindingMode, converter, bindingSource);


 // FontStyleProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStyle(control, value), bindingMode, converter, bindingSource);


 // FontWeightProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontWeight(control, value), bindingMode, converter, bindingSource);


 // FontStretchProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStretch(control, value), bindingMode, converter, bindingSource);


 // ForegroundProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetForeground(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // BackgroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);


 // FontFamilyProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);


 // FontFeaturesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);


 // FontSizeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);


 // FontStyleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);


 // FontWeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);


 // FontStretchProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);


 // ForegroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TextElement_Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextElement_Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);



}
