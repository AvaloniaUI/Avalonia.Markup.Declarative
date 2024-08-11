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
public static partial class SplitButtonExtensions
{
public static Style<T> Command<T>(this Style<T> style, ICommand value) where T : SplitButton
=> style._addSetter(SplitButton.CommandProperty, value);
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : SplitButton
=> style._addSetter(SplitButton.CommandProperty, binding);
public static Style<T> CommandParameter<T>(this Style<T> style, Object value) where T : SplitButton
=> style._addSetter(SplitButton.CommandParameterProperty, value);
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : SplitButton
=> style._addSetter(SplitButton.CommandParameterProperty, binding);
public static Style<T> Flyout<T>(this Style<T> style, FlyoutBase value) where T : SplitButton
=> style._addSetter(SplitButton.FlyoutProperty, value);
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : SplitButton
=> style._addSetter(SplitButton.FlyoutProperty, binding);
public static Style<T> HotKey<T>(this Style<T> style, KeyGesture value) where T : SplitButton
=> style._addSetter(SplitButton.HotKeyProperty, value);
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : SplitButton
=> style._addSetter(SplitButton.HotKeyProperty, binding);
}

