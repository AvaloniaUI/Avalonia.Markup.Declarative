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
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, Boolean value) where T : TreeView
=> style._addSetter(TreeView.AutoScrollToSelectedItemProperty, value);
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : TreeView
=> style._addSetter(TreeView.AutoScrollToSelectedItemProperty, binding);
public static Style<T> SelectedItem<T>(this Style<T> style, Object value) where T : TreeView
=> style._addSetter(TreeView.SelectedItemProperty, value);
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : TreeView
=> style._addSetter(TreeView.SelectedItemProperty, binding);
public static Style<T> SelectedItems<T>(this Style<T> style, IList value) where T : TreeView
=> style._addSetter(TreeView.SelectedItemsProperty, value);
public static Style<T> SelectedItems<T>(this Style<T> style, IBinding binding) where T : TreeView
=> style._addSetter(TreeView.SelectedItemsProperty, binding);
public static Style<T> SelectionMode<T>(this Style<T> style, SelectionMode value) where T : TreeView
=> style._addSetter(TreeView.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : TreeView
=> style._addSetter(TreeView.SelectionModeProperty, binding);
}

