using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using ItemsControl = Avalonia.Controls.ItemsControl;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsControlExtensions
{
public static Style<T> ItemContainerTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, value);
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, value);
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, value);
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, value);
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl
=> style._addSetter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, value);
//Skipped DisplayMemberBinding because already exist in value setters
}

