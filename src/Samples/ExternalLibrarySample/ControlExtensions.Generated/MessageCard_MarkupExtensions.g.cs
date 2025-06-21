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
public static partial class MessageCard_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static T IsClosed<T>(this T control, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> control._set(() => control.IsClosed = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsClosed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.IsClosedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsClosed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.IsClosedProperty, ps, () => control.IsClosed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClosed<T>(this T control, IBinding binding) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.IsClosedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClosed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsClosed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // NotificationType

/*ValueSetterGenerator*/
public static T NotificationType<T>(this T control, Avalonia.Controls.Notifications.NotificationType value) where T : Ursa.Controls.MessageCard 
=> control._set(() => control.NotificationType = value!);

/*BindFromExpressionSetterGenerator*/
public static T NotificationType<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.NotificationTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T NotificationType<T>(this T control,Avalonia.Controls.Notifications.NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.NotificationTypeProperty, ps, () => control.NotificationType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NotificationType<T>(this T control, IBinding binding) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.NotificationTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NotificationType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.NotificationTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T NotificationType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.NotificationTypeProperty, ps, () => control.NotificationType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowIcon

/*ValueSetterGenerator*/
public static T ShowIcon<T>(this T control, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> control._set(() => control.ShowIcon = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowIcon<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowIconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowIcon<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.ShowIconProperty, ps, () => control.ShowIcon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowIcon<T>(this T control, IBinding binding) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowIconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowIcon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowIconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowIcon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.ShowIconProperty, ps, () => control.ShowIcon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowClose

/*ValueSetterGenerator*/
public static T ShowClose<T>(this T control, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> control._set(() => control.ShowClose = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowClose<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowCloseProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowClose<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.ShowCloseProperty, ps, () => control.ShowClose = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowClose<T>(this T control, IBinding binding) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowCloseProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowClose<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MessageCard 
   => control._set(Ursa.Controls.MessageCard.ShowCloseProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowClose<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MessageCard 
=> control._setEx(Ursa.Controls.MessageCard.ShowCloseProperty, ps, () => control.ShowClose = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // CloseOnClick

/*AttachedPropertyMagicalSetterGenerator*/
public static T MessageCard_CloseOnClick<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Button
 => control._setEx(Ursa.Controls.MessageCard.CloseOnClickProperty, ps, () => Ursa.Controls.MessageCard.SetCloseOnClick(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T MessageCard_CloseOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Ursa.Controls.MessageCard.CloseOnClickProperty!, func, onChanged, expression);



//================= Events ======================//
 // MessageClosed

/*ActionToEventGenerator*/
public static T OnMessageClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.MessageCard 
{
  control.AddHandler(Ursa.Controls.MessageCard.MessageClosedEvent, (_, args) => action(args), routes ?? Ursa.Controls.MessageCard.MessageClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsClosed

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.IsClosedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.IsClosedProperty, binding);


 // NotificationType

/*ValueStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.NotificationTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.NotificationTypeProperty, binding);


 // ShowIcon

/*ValueStyleSetterGenerator*/
public static Style<T> ShowIcon<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.ShowIconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowIcon<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.ShowIconProperty, binding);


 // ShowClose

/*ValueStyleSetterGenerator*/
public static Style<T> ShowClose<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.ShowCloseProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowClose<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MessageCard 
=> style._addSetter(Ursa.Controls.MessageCard.ShowCloseProperty, binding);



}
