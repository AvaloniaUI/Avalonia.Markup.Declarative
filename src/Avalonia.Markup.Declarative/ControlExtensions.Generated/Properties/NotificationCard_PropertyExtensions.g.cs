#nullable enable
using Avalonia.Controls.Notifications;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NotificationCardExtensions
{
public static T IsClosed<T>(this T control, IBinding binding) where T : NotificationCard
   => control._set(NotificationCard.IsClosedProperty, binding);
public static T IsClosed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NotificationCard
   => control._set(NotificationCard.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsClosed<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NotificationCard
   => control._set(NotificationCard.IsClosedProperty, func, onChanged, expression);
public static T IsClosed<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NotificationCard
=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static T IsClosed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NotificationCard
=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T NotificationType<T>(this T control, IBinding binding) where T : NotificationCard
   => control._set(NotificationCard.NotificationTypeProperty, binding);
public static T NotificationType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NotificationCard
   => control._set(NotificationCard.NotificationTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T NotificationType<T>(this T control, Func<NotificationType> func, Action<NotificationType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NotificationCard
   => control._set(NotificationCard.NotificationTypeProperty, func, onChanged, expression);
public static T NotificationType<T>(this T control, NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NotificationCard
=> control._setEx(NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = value, bindingMode, converter, bindingSource);
public static T NotificationType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NotificationCard
=> control._setEx(NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

