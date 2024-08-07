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
public static Style<NotificationCard> IsClosed(this Style<NotificationCard> style, Boolean value)
=> style._addSetter(NotificationCard.IsClosedProperty, value);
public static Style<NotificationCard> IsClosed(this Style<NotificationCard> style, IBinding binding)
=> style._addSetter(NotificationCard.IsClosedProperty, binding);
public static Style<NotificationCard> NotificationType(this Style<NotificationCard> style, NotificationType value)
=> style._addSetter(NotificationCard.NotificationTypeProperty, value);
public static Style<NotificationCard> NotificationType(this Style<NotificationCard> style, IBinding binding)
=> style._addSetter(NotificationCard.NotificationTypeProperty, binding);
}

