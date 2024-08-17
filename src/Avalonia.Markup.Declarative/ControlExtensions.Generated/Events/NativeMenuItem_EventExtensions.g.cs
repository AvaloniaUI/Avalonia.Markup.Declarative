using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using NativeMenuItem = Avalonia.Controls.NativeMenuItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuItemEventsExtensions
{
    public static T OnClick<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenuItem => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Click += h);
}

