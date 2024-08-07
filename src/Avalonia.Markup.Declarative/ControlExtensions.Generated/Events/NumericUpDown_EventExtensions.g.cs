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
    public static NumericUpDown OnSpinned(this NumericUpDown control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spinned += h);
    public static NumericUpDown OnValueChanged(this NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}

