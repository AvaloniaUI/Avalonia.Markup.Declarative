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
public static Style<RepeatButton> Interval(this Style<RepeatButton> style, Int32 value)
=> style._addSetter(RepeatButton.IntervalProperty, value);
public static Style<RepeatButton> Interval(this Style<RepeatButton> style, IBinding binding)
=> style._addSetter(RepeatButton.IntervalProperty, binding);
public static Style<RepeatButton> Delay(this Style<RepeatButton> style, Int32 value)
=> style._addSetter(RepeatButton.DelayProperty, value);
public static Style<RepeatButton> Delay(this Style<RepeatButton> style, IBinding binding)
=> style._addSetter(RepeatButton.DelayProperty, binding);
}

