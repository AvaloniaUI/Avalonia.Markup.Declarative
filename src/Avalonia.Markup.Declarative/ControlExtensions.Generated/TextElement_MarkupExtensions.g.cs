#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
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
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);


 // FontFeaturesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);


 // FontSizeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);


 // FontStyleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);


 // FontWeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);


 // FontStretchProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);


 // ForegroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);



}
