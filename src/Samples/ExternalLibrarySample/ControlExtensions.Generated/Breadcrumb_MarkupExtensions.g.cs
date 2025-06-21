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
public static partial class Breadcrumb_MarkupExtensions
{
//================= Properties ======================//
 // IconBinding

/*ValueSetterGenerator*/
public static T IconBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> control._set(() => control.IconBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.IconBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.IconBindingProperty, ps, () => control.IconBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.IconBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.IconBindingProperty, ps, () => control.IconBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandBinding

/*ValueSetterGenerator*/
public static T CommandBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> control._set(() => control.CommandBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.CommandBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.CommandBindingProperty, ps, () => control.CommandBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.CommandBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.CommandBindingProperty, ps, () => control.CommandBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameterBinding

/*ValueSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> control._set(() => control.CommandParameterBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.CommandParameterBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameterBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.CommandParameterBindingProperty, ps, () => control.CommandParameterBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameterBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.CommandParameterBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameterBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.CommandParameterBindingProperty, ps, () => control.CommandParameterBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Separator

/*ValueSetterGenerator*/
public static T Separator<T>(this T control, System.Object value) where T : Ursa.Controls.Breadcrumb 
=> control._set(() => control.Separator = value!);

/*BindFromExpressionSetterGenerator*/
public static T Separator<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.SeparatorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Separator<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.SeparatorProperty, ps, () => control.Separator = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Separator<T>(this T control, IBinding binding) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.SeparatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Separator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.SeparatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Separator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.SeparatorProperty, ps, () => control.Separator = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconTemplate

/*ValueSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Breadcrumb 
=> control._set(() => control.IconTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.IconTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.IconTemplateProperty, ps, () => control.IconTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.IconTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Breadcrumb 
   => control._set(Ursa.Controls.Breadcrumb.IconTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Breadcrumb 
=> control._setEx(Ursa.Controls.Breadcrumb.IconTemplateProperty, ps, () => control.IconTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IconBinding

/*ValueStyleSetterGenerator*/
public static Style<T> IconBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.IconBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped IconBinding because already exist in value setters


 // CommandBinding

/*ValueStyleSetterGenerator*/
public static Style<T> CommandBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.CommandBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped CommandBinding because already exist in value setters


 // CommandParameterBinding

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameterBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.CommandParameterBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped CommandParameterBinding because already exist in value setters


 // Separator

/*ValueStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.SeparatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.SeparatorProperty, binding);


 // IconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.IconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Breadcrumb 
=> style._addSetter(Ursa.Controls.Breadcrumb.IconTemplateProperty, binding);



}
