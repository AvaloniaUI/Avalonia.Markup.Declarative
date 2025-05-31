#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using ReactiveSample;
using ReactiveUI;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class RoutedViewHost_MarkupExtensions
{
//================= Properties ======================//
 // Router

/*ValueSetterGenerator*/
public static T Router<T>(this T control, RoutingState value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._set(() => control.Router = value!);

/*BindFromExpressionSetterGenerator*/
public static T Router<T>(this T control, Func<RoutingState> func, Action<RoutingState>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Router<T>(this T control, RoutingState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty, ps, () => control.Router = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Router<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Router<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Router<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, RoutingState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty, ps, () => control.Router = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ViewContract

/*ValueSetterGenerator*/
public static T ViewContract<T>(this T control, System.String value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._set(() => control.ViewContract = value!);

/*BindFromExpressionSetterGenerator*/
public static T ViewContract<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ViewContract<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty, ps, () => control.ViewContract = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewContract<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewContract<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ViewContract<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty, ps, () => control.ViewContract = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DefaultContent

/*ValueSetterGenerator*/
public static T DefaultContent<T>(this T control, System.Object value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._set(() => control.DefaultContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T DefaultContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DefaultContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty, ps, () => control.DefaultContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultContent<T>(this T control, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.ReactiveUI.RoutedViewHost
   => control._set(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DefaultContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.ReactiveUI.RoutedViewHost
=> control._setEx(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty, ps, () => control.DefaultContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Router

/*ValueStyleSetterGenerator*/
public static Style<T> Router<T>(this Style<T> style, RoutingState value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Router<T>(this Style<T> style, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.RouterProperty, binding);


 // ViewContract

/*ValueStyleSetterGenerator*/
public static Style<T> ViewContract<T>(this Style<T> style, System.String value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewContract<T>(this Style<T> style, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.ViewContractProperty, binding);


 // DefaultContent

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultContent<T>(this Style<T> style, System.Object value) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.ReactiveUI.RoutedViewHost
=> style._addSetter(Avalonia.ReactiveUI.RoutedViewHost.DefaultContentProperty, binding);



}
