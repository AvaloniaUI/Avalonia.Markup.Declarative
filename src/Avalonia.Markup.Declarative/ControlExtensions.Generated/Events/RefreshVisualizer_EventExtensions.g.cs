using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RefreshVisualizer = Avalonia.Controls.RefreshVisualizer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshVisualizerEventsExtensions
{
    public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action) where T : Avalonia.Controls.RefreshVisualizer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.RefreshRequestedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.RefreshRequested += h);
}

