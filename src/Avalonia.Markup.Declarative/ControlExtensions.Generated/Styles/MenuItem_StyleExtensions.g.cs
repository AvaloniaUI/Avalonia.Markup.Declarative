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
public static Style<T> Command<T>(this Style<T> style, ICommand value) where T : MenuItem
=> style._addSetter(MenuItem.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.CommandProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, KeyGesture value) where T : MenuItem
=> style._addSetter(MenuItem.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.HotKeyProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, Object value) where T : MenuItem
=> style._addSetter(MenuItem.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.CommandParameterProperty, binding);
public static Style<T> Icon<T>(this Style<T> style, Object value) where T : MenuItem
=> style._addSetter(MenuItem.IconProperty, value);
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.IconProperty, binding);
public static Style<T> InputGesture<T>(this Style<T> style, KeyGesture value) where T : MenuItem
=> style._addSetter(MenuItem.InputGestureProperty, value);
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.InputGestureProperty, binding);
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, Boolean value) where T : MenuItem
=> style._addSetter(MenuItem.IsSubMenuOpenProperty, value);
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.IsSubMenuOpenProperty, binding);
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, Boolean value) where T : MenuItem
=> style._addSetter(MenuItem.StaysOpenOnClickProperty, value);
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.StaysOpenOnClickProperty, binding);
public static Style<T> ToggleType<T>(this Style<T> style, MenuItemToggleType value) where T : MenuItem
=> style._addSetter(MenuItem.ToggleTypeProperty, value);
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.ToggleTypeProperty, binding);
public static Style<T> IsChecked<T>(this Style<T> style, Boolean value) where T : MenuItem
=> style._addSetter(MenuItem.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.IsCheckedProperty, binding);
public static Style<T> GroupName<T>(this Style<T> style, String value) where T : MenuItem
=> style._addSetter(MenuItem.GroupNameProperty, value);
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : MenuItem
=> style._addSetter(MenuItem.GroupNameProperty, binding);
}

