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
public static partial class ControlClassesInput_MarkupExtensions
{
//================= Properties ======================//
 // Target

/*ValueSetterGenerator*/
public static T Target<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.ControlClassesInput 
=> control._set(() => control.Target = value!);

/*BindFromExpressionSetterGenerator*/
public static T Target<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.TargetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Target<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ControlClassesInput 
=> control._setEx(Ursa.Controls.ControlClassesInput.TargetProperty, ps, () => control.Target = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Target<T>(this T control, IBinding binding) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.TargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Target<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.TargetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Target<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ControlClassesInput 
=> control._setEx(Ursa.Controls.ControlClassesInput.TargetProperty, ps, () => control.Target = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Separator

/*ValueSetterGenerator*/
public static T Separator<T>(this T control, System.String value) where T : Ursa.Controls.ControlClassesInput 
=> control._set(() => control.Separator = value!);

/*BindFromExpressionSetterGenerator*/
public static T Separator<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.SeparatorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Separator<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ControlClassesInput 
=> control._setEx(Ursa.Controls.ControlClassesInput.SeparatorProperty, ps, () => control.Separator = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Separator<T>(this T control, IBinding binding) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.SeparatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Separator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ControlClassesInput 
   => control._set(Ursa.Controls.ControlClassesInput.SeparatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Separator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ControlClassesInput 
=> control._setEx(Ursa.Controls.ControlClassesInput.SeparatorProperty, ps, () => control.Separator = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // Source

/*AttachedPropertyMagicalSetterGenerator*/
public static T ControlClassesInput_Source<T>(this T control, Ursa.Controls.ControlClassesInput value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement
 => control._setEx(Ursa.Controls.ControlClassesInput.SourceProperty, ps, () => Ursa.Controls.ControlClassesInput.SetSource(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ControlClassesInput_Source<T>(this T control, Func<Ursa.Controls.ControlClassesInput> func, Action<Ursa.Controls.ControlClassesInput>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Ursa.Controls.ControlClassesInput.SourceProperty!, func, onChanged, expression);



//================= Styles ======================//
 // Target

/*ValueStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.ControlClassesInput 
=> style._addSetter(Ursa.Controls.ControlClassesInput.TargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ControlClassesInput 
=> style._addSetter(Ursa.Controls.ControlClassesInput.TargetProperty, binding);


 // Separator

/*ValueStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, System.String value) where T : Ursa.Controls.ControlClassesInput 
=> style._addSetter(Ursa.Controls.ControlClassesInput.SeparatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ControlClassesInput 
=> style._addSetter(Ursa.Controls.ControlClassesInput.SeparatorProperty, binding);



}
