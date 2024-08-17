using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using MenuItem = Avalonia.Controls.MenuItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class MenuItemExtensions
{
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, value);
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, binding);
public static Style<T> InputGesture<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, value);
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, binding);
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, value);
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, value);
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);
public static Style<T> ToggleType<T>(this Style<T> style, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, value);
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, value);
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, binding);
}

