using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class FlyoutBaseEventsExtensions
{
    public static T OnOpened<T>(this T control, Action action) where T : FlyoutBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static T OnClosed<T>(this T control, Action action) where T : FlyoutBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
}

