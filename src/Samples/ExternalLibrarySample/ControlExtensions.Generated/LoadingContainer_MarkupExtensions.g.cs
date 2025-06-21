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
public static partial class LoadingContainer_MarkupExtensions
{
//================= Properties ======================//
 // Indicator

/*ValueSetterGenerator*/
public static T Indicator<T>(this T control, System.Object value) where T : Ursa.Controls.LoadingContainer 
=> control._set(() => control.Indicator = value!);

/*BindFromExpressionSetterGenerator*/
public static T Indicator<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IndicatorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Indicator<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.IndicatorProperty, ps, () => control.Indicator = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Indicator<T>(this T control, IBinding binding) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IndicatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Indicator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IndicatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Indicator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.IndicatorProperty, ps, () => control.Indicator = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LoadingMessage

/*ValueSetterGenerator*/
public static T LoadingMessage<T>(this T control, System.Object value) where T : Ursa.Controls.LoadingContainer 
=> control._set(() => control.LoadingMessage = value!);

/*BindFromExpressionSetterGenerator*/
public static T LoadingMessage<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LoadingMessage<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.LoadingMessageProperty, ps, () => control.LoadingMessage = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LoadingMessage<T>(this T control, IBinding binding) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LoadingMessage<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LoadingMessage<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.LoadingMessageProperty, ps, () => control.LoadingMessage = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MessageForeground

/*ValueSetterGenerator*/
public static T MessageForeground<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.LoadingContainer 
=> control._set(() => control.MessageForeground = value!);

/*BindFromExpressionSetterGenerator*/
public static T MessageForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.MessageForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MessageForeground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.MessageForegroundProperty, ps, () => control.MessageForeground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MessageForeground<T>(this T control, IBinding binding) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.MessageForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MessageForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.MessageForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MessageForeground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.MessageForegroundProperty, ps, () => control.MessageForeground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LoadingMessageTemplate

/*ValueSetterGenerator*/
public static T LoadingMessageTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.LoadingContainer 
=> control._set(() => control.LoadingMessageTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T LoadingMessageTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LoadingMessageTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty, ps, () => control.LoadingMessageTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LoadingMessageTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LoadingMessageTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LoadingMessageTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty, ps, () => control.LoadingMessageTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsLoading

/*ValueSetterGenerator*/
public static T IsLoading<T>(this T control, System.Boolean value) where T : Ursa.Controls.LoadingContainer 
=> control._set(() => control.IsLoading = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsLoading<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IsLoadingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsLoading<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.IsLoadingProperty, ps, () => control.IsLoading = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsLoading<T>(this T control, IBinding binding) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IsLoadingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLoading<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.LoadingContainer 
   => control._set(Ursa.Controls.LoadingContainer.IsLoadingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsLoading<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.LoadingContainer 
=> control._setEx(Ursa.Controls.LoadingContainer.IsLoadingProperty, ps, () => control.IsLoading = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Indicator

/*ValueStyleSetterGenerator*/
public static Style<T> Indicator<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.IndicatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Indicator<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.IndicatorProperty, binding);


 // LoadingMessage

/*ValueStyleSetterGenerator*/
public static Style<T> LoadingMessage<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.LoadingMessageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LoadingMessage<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.LoadingMessageProperty, binding);


 // MessageForeground

/*ValueStyleSetterGenerator*/
public static Style<T> MessageForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.MessageForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MessageForeground<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.MessageForegroundProperty, binding);


 // LoadingMessageTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> LoadingMessageTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LoadingMessageTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.LoadingMessageTemplateProperty, binding);


 // IsLoading

/*ValueStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.IsLoadingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.LoadingContainer 
=> style._addSetter(Ursa.Controls.LoadingContainer.IsLoadingProperty, binding);



}
