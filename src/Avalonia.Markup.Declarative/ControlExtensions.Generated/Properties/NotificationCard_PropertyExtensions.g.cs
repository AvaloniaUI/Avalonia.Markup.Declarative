#nullable enable
using Avalonia.Controls.Notifications;
using Avalonia.Data;
using Avalonia.Data.Converters;
using NotificationCard = Avalonia.Controls.Notifications.NotificationCard;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NotificationCardExtensions
{
public static T IsClosed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, binding);
public static T IsClosed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsClosed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, func, onChanged, expression);
public static T IsClosed<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static T IsClosed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T NotificationType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, binding);
public static T NotificationType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T NotificationType<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.NotificationCard
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, func, onChanged, expression);
public static T NotificationType<T>(this T control, Avalonia.Controls.Notifications.NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = value, bindingMode, converter, bindingSource);
public static T NotificationType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.NotificationCard
=> control._setEx(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

