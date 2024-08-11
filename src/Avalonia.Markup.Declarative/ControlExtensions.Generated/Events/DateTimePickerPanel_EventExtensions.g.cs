using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelEventsExtensions
{
    public static T OnScrollInvalidated<T>(this T control, Action action) where T : DateTimePickerPanel => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScrollInvalidated += h);
    public static T OnSelectionChanged<T>(this T control, Action action) where T : DateTimePickerPanel => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.SelectionChanged += h);
}

