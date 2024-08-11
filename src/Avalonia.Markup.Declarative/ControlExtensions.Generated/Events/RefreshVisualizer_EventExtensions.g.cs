using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshVisualizerEventsExtensions
{
    public static T OnRefreshRequested<T>(this T control, Action<RefreshRequestedEventArgs> action) where T : RefreshVisualizer => 
        control._setEvent((EventHandler<RefreshRequestedEventArgs>) ((_, args) => action(args)), h => control.RefreshRequested += h);
}

