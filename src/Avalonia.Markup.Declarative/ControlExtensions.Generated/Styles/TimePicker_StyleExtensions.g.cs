using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerExtensions
{
public static Style<TimePicker> MinuteIncrement(this Style<TimePicker> style, Int32 value)
=> style._addSetter(TimePicker.MinuteIncrementProperty, value);
public static Style<TimePicker> MinuteIncrement(this Style<TimePicker> style, IBinding binding)
=> style._addSetter(TimePicker.MinuteIncrementProperty, binding);
public static Style<TimePicker> ClockIdentifier(this Style<TimePicker> style, String value)
=> style._addSetter(TimePicker.ClockIdentifierProperty, value);
public static Style<TimePicker> ClockIdentifier(this Style<TimePicker> style, IBinding binding)
=> style._addSetter(TimePicker.ClockIdentifierProperty, binding);
public static Style<TimePicker> SelectedTime(this Style<TimePicker> style, Nullable<TimeSpan> value)
=> style._addSetter(TimePicker.SelectedTimeProperty, value);
public static Style<TimePicker> SelectedTime(this Style<TimePicker> style, IBinding binding)
=> style._addSetter(TimePicker.SelectedTimeProperty, binding);
}

