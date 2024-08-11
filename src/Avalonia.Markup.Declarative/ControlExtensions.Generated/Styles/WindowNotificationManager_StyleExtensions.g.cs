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
public static Style<T> Position<T>(this Style<T> style, NotificationPosition value) where T : WindowNotificationManager
=> style._addSetter(WindowNotificationManager.PositionProperty, value);
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : WindowNotificationManager
=> style._addSetter(WindowNotificationManager.PositionProperty, binding);
public static Style<T> MaxItems<T>(this Style<T> style, Int32 value) where T : WindowNotificationManager
=> style._addSetter(WindowNotificationManager.MaxItemsProperty, value);
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : WindowNotificationManager
=> style._addSetter(WindowNotificationManager.MaxItemsProperty, binding);
}

