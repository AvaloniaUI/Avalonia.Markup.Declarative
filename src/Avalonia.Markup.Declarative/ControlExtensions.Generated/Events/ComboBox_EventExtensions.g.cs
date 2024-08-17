using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ComboBox = Avalonia.Controls.ComboBox;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxEventsExtensions
{
    public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);
    public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);
}

