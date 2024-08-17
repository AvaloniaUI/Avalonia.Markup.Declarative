using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using PickerPresenterBase = Avalonia.Controls.Primitives.PickerPresenterBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PickerPresenterBaseEventsExtensions
{
    public static T OnConfirmed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Confirmed += h);
    public static T OnDismissed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Dismissed += h);
}

