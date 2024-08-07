using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewExtensions
{
public static Style<TreeView> AutoScrollToSelectedItem(this Style<TreeView> style, Boolean value)
=> style._addSetter(TreeView.AutoScrollToSelectedItemProperty, value);
public static Style<TreeView> AutoScrollToSelectedItem(this Style<TreeView> style, IBinding binding)
=> style._addSetter(TreeView.AutoScrollToSelectedItemProperty, binding);
public static Style<TreeView> SelectedItem(this Style<TreeView> style, Object value)
=> style._addSetter(TreeView.SelectedItemProperty, value);
public static Style<TreeView> SelectedItem(this Style<TreeView> style, IBinding binding)
=> style._addSetter(TreeView.SelectedItemProperty, binding);
public static Style<TreeView> SelectedItems(this Style<TreeView> style, IList value)
=> style._addSetter(TreeView.SelectedItemsProperty, value);
public static Style<TreeView> SelectedItems(this Style<TreeView> style, IBinding binding)
=> style._addSetter(TreeView.SelectedItemsProperty, binding);
public static Style<TreeView> SelectionMode(this Style<TreeView> style, SelectionMode value)
=> style._addSetter(TreeView.SelectionModeProperty, value);
public static Style<TreeView> SelectionMode(this Style<TreeView> style, IBinding binding)
=> style._addSetter(TreeView.SelectionModeProperty, binding);
}

