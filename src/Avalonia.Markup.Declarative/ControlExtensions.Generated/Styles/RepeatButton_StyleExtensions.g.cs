using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RepeatButton = Avalonia.Controls.RepeatButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RepeatButtonExtensions
{
public static Style<T> Interval<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, value);
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, binding);
public static Style<T> Delay<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, value);
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, binding);
}

