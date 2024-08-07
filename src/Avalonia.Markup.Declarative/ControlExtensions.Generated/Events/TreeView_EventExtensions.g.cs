using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewEventsExtensions
{
    public static TreeView OnSelectionChanged(this TreeView control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}

