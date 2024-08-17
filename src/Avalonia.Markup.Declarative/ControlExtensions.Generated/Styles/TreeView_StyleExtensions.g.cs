using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TreeView = Avalonia.Controls.TreeView;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewExtensions
{
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeView
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, value);
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, binding);
}

