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
public static Style<WindowNotificationManager> Position(this Style<WindowNotificationManager> style, NotificationPosition value)
=> style._addSetter(WindowNotificationManager.PositionProperty, value);
public static Style<WindowNotificationManager> Position(this Style<WindowNotificationManager> style, IBinding binding)
=> style._addSetter(WindowNotificationManager.PositionProperty, binding);
public static Style<WindowNotificationManager> MaxItems(this Style<WindowNotificationManager> style, Int32 value)
=> style._addSetter(WindowNotificationManager.MaxItemsProperty, value);
public static Style<WindowNotificationManager> MaxItems(this Style<WindowNotificationManager> style, IBinding binding)
=> style._addSetter(WindowNotificationManager.MaxItemsProperty, binding);
}

