using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TimePicker = Avalonia.Controls.TimePicker;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerExtensions
{
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, value);
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, value);
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, value);
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);
}

