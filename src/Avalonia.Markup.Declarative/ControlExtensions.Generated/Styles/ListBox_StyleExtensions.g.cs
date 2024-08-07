using Avalonia.Controls;
using Avalonia.Controls.Selection;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxExtensions
{
public static Style<ListBox> SelectedItems(this Style<ListBox> style, IList value)
=> style._addSetter(ListBox.SelectedItemsProperty, value);
public static Style<ListBox> SelectedItems(this Style<ListBox> style, IBinding binding)
=> style._addSetter(ListBox.SelectedItemsProperty, binding);
public static Style<ListBox> Selection(this Style<ListBox> style, ISelectionModel value)
=> style._addSetter(ListBox.SelectionProperty, value);
public static Style<ListBox> Selection(this Style<ListBox> style, IBinding binding)
=> style._addSetter(ListBox.SelectionProperty, binding);
public static Style<ListBox> SelectionMode(this Style<ListBox> style, SelectionMode value)
=> style._addSetter(ListBox.SelectionModeProperty, value);
public static Style<ListBox> SelectionMode(this Style<ListBox> style, IBinding binding)
=> style._addSetter(ListBox.SelectionModeProperty, binding);
}

