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
public static Style<T> MinuteIncrement<T>(this Style<T> style, Int32 value) where T : TimePicker
=> style._addSetter(TimePicker.MinuteIncrementProperty, value);
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : TimePicker
=> style._addSetter(TimePicker.MinuteIncrementProperty, binding);
public static Style<T> ClockIdentifier<T>(this Style<T> style, String value) where T : TimePicker
=> style._addSetter(TimePicker.ClockIdentifierProperty, value);
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : TimePicker
=> style._addSetter(TimePicker.ClockIdentifierProperty, binding);
public static Style<T> SelectedTime<T>(this Style<T> style, Nullable<TimeSpan> value) where T : TimePicker
=> style._addSetter(TimePicker.SelectedTimeProperty, value);
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : TimePicker
=> style._addSetter(TimePicker.SelectedTimeProperty, binding);
}

