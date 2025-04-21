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
public static partial class HyperlinkButton_MarkupExtensions
{
//================= Properties ======================//
 // IsVisited

/*BindFromExpressionSetterGenerator*/
public static T IsVisited<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsVisited<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.HyperlinkButton 
=> control._setEx(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsVisited<T>(this T control, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisited<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsVisited<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.HyperlinkButton 
=> control._setEx(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // NavigateUri

/*BindFromExpressionSetterGenerator*/
public static T NavigateUri<T>(this T control, Func<System.Uri> func, Action<System.Uri>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T NavigateUri<T>(this T control,System.Uri value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.HyperlinkButton 
=> control._setEx(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NavigateUri<T>(this T control, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NavigateUri<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T NavigateUri<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Uri> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.HyperlinkButton 
=> control._setEx(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsVisited

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);


 // NavigateUri

/*ValueStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, System.Uri value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);



}
