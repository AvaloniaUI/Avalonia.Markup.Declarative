using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsControlExtensions
{
public static Style<T> ItemContainerTheme<T>(this Style<T> style, ControlTheme value) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemContainerThemeProperty, value);
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemContainerThemeProperty, binding);
public static Style<T> ItemsPanel<T>(this Style<T> style, ITemplate<Panel> value) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemsPanelProperty, value);
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemsPanelProperty, binding);
public static Style<T> ItemsSource<T>(this Style<T> style, IEnumerable value) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemsSourceProperty, value);
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemsSourceProperty, binding);
public static Style<T> ItemTemplate<T>(this Style<T> style, IDataTemplate value) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemTemplateProperty, value);
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : ItemsControl
=> style._addSetter(ItemsControl.ItemTemplateProperty, binding);
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, IBinding value) where T : ItemsControl
=> style._addSetter(ItemsControl.DisplayMemberBindingProperty, value);
//Skipped DisplayMemberBinding because already exist in value setters
}

