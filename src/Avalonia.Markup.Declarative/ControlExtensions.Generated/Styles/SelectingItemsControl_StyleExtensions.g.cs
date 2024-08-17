using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using SelectingItemsControl = Avalonia.Controls.Primitives.SelectingItemsControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControlExtensions
{
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, value);
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);
public static Style<T> SelectedValue<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, value);
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);
public static Style<T> SelectedValueBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, value);
//Skipped SelectedValueBinding because already exist in value setters
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, value);
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);
public static Style<T> WrapSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, value);
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);
}

