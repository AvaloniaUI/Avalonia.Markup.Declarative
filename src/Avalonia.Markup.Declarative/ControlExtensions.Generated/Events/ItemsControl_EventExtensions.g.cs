using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsControlEventsExtensions
{
    public static T OnContainerPrepared<T>(this T control, Action<ContainerPreparedEventArgs> action) where T : ItemsControl => 
        control._setEvent((EventHandler<ContainerPreparedEventArgs>) ((_, args) => action(args)), h => control.ContainerPrepared += h);
    public static T OnContainerIndexChanged<T>(this T control, Action<ContainerIndexChangedEventArgs> action) where T : ItemsControl => 
        control._setEvent((EventHandler<ContainerIndexChangedEventArgs>) ((_, args) => action(args)), h => control.ContainerIndexChanged += h);
    public static T OnContainerClearing<T>(this T control, Action<ContainerClearingEventArgs> action) where T : ItemsControl => 
        control._setEvent((EventHandler<ContainerClearingEventArgs>) ((_, args) => action(args)), h => control.ContainerClearing += h);
}

