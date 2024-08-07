using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerEventsExtensions
{
    public static Spinner OnSpin(this Spinner control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spin += h);
}

