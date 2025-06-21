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
public static partial class PinCode_MarkupExtensions
{
//================= Properties ======================//
 // CompleteCommand

/*ValueSetterGenerator*/
public static T CompleteCommand<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.PinCode 
=> control._set(() => control.CompleteCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T CompleteCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CompleteCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CompleteCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.CompleteCommandProperty, ps, () => control.CompleteCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CompleteCommand<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CompleteCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CompleteCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CompleteCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CompleteCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.CompleteCommandProperty, ps, () => control.CompleteCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Count

/*ValueSetterGenerator*/
public static T Count<T>(this T control, System.Int32 value) where T : Ursa.Controls.PinCode 
=> control._set(() => control.Count = value!);

/*BindFromExpressionSetterGenerator*/
public static T Count<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CountProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Count<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.CountProperty, ps, () => control.Count = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Count<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Count<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.CountProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Count<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.CountProperty, ps, () => control.Count = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Ursa.Controls.PinCode 
=> control._set(() => control.PasswordChar = value!);

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.PasswordCharProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PasswordChar<T>(this T control,System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.PasswordCharProperty, ps, () => control.PasswordChar = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PasswordChar<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Mode

/*ValueSetterGenerator*/
public static T Mode<T>(this T control, Ursa.Controls.PinCodeMode value) where T : Ursa.Controls.PinCode 
=> control._set(() => control.Mode = value!);

/*BindFromExpressionSetterGenerator*/
public static T Mode<T>(this T control, Func<Ursa.Controls.PinCodeMode> func, Action<Ursa.Controls.PinCodeMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.ModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Mode<T>(this T control,Ursa.Controls.PinCodeMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.ModeProperty, ps, () => control.Mode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Mode<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.ModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Mode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCode 
   => control._set(Ursa.Controls.PinCode.ModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Mode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.PinCodeMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PinCode 
=> control._setEx(Ursa.Controls.PinCode.ModeProperty, ps, () => control.Mode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Complete

/*ActionToEventGenerator*/
public static T OnComplete<T>(this T control, Action<Ursa.Controls.PinCodeCompleteEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.PinCode 
{
  control.AddHandler(Ursa.Controls.PinCode.CompleteEvent, (_, args) => action(args), routes ?? Ursa.Controls.PinCode.CompleteEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CompleteCommand

/*ValueStyleSetterGenerator*/
public static Style<T> CompleteCommand<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.CompleteCommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CompleteCommand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.CompleteCommandProperty, binding);


 // Count

/*ValueStyleSetterGenerator*/
public static Style<T> Count<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.CountProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Count<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.CountProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.PasswordCharProperty, binding);


 // Mode

/*ValueStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, Ursa.Controls.PinCodeMode value) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.ModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCode 
=> style._addSetter(Ursa.Controls.PinCode.ModeProperty, binding);



}
