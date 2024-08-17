using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ScrollViewer = Avalonia.Controls.ScrollViewer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerEventsExtensions
{
    public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action) where T : Avalonia.Controls.ScrollViewer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ScrollChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ScrollChanged += h);
}

