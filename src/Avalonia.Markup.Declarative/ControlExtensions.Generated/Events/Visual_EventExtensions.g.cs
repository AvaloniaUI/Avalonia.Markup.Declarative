using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Visual = Avalonia.Visual;

namespace Avalonia.Markup.Declarative;
public static partial class VisualEventsExtensions
{
    public static T OnAttachedToVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual => 
        control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToVisualTree += h);
    public static T OnDetachedFromVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual => 
        control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromVisualTree += h);
}

