using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TransitioningContentControl = Avalonia.Controls.TransitioningContentControl;

namespace Avalonia.Markup.Declarative;
public static partial class TransitioningContentControlEventsExtensions
{
    public static T OnTransitionCompleted<T>(this T control, Action<Avalonia.Controls.TransitionCompletedEventArgs> action) where T : Avalonia.Controls.TransitioningContentControl => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TransitionCompletedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TransitionCompleted += h);
}

