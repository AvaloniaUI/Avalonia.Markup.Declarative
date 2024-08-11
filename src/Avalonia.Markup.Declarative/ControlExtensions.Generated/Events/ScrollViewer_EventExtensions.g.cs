using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerEventsExtensions
{
    public static T OnScrollChanged<T>(this T control, Action<ScrollChangedEventArgs> action) where T : ScrollViewer => 
        control._setEvent((EventHandler<ScrollChangedEventArgs>) ((_, args) => action(args)), h => control.ScrollChanged += h);
}

