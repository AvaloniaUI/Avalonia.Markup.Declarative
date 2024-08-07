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
public static Style<Button> ClickMode(this Style<Button> style, ClickMode value)
=> style._addSetter(Button.ClickModeProperty, value);
public static Style<Button> ClickMode(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.ClickModeProperty, binding);
public static Style<Button> Command(this Style<Button> style, ICommand value)
=> style._addSetter(Button.CommandProperty, value);
public static Style<Button> Command(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.CommandProperty, binding);
public static Style<Button> HotKey(this Style<Button> style, KeyGesture value)
=> style._addSetter(Button.HotKeyProperty, value);
public static Style<Button> HotKey(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.HotKeyProperty, binding);
public static Style<Button> CommandParameter(this Style<Button> style, Object value)
=> style._addSetter(Button.CommandParameterProperty, value);
public static Style<Button> CommandParameter(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.CommandParameterProperty, binding);
public static Style<Button> IsDefault(this Style<Button> style, Boolean value)
=> style._addSetter(Button.IsDefaultProperty, value);
public static Style<Button> IsDefault(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.IsDefaultProperty, binding);
public static Style<Button> IsCancel(this Style<Button> style, Boolean value)
=> style._addSetter(Button.IsCancelProperty, value);
public static Style<Button> IsCancel(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.IsCancelProperty, binding);
public static Style<Button> Flyout(this Style<Button> style, FlyoutBase value)
=> style._addSetter(Button.FlyoutProperty, value);
public static Style<Button> Flyout(this Style<Button> style, IBinding binding)
=> style._addSetter(Button.FlyoutProperty, binding);
}

