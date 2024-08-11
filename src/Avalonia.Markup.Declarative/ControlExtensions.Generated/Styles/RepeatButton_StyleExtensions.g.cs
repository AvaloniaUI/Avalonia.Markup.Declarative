using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RepeatButtonExtensions
{
public static Style<T> Interval<T>(this Style<T> style, Int32 value) where T : RepeatButton
=> style._addSetter(RepeatButton.IntervalProperty, value);
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : RepeatButton
=> style._addSetter(RepeatButton.IntervalProperty, binding);
public static Style<T> Delay<T>(this Style<T> style, Int32 value) where T : RepeatButton
=> style._addSetter(RepeatButton.DelayProperty, value);
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : RepeatButton
=> style._addSetter(RepeatButton.DelayProperty, binding);
}

