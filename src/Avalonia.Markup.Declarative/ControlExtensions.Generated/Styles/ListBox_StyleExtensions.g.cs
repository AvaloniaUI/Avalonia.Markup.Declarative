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
public static Style<T> SelectedItems<T>(this Style<T> style, IList value) where T : ListBox
=> style._addSetter(ListBox.SelectedItemsProperty, value);
public static Style<T> SelectedItems<T>(this Style<T> style, IBinding binding) where T : ListBox
=> style._addSetter(ListBox.SelectedItemsProperty, binding);
public static Style<T> Selection<T>(this Style<T> style, ISelectionModel value) where T : ListBox
=> style._addSetter(ListBox.SelectionProperty, value);
public static Style<T> Selection<T>(this Style<T> style, IBinding binding) where T : ListBox
=> style._addSetter(ListBox.SelectionProperty, binding);
public static Style<T> SelectionMode<T>(this Style<T> style, SelectionMode value) where T : ListBox
=> style._addSetter(ListBox.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : ListBox
=> style._addSetter(ListBox.SelectionModeProperty, binding);
}

