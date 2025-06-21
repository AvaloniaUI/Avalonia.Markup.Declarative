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
public static partial class ButtonGroup_MarkupExtensions
{
//================= Properties ======================//
 // CommandBinding

/*ValueSetterGenerator*/
public static T CommandBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> control._set(() => control.CommandBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.CommandBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.CommandBindingProperty, ps, () => control.CommandBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.CommandBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.CommandBindingProperty, ps, () => control.CommandBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameterBinding

/*ValueSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> control._set(() => control.CommandParameterBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.CommandParameterBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameterBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.CommandParameterBindingProperty, ps, () => control.CommandParameterBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.CommandParameterBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameterBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.CommandParameterBindingProperty, ps, () => control.CommandParameterBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ContentBinding

/*ValueSetterGenerator*/
public static T ContentBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> control._set(() => control.ContentBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T ContentBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.ContentBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ContentBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.ContentBindingProperty, ps, () => control.ContentBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ButtonGroup 
   => control._set(Ursa.Controls.ButtonGroup.ContentBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ContentBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ButtonGroup 
=> control._setEx(Ursa.Controls.ButtonGroup.ContentBindingProperty, ps, () => control.ContentBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // CommandBinding

/*ValueStyleSetterGenerator*/
public static Style<T> CommandBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> style._addSetter(Ursa.Controls.ButtonGroup.CommandBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped CommandBinding because already exist in value setters


 // CommandParameterBinding

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameterBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> style._addSetter(Ursa.Controls.ButtonGroup.CommandParameterBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped CommandParameterBinding because already exist in value setters


 // ContentBinding

/*ValueStyleSetterGenerator*/
public static Style<T> ContentBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.ButtonGroup 
=> style._addSetter(Ursa.Controls.ButtonGroup.ContentBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped ContentBinding because already exist in value setters



}
