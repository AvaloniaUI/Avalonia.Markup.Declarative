using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using NumericUpDown = Avalonia.Controls.NumericUpDown;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NumericUpDownEventsExtensions
{
    public static T OnSpinned<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action) where T : Avalonia.Controls.NumericUpDown => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Spinned += h);
    public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.NumericUpDownValueChangedEventArgs> action) where T : Avalonia.Controls.NumericUpDown => 
        control._setEvent((System.EventHandler<Avalonia.Controls.NumericUpDownValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ValueChanged += h);
}

