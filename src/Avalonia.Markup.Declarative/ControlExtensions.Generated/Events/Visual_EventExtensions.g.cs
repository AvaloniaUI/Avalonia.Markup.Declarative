using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VisualEventsExtensions
{
    public static T OnAttachedToVisualTree<T>(this T control, Action<VisualTreeAttachmentEventArgs> action) where T : Visual => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToVisualTree += h);
    public static T OnDetachedFromVisualTree<T>(this T control, Action<VisualTreeAttachmentEventArgs> action) where T : Visual => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromVisualTree += h);
}

