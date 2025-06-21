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
public static partial class MessageBoxWindow_MarkupExtensions
{
//================= Properties ======================//
 // MessageIcon

/*ValueSetterGenerator*/
public static T MessageIcon<T>(this T control, Ursa.Controls.MessageBoxIcon value) where T : Ursa.Controls.MessageBoxWindow 
=> control._set(() => control.MessageIcon = value!);

/*BindFromExpressionSetterGenerator*/
public static T MessageIcon<T>(this T control, Func<Ursa.Controls.MessageBoxIcon> func, Action<Ursa.Controls.MessageBoxIcon>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MessageBoxWindow 
   => control._set(Ursa.Controls.MessageBoxWindow.MessageIconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MessageIcon<T>(this T control,Ursa.Controls.MessageBoxIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageBoxWindow 
=> control._setEx(Ursa.Controls.MessageBoxWindow.MessageIconProperty, ps, () => control.MessageIcon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MessageIcon<T>(this T control, IBinding binding) where T : Ursa.Controls.MessageBoxWindow 
   => control._set(Ursa.Controls.MessageBoxWindow.MessageIconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MessageIcon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MessageBoxWindow 
   => control._set(Ursa.Controls.MessageBoxWindow.MessageIconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MessageIcon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.MessageBoxIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageBoxWindow 
=> control._setEx(Ursa.Controls.MessageBoxWindow.MessageIconProperty, ps, () => control.MessageIcon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // MessageIcon

/*ValueStyleSetterGenerator*/
public static Style<T> MessageIcon<T>(this Style<T> style, Ursa.Controls.MessageBoxIcon value) where T : Ursa.Controls.MessageBoxWindow 
=> style._addSetter(Ursa.Controls.MessageBoxWindow.MessageIconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MessageIcon<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MessageBoxWindow 
=> style._addSetter(Ursa.Controls.MessageBoxWindow.MessageIconProperty, binding);



}
