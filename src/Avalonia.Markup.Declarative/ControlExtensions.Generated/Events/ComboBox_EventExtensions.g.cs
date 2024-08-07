using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxEventsExtensions
{
    public static ComboBox OnDropDownClosed(this ComboBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static ComboBox OnDropDownOpened(this ComboBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
}

