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
public static Style<SplitButton> Command(this Style<SplitButton> style, ICommand value)
=> style._addSetter(SplitButton.CommandProperty, value);
public static Style<SplitButton> Command(this Style<SplitButton> style, IBinding binding)
=> style._addSetter(SplitButton.CommandProperty, binding);
public static Style<SplitButton> CommandParameter(this Style<SplitButton> style, Object value)
=> style._addSetter(SplitButton.CommandParameterProperty, value);
public static Style<SplitButton> CommandParameter(this Style<SplitButton> style, IBinding binding)
=> style._addSetter(SplitButton.CommandParameterProperty, binding);
public static Style<SplitButton> Flyout(this Style<SplitButton> style, FlyoutBase value)
=> style._addSetter(SplitButton.FlyoutProperty, value);
public static Style<SplitButton> Flyout(this Style<SplitButton> style, IBinding binding)
=> style._addSetter(SplitButton.FlyoutProperty, binding);
public static Style<SplitButton> HotKey(this Style<SplitButton> style, KeyGesture value)
=> style._addSetter(SplitButton.HotKeyProperty, value);
public static Style<SplitButton> HotKey(this Style<SplitButton> style, IBinding binding)
=> style._addSetter(SplitButton.HotKeyProperty, binding);
}

