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
    public static DateTimePickerPanel OnScrollInvalidated(this DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScrollInvalidated += h);
    public static DateTimePickerPanel OnSelectionChanged(this DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.SelectionChanged += h);
}

