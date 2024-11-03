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
public static partial class Decorator_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Child<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Decorator 
=> control._setEx(Avalonia.Controls.Decorator.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Child<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Decorator 
=> control._setEx(Avalonia.Controls.Decorator.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Padding

/*BindFromExpressionSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Padding<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Decorator 
=> control._setEx(Avalonia.Controls.Decorator.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Padding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Decorator 
=> control._setEx(Avalonia.Controls.Decorator.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));



}
