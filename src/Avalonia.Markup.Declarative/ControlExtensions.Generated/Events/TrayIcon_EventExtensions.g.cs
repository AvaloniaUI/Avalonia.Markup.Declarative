using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TrayIcon = Avalonia.Controls.TrayIcon;

namespace Avalonia.Markup.Declarative;
public static partial class TrayIconEventsExtensions
{
    public static T OnClicked<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TrayIcon => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Clicked += h);
}

