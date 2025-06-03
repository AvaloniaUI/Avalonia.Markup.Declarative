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
public static partial class ViewModelViewHost_MarkupExtensions
{
//================= Properties ======================//
 // ViewModel

/*ValueSetterGenerator*/
public static T ViewModel<T>(this T control, System.Object value) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._set(() => control.ViewModel = value!);

/*BindFromExpressionSetterGenerator*/
public static T ViewModel<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewModelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ViewModel<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.ViewModelProperty, ps, () => control.ViewModel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewModel<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewModelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewModel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewModelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ViewModel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.ViewModelProperty, ps, () => control.ViewModel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ViewContract

/*ValueSetterGenerator*/
public static T ViewContract<T>(this T control, System.String value) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._set(() => control.ViewContract = value!);

/*BindFromExpressionSetterGenerator*/
public static T ViewContract<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ViewContract<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty, ps, () => control.ViewContract = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewContract<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewContract<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ViewContract<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty, ps, () => control.ViewContract = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DefaultContent

/*ValueSetterGenerator*/
public static T DefaultContent<T>(this T control, System.Object value) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._set(() => control.DefaultContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T DefaultContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DefaultContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty, ps, () => control.DefaultContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultContent<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
   => control._set(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DefaultContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> control._setEx(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty, ps, () => control.DefaultContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // ViewContract

/*ValueStyleSetterGenerator*/
public static Style<T> ViewContract<T>(this Style<T> style, System.String value) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> style._addSetter(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewContract<T>(this Style<T> style, IBinding binding) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> style._addSetter(Avalonia.ReactiveUI.ViewModelViewHost.ViewContractProperty, binding);


 // DefaultContent

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultContent<T>(this Style<T> style, System.Object value) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> style._addSetter(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.ReactiveUI.ViewModelViewHost 
=> style._addSetter(Avalonia.ReactiveUI.ViewModelViewHost.DefaultContentProperty, binding);



}
