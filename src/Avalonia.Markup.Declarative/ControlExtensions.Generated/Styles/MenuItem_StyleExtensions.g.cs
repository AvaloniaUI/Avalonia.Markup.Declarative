using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class MenuItemExtensions
{
public static Style<MenuItem> Command(this Style<MenuItem> style, ICommand value)
=> style._addSetter(MenuItem.CommandProperty, value);
public static Style<MenuItem> Command(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.CommandProperty, binding);
public static Style<MenuItem> HotKey(this Style<MenuItem> style, KeyGesture value)
=> style._addSetter(MenuItem.HotKeyProperty, value);
public static Style<MenuItem> HotKey(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.HotKeyProperty, binding);
public static Style<MenuItem> CommandParameter(this Style<MenuItem> style, Object value)
=> style._addSetter(MenuItem.CommandParameterProperty, value);
public static Style<MenuItem> CommandParameter(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.CommandParameterProperty, binding);
public static Style<MenuItem> Icon(this Style<MenuItem> style, Object value)
=> style._addSetter(MenuItem.IconProperty, value);
public static Style<MenuItem> Icon(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.IconProperty, binding);
public static Style<MenuItem> InputGesture(this Style<MenuItem> style, KeyGesture value)
=> style._addSetter(MenuItem.InputGestureProperty, value);
public static Style<MenuItem> InputGesture(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.InputGestureProperty, binding);
public static Style<MenuItem> IsSubMenuOpen(this Style<MenuItem> style, Boolean value)
=> style._addSetter(MenuItem.IsSubMenuOpenProperty, value);
public static Style<MenuItem> IsSubMenuOpen(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.IsSubMenuOpenProperty, binding);
public static Style<MenuItem> StaysOpenOnClick(this Style<MenuItem> style, Boolean value)
=> style._addSetter(MenuItem.StaysOpenOnClickProperty, value);
public static Style<MenuItem> StaysOpenOnClick(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.StaysOpenOnClickProperty, binding);
public static Style<MenuItem> ToggleType(this Style<MenuItem> style, MenuItemToggleType value)
=> style._addSetter(MenuItem.ToggleTypeProperty, value);
public static Style<MenuItem> ToggleType(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.ToggleTypeProperty, binding);
public static Style<MenuItem> IsChecked(this Style<MenuItem> style, Boolean value)
=> style._addSetter(MenuItem.IsCheckedProperty, value);
public static Style<MenuItem> IsChecked(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.IsCheckedProperty, binding);
public static Style<MenuItem> GroupName(this Style<MenuItem> style, String value)
=> style._addSetter(MenuItem.GroupNameProperty, value);
public static Style<MenuItem> GroupName(this Style<MenuItem> style, IBinding binding)
=> style._addSetter(MenuItem.GroupNameProperty, binding);
}

