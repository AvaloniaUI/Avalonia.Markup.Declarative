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
    public static RangeBase OnValueChanged(this RangeBase control, Action<RangeBaseValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<RangeBaseValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}

