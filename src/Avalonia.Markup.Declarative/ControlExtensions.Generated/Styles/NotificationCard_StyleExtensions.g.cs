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
public static Style<T> IsClosed<T>(this Style<T> style, Boolean value) where T : NotificationCard
=> style._addSetter(NotificationCard.IsClosedProperty, value);
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : NotificationCard
=> style._addSetter(NotificationCard.IsClosedProperty, binding);
public static Style<T> NotificationType<T>(this Style<T> style, NotificationType value) where T : NotificationCard
=> style._addSetter(NotificationCard.NotificationTypeProperty, value);
public static Style<T> NotificationType<T>(this Style<T> style, IBinding binding) where T : NotificationCard
=> style._addSetter(NotificationCard.NotificationTypeProperty, binding);
}

