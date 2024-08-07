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
public static WindowNotificationManager Position(this WindowNotificationManager control, IBinding binding)
   => control._set(WindowNotificationManager.PositionProperty, binding);
public static WindowNotificationManager Position(this WindowNotificationManager control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WindowNotificationManager Position(this WindowNotificationManager control, Func<NotificationPosition> func, Action<NotificationPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowNotificationManager.PositionProperty, func, onChanged, expression);
public static WindowNotificationManager Position(this WindowNotificationManager control, NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = value, bindingMode, converter, bindingSource);
public static WindowNotificationManager Position<TValue>(this WindowNotificationManager control, TValue value, FuncValueConverter<TValue, NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, IBinding binding)
   => control._set(WindowNotificationManager.MaxItemsProperty, binding);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowNotificationManager.MaxItemsProperty, func, onChanged, expression);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);
public static WindowNotificationManager MaxItems<TValue>(this WindowNotificationManager control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

