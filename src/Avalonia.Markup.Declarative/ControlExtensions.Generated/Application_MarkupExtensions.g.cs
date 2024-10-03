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
public static partial class Application_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*BindFromExpressionSetterGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DataContext<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DataContext<T>(this T control, IBinding binding) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DataContext<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RequestedThemeVariant

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control,Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RequestedThemeVariant<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Name

/*BindFromExpressionSetterGenerator*/
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Name<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Name<T>(this T control, IBinding binding) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Name<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application 
=> control._setEx(Avalonia.Application.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // UrlsOpened

/*ActionToEventGenerator*/
public static T OnUrlsOpened<T>(this T control, Action<Avalonia.UrlOpenedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.UrlOpenedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.UrlsOpened += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



}
