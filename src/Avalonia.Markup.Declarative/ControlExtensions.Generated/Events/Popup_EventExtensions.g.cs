using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupEventsExtensions
{
    public static T OnClosed<T>(this T control, Action<EventArgs> action) where T : Popup => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
    public static T OnOpened<T>(this T control, Action action) where T : Popup => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
}

