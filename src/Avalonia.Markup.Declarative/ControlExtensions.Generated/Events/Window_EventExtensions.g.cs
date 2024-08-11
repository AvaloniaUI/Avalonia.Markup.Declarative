using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowEventsExtensions
{
    public static T OnClosing<T>(this T control, Action<WindowClosingEventArgs> action) where T : Window => 
        control._setEvent((EventHandler<WindowClosingEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
}

