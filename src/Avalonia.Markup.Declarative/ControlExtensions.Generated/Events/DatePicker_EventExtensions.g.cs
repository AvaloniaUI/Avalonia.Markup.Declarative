using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerEventsExtensions
{
    public static DatePicker OnSelectedDateChanged(this DatePicker control, Action<DatePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<DatePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}

