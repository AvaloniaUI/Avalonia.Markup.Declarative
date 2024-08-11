using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonExtensions
{
public static Style<T> ClickMode<T>(this Style<T> style, ClickMode value) where T : Button
=> style._addSetter(Button.ClickModeProperty, value);
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.ClickModeProperty, binding);
public static Style<T> Command<T>(this Style<T> style, ICommand value) where T : Button
=> style._addSetter(Button.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.CommandProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, KeyGesture value) where T : Button
=> style._addSetter(Button.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.HotKeyProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, Object value) where T : Button
=> style._addSetter(Button.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.CommandParameterProperty, binding);
public static Style<T> IsDefault<T>(this Style<T> style, Boolean value) where T : Button
=> style._addSetter(Button.IsDefaultProperty, value);
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.IsDefaultProperty, binding);
public static Style<T> IsCancel<T>(this Style<T> style, Boolean value) where T : Button
=> style._addSetter(Button.IsCancelProperty, value);
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.IsCancelProperty, binding);
public static Style<T> Flyout<T>(this Style<T> style, FlyoutBase value) where T : Button
=> style._addSetter(Button.FlyoutProperty, value);
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Button
=> style._addSetter(Button.FlyoutProperty, binding);
}

