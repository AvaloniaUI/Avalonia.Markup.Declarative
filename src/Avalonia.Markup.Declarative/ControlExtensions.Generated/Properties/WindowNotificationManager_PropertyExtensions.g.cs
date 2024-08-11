#nullable enable
using Avalonia.Controls.Notifications;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowNotificationManagerExtensions
{
public static T Position<T>(this T control, IBinding binding) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.PositionProperty, binding);
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Position<T>(this T control, Func<NotificationPosition> func, Action<NotificationPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.PositionProperty, func, onChanged, expression);
public static T Position<T>(this T control, NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WindowNotificationManager
=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = value, bindingMode, converter, bindingSource);
public static T Position<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WindowNotificationManager
=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxItems<T>(this T control, IBinding binding) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.MaxItemsProperty, binding);
public static T MaxItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxItems<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : WindowNotificationManager
   => control._set(WindowNotificationManager.MaxItemsProperty, func, onChanged, expression);
public static T MaxItems<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WindowNotificationManager
=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);
public static T MaxItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : WindowNotificationManager
=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

