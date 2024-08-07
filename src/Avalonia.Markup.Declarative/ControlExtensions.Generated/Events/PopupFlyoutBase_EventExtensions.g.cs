using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupFlyoutBaseEventsExtensions
{
    public static T OnClosing<T>(this T control, Action<CancelEventArgs> action) where T : PopupFlyoutBase => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
    public static T OnOpening<T>(this T control, Action action) where T : PopupFlyoutBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opening += h);
}

