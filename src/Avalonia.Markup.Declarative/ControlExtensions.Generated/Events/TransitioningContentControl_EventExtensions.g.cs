using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TransitioningContentControlEventsExtensions
{
    public static TransitioningContentControl OnTransitionCompleted(this TransitioningContentControl control, Action<TransitionCompletedEventArgs> action) => 
        control._setEvent((EventHandler<TransitionCompletedEventArgs>) ((_, args) => action(args)), h => control.TransitionCompleted += h);
}

