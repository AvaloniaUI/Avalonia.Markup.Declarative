using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshContainerEventsExtensions
{
    public static RefreshContainer OnRefreshRequested(this RefreshContainer control, Action<RefreshRequestedEventArgs> action) => 
        control._setEvent((EventHandler<RefreshRequestedEventArgs>) ((_, args) => action(args)), h => control.RefreshRequested += h);
}

