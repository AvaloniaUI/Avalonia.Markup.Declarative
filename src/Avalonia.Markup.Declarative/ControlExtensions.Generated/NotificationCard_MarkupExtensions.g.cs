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
public static partial class NotificationCard_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*BindFromExpressionSetterGenerator*/
public static T IsClosed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsClosed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClosed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClosed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsClosed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // NotificationType

/*BindFromExpressionSetterGenerator*/
public static T NotificationType<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T NotificationType<T>(this T control,Avalonia.Controls.Notifications.NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NotificationType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NotificationType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T NotificationType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // CloseOnClick

/*AttachedPropertyMagicalSetterGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Button
 => control._setEx(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty, ps, () => Avalonia.Controls.Notifications.NotificationCard.SetCloseOnClick(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, func, onChanged, expression);



//================= Events ======================//
 // NotificationClosed

/*ActionToEventGenerator*/
public static T OnNotificationClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Notifications.NotificationCard 
{
  control.AddHandler(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsClosed

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, binding);


 // NotificationType

/*ValueStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, binding);



}
