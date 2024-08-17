using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TreeViewItem = Avalonia.Controls.TreeViewItem;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewItemExtensions
{
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, value);
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);
}

