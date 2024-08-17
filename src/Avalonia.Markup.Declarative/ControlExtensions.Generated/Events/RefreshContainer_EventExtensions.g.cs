using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RefreshContainer = Avalonia.Controls.RefreshContainer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshContainerEventsExtensions
{
    public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action) where T : Avalonia.Controls.RefreshContainer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.RefreshRequestedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.RefreshRequested += h);
}

