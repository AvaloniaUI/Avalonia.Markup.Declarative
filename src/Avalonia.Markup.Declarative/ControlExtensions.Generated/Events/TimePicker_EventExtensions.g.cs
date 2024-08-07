using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerEventsExtensions
{
    public static TimePicker OnSelectedTimeChanged(this TimePicker control, Action<TimePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<TimePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedTimeChanged += h);
}

