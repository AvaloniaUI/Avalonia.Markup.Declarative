using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DateTimePickerPanel = Avalonia.Controls.Primitives.DateTimePickerPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelEventsExtensions
{
    public static T OnScrollInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScrollInvalidated += h);
    public static T OnSelectionChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);
}

