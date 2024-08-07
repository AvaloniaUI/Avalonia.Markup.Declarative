using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PickerPresenterBaseEventsExtensions
{
    public static PickerPresenterBase OnConfirmed(this PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Confirmed += h);
    public static PickerPresenterBase OnDismissed(this PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Dismissed += h);
}

