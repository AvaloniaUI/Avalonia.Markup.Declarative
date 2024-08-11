using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewItemExtensions
{
public static Style<T> IsExpanded<T>(this Style<T> style, Boolean value) where T : TreeViewItem
=> style._addSetter(TreeViewItem.IsExpandedProperty, value);
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : TreeViewItem
=> style._addSetter(TreeViewItem.IsExpandedProperty, binding);
public static Style<T> IsSelected<T>(this Style<T> style, Boolean value) where T : TreeViewItem
=> style._addSetter(TreeViewItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : TreeViewItem
=> style._addSetter(TreeViewItem.IsSelectedProperty, binding);
}

