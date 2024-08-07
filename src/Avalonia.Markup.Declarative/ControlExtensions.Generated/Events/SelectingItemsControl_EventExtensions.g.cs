using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControlEventsExtensions
{
    public static T OnSelectionChanged<T>(this T control, Action<SelectionChangedEventArgs> action) where T : SelectingItemsControl => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}

