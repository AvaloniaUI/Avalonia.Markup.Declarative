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
public static Style<TreeViewItem> IsExpanded(this Style<TreeViewItem> style, Boolean value)
=> style._addSetter(TreeViewItem.IsExpandedProperty, value);
public static Style<TreeViewItem> IsExpanded(this Style<TreeViewItem> style, IBinding binding)
=> style._addSetter(TreeViewItem.IsExpandedProperty, binding);
public static Style<TreeViewItem> IsSelected(this Style<TreeViewItem> style, Boolean value)
=> style._addSetter(TreeViewItem.IsSelectedProperty, value);
public static Style<TreeViewItem> IsSelected(this Style<TreeViewItem> style, IBinding binding)
=> style._addSetter(TreeViewItem.IsSelectedProperty, binding);
}

