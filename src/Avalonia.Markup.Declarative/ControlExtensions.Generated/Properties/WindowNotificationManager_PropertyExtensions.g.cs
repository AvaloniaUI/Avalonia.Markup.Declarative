#nullable enable
using Avalonia.Controls.Notifications;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WindowNotificationManager = Avalonia.Controls.Notifications.WindowNotificationManager;

namespace Avalonia.Markup.Declarative;
public static partial class WindowNotificationManagerExtensions
{
public static T Position<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, func, onChanged, expression);
public static T Position<T>(this T control, Avalonia.Controls.Notifications.NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, ps, () => control.Position = value, bindingMode, converter, bindingSource);
public static T Position<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);
public static T MaxItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxItems<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, func, onChanged, expression);
public static T MaxItems<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);
public static T MaxItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

