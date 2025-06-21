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
public static partial class SplashWindow_MarkupExtensions
{
//================= Properties ======================//
 // CountDown

/*ValueSetterGenerator*/
public static T CountDown<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.SplashWindow 
=> control._set(() => control.CountDown = value!);

/*BindFromExpressionSetterGenerator*/
public static T CountDown<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.SplashWindow 
   => control._set(Ursa.Controls.SplashWindow.CountDownProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CountDown<T>(this T control,System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.SplashWindow 
=> control._setEx(Ursa.Controls.SplashWindow.CountDownProperty, ps, () => control.CountDown = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CountDown<T>(this T control, IBinding binding) where T : Ursa.Controls.SplashWindow 
   => control._set(Ursa.Controls.SplashWindow.CountDownProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CountDown<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.SplashWindow 
   => control._set(Ursa.Controls.SplashWindow.CountDownProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CountDown<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.SplashWindow 
=> control._setEx(Ursa.Controls.SplashWindow.CountDownProperty, ps, () => control.CountDown = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // CountDown

/*ValueStyleSetterGenerator*/
public static Style<T> CountDown<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.SplashWindow 
=> style._addSetter(Ursa.Controls.SplashWindow.CountDownProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CountDown<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.SplashWindow 
=> style._addSetter(Ursa.Controls.SplashWindow.CountDownProperty, binding);



}
