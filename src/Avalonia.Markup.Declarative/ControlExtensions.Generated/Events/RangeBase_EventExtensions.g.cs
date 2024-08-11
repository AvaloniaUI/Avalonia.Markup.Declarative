using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseEventsExtensions
{
    public static T OnValueChanged<T>(this T control, Action<RangeBaseValueChangedEventArgs> action) where T : RangeBase => 
        control._setEvent((EventHandler<RangeBaseValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}

