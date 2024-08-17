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
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, value);
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, value);
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);
}

