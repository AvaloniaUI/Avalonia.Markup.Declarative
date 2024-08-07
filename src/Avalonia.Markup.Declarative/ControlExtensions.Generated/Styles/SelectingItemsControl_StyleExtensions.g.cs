using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControlExtensions
{
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, Boolean value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.AutoScrollToSelectedItemProperty, value);
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);
public static Style<T> SelectedIndex<T>(this Style<T> style, Int32 value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedIndexProperty, value);
public static Style<T> SelectedIndex<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedIndexProperty, binding);
public static Style<T> SelectedItem<T>(this Style<T> style, Object value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedItemProperty, value);
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedItemProperty, binding);
public static Style<T> SelectedValue<T>(this Style<T> style, Object value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedValueProperty, value);
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedValueProperty, binding);
public static Style<T> SelectedValueBinding<T>(this Style<T> style, IBinding value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.SelectedValueBindingProperty, value);
//Skipped SelectedValueBinding because already exist in value setters
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, Boolean value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.IsTextSearchEnabledProperty, value);
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.IsTextSearchEnabledProperty, binding);
public static Style<T> WrapSelection<T>(this Style<T> style, Boolean value) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.WrapSelectionProperty, value);
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : SelectingItemsControl
=> style._addSetter(SelectingItemsControl.WrapSelectionProperty, binding);
}

