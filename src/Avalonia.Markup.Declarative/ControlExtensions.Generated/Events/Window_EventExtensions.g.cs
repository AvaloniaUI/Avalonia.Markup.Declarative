using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Window = Avalonia.Controls.Window;

namespace Avalonia.Markup.Declarative;
public static partial class WindowEventsExtensions
{
    public static T OnClosing<T>(this T control, Action<Avalonia.Controls.WindowClosingEventArgs> action) where T : Avalonia.Controls.Window => 
        control._setEvent((System.EventHandler<Avalonia.Controls.WindowClosingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);
}

