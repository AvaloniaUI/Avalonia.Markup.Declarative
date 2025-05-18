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
public static partial class Flyout_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.ContentTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.ContentTemplateProperty, ps, () => control.ContentTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.FlyoutPresenterTheme = value!);

/*BindFromExpressionSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FlyoutPresenterTheme<T>(this T control,Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FlyoutPresenterTheme<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Flyout 
=> control._setEx(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
