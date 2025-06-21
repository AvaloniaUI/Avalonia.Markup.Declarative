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
public static partial class DefaultDialogControl_MarkupExtensions
{
//================= Properties ======================//
 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : Ursa.Controls.DefaultDialogControl 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Buttons

/*ValueSetterGenerator*/
public static T Buttons<T>(this T control, Ursa.Controls.DialogButton value) where T : Ursa.Controls.DefaultDialogControl 
=> control._set(() => control.Buttons = value!);

/*BindFromExpressionSetterGenerator*/
public static T Buttons<T>(this T control, Func<Ursa.Controls.DialogButton> func, Action<Ursa.Controls.DialogButton>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ButtonsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Buttons<T>(this T control,Ursa.Controls.DialogButton value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.ButtonsProperty, ps, () => control.Buttons = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Buttons<T>(this T control, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ButtonsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Buttons<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ButtonsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Buttons<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.DialogButton> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.ButtonsProperty, ps, () => control.Buttons = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Mode

/*ValueSetterGenerator*/
public static T Mode<T>(this T control, Ursa.Controls.DialogMode value) where T : Ursa.Controls.DefaultDialogControl 
=> control._set(() => control.Mode = value!);

/*BindFromExpressionSetterGenerator*/
public static T Mode<T>(this T control, Func<Ursa.Controls.DialogMode> func, Action<Ursa.Controls.DialogMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Mode<T>(this T control,Ursa.Controls.DialogMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.ModeProperty, ps, () => control.Mode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Mode<T>(this T control, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Mode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DefaultDialogControl 
   => control._set(Ursa.Controls.DefaultDialogControl.ModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Mode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.DialogMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DefaultDialogControl 
=> control._setEx(Ursa.Controls.DefaultDialogControl.ModeProperty, ps, () => control.Mode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.TitleProperty, binding);


 // Buttons

/*ValueStyleSetterGenerator*/
public static Style<T> Buttons<T>(this Style<T> style, Ursa.Controls.DialogButton value) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.ButtonsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Buttons<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.ButtonsProperty, binding);


 // Mode

/*ValueStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, Ursa.Controls.DialogMode value) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.ModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DefaultDialogControl 
=> style._addSetter(Ursa.Controls.DefaultDialogControl.ModeProperty, binding);



}
