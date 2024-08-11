using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NumericUpDownEventsExtensions
{
    public static T OnSpinned<T>(this T control, Action<SpinEventArgs> action) where T : NumericUpDown => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spinned += h);
    public static T OnValueChanged<T>(this T control, Action<NumericUpDownValueChangedEventArgs> action) where T : NumericUpDown => 
        control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}

