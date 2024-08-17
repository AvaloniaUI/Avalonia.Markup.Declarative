using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Spinner = Avalonia.Controls.Spinner;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerEventsExtensions
{
    public static T OnSpin<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action) where T : Avalonia.Controls.Spinner => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Spin += h);
}

