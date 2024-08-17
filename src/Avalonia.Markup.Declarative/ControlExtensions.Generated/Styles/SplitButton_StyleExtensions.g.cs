using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using SplitButton = Avalonia.Controls.SplitButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class SplitButtonExtensions
{
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, value);
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, binding);
}

