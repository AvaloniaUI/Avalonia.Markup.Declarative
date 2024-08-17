using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Button = Avalonia.Controls.Button;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonExtensions
{
public static Style<T> ClickMode<T>(this Style<T> style, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, value);
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, binding);
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, binding);
public static Style<T> IsDefault<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, value);
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, binding);
public static Style<T> IsCancel<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, value);
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, binding);
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, value);
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, binding);
}

