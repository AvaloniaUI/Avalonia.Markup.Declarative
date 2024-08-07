using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuEventsExtensions
{
    public static NativeMenu OnNeedsUpdate(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.NeedsUpdate += h);
    public static NativeMenu OnOpening(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Opening += h);
    public static NativeMenu OnClosed(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}

