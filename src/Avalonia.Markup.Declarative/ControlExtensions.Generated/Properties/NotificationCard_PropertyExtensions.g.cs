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
public static NotificationCard IsClosed(this NotificationCard control, IBinding binding)
   => control._set(NotificationCard.IsClosedProperty, binding);
public static NotificationCard IsClosed(this NotificationCard control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NotificationCard.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NotificationCard IsClosed(this NotificationCard control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NotificationCard.IsClosedProperty, func, onChanged, expression);
public static NotificationCard IsClosed(this NotificationCard control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static NotificationCard IsClosed<TValue>(this NotificationCard control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NotificationCard NotificationType(this NotificationCard control, IBinding binding)
   => control._set(NotificationCard.NotificationTypeProperty, binding);
public static NotificationCard NotificationType(this NotificationCard control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NotificationCard.NotificationTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NotificationCard NotificationType(this NotificationCard control, Func<NotificationType> func, Action<NotificationType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NotificationCard.NotificationTypeProperty, func, onChanged, expression);
public static NotificationCard NotificationType(this NotificationCard control, NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = value, bindingMode, converter, bindingSource);
public static NotificationCard NotificationType<TValue>(this NotificationCard control, TValue value, FuncValueConverter<TValue, NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.NotificationTypeProperty, ps, () => control.NotificationType = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

