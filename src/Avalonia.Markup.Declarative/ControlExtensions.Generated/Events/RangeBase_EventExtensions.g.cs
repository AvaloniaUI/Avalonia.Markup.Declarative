using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RangeBase = Avalonia.Controls.Primitives.RangeBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseEventsExtensions
{
    public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action) where T : Avalonia.Controls.Primitives.RangeBase => 
        control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ValueChanged += h);
}

