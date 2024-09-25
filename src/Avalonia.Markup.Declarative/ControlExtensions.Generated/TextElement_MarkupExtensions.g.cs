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



//================= Attached Properties ======================//
 // FontFamilyProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFamily(control, value), bindingMode, converter, bindingSource);


 // FontFeaturesProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontFeatures(control, value), bindingMode, converter, bindingSource);


 // FontSizeProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontSize(control, value), bindingMode, converter, bindingSource);


 // FontStyleProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStyle(control, value), bindingMode, converter, bindingSource);


 // FontWeightProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontWeight(control, value), bindingMode, converter, bindingSource);


 // FontStretchProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
 => control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty, ps, () => Avalonia.Controls.Documents.TextElement.SetFontStretch(control, value), bindingMode, converter, bindingSource);


 // ForegroundProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.TextElement
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


 // FontFeaturesProperty


 // FontSizeProperty


 // FontStyleProperty


 // FontWeightProperty


 // FontStretchProperty


 // ForegroundProperty



}
